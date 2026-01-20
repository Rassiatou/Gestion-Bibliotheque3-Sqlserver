using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class LivreForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public LivreForm1()
        {
            InitializeComponent();
            this.Load += LivreForm1_Load;
        }

        private void LivreForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                SeedSiVide();
                ChargerCombos();
                ChargerGrille();
                ViderChamps();

                // Important : si pas branché dans Designer
                dgvLivres.CellClick -= dgvLivres_CellClick;
                dgvLivres.CellClick += dgvLivres_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement : " + ex.Message);
            }
        }

        // ----------------------------
        // Seed (optionnel)
        // ----------------------------
        private void SeedSiVide()
        {
            try
            {
                if (!_db.Auteurs.Any())
                {
                    _db.Auteurs.AddRange(
                        new Auteur { Nom = "Victor Hugo" },
                        new Auteur { Nom = "Monique Proulx" }
                    );

                    _db.Categories.AddRange(
                        new Categorie { Nom = "Roman" },
                        new Categorie { Nom = "Poésie" }
                    );

                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur seed auteurs/catégories : " + ex.Message);
            }
        }

        // ----------------------------
        // Combos
        // ----------------------------
        private void ChargerCombos()
        {
            try
            {
                cbAuteur.DisplayMember = "Nom";
                cbAuteur.ValueMember = "AuteurId";
                cbAuteur.DataSource = _db.Auteurs.OrderBy(a => a.Nom).ToList();

                cbCategorie.DisplayMember = "Nom";
                cbCategorie.ValueMember = "CategorieId";
                cbCategorie.DataSource = _db.Categories.OrderBy(c => c.Nom).ToList();

                if (cbAuteur.Items.Count > 0) cbAuteur.SelectedIndex = 0;
                if (cbCategorie.Items.Count > 0) cbCategorie.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement combos : " + ex.Message);
            }
        }

        // ----------------------------
        // Grille
        // ----------------------------
        private void ChargerGrille()
        {
            try
            {
                dgvLivres.DataSource = null;

                var data = _db.Livres
                    .Include(l => l.Auteur)
                    .Include(l => l.Categorie)
                    .OrderBy(l => l.Titre)
                    .Select(l => new
                    {
                        l.LivreId,                 // Col 0
                        l.Titre,                   // Col 1
                        l.ISBN,                    // Col 2
                        l.Annee,                   // Col 3
                        l.Quantite,                // Col 4
                        l.AuteurId,                // Col 5
                        Auteur = l.Auteur.Nom,     // Col 6
                        l.CategorieId,             // Col 7
                        Categorie = l.Categorie.Nom// Col 8
                    })
                    .ToList();

                dgvLivres.DataSource = data;
                dgvLivres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvLivres.ReadOnly = true;
                dgvLivres.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (chargement grille) : " + ex.Message);
            }
        }

        // ----------------------------
        // Ajouter
        // ----------------------------
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderAjout(out string titre, out string isbn, out int annee,
                                  out int quantite, out int auteurId, out int categorieId))
                    return;

                var livre = new Livre
                {
                    Titre = titre,
                    ISBN = isbn,
                    Annee = annee,
                    Quantite = quantite,
                    AuteurId = auteurId,
                    CategorieId = categorieId
                };

                _db.Livres.Add(livre);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Livre ajouté");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (ajout) : " + (ex.InnerException?.Message ?? ex.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (ajout) : " + ex.Message);
            }
        }

        // ----------------------------
        // Modifier
        // ----------------------------
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdLivre.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un livre à modifier (clique dans la liste).");
                    return;
                }

                if (!ValiderModification(out string titre, out string isbn, out int annee,
                                         out int quantite, out int auteurId, out int categorieId))
                    return;

                var livre = _db.Livres.FirstOrDefault(l => l.LivreId == id);
                if (livre == null)
                {
                    MessageBox.Show("Livre introuvable.");
                    return;
                }

                livre.Titre = titre;
                livre.ISBN = isbn;
                livre.Annee = annee;
                livre.Quantite = quantite;
                livre.AuteurId = auteurId;
                livre.CategorieId = categorieId;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Livre modifié");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (modif) : " + (ex.InnerException?.Message ?? ex.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (modif) : " + ex.Message);
            }
        }

        // ----------------------------
        // Supprimer
        // ----------------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdLivreSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un livre à supprimer.");
                    return;
                }

                bool estEmprunte = _db.Emprunts.Any(em => em.LivreId == id && em.DateRetour == null);
                if (estEmprunte)
                {
                    MessageBox.Show("Suppression interdite : ce livre est actuellement emprunté.");
                    return;
                }

                var livre = _db.Livres.FirstOrDefault(l => l.LivreId == id);
                if (livre == null)
                {
                    MessageBox.Show("Livre introuvable.");
                    return;
                }

                var confirm = MessageBox.Show("Confirmer suppression ?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _db.Livres.Remove(livre);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Livre supprimé");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (suppression) : " + (ex.InnerException?.Message ?? ex.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (suppression) : " + ex.Message);
            }
        }

        // ----------------------------
        // Rechercher par IdLivre
        // ----------------------------
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdClients.Text.Trim(), out int idLivre))
                {
                    MessageBox.Show("Entre un IdLivre valide.");
                    return;
                }

                var data = _db.Livres
                    .Include(l => l.Auteur)
                    .Include(l => l.Categorie)
                    .Where(l => l.LivreId == idLivre)
                    .Select(l => new
                    {
                        l.LivreId,
                        l.Titre,
                        l.ISBN,
                        l.Annee,
                        l.Quantite,
                        l.AuteurId,
                        Auteur = l.Auteur.Nom,
                        l.CategorieId,
                        Categorie = l.Categorie.Nom
                    })
                    .ToList();
                if (data.Count == 0)
                {
                    MessageBox.Show("Aucun livre trouvé avec cet IdLivre.");
                    return;
                }

                dgvLivres.DataSource = null;
                dgvLivres.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        // ----------------------------
        // Actualiser + Vider
        // ----------------------------
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try { ChargerGrille(); }
            catch (Exception ex) { MessageBox.Show("Erreur (actualiser) : " + ex.Message); }
        }

        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void ViderChamps()
        {
            txtIdLivre.Clear();
            txtTitre.Clear();
            txtISBN.Clear();
            textAnnée.Clear();
            nudQuantite.Value = 0;

            if (cbAuteur.Items.Count > 0) cbAuteur.SelectedIndex = 0;
            if (cbCategorie.Items.Count > 0) cbCategorie.SelectedIndex = 0;

            txtIdLivreSupp.Clear();
            txtListeIdClients.Clear();
        }

        // ----------------------------
        // CellClick robuste par index
        // ----------------------------
        private void dgvLivres_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvLivres.Rows[e.RowIndex];
            if (row == null) return;

            // IMPORTANT : Index selon ChargerGrille()
            txtIdLivre.Text = row.Cells[0].Value?.ToString();     // LivreId
            txtTitre.Text = row.Cells[1].Value?.ToString();       // Titre
            txtISBN.Text = row.Cells[2].Value?.ToString();        // ISBN
            textAnnée.Text = row.Cells[3].Value?.ToString();      // Annee

            // Quantite
            int q = 0;
            int.TryParse(row.Cells[4].Value?.ToString(), out q);
            nudQuantite.Value = q;

            // AuteurId
            if (row.Cells[5].Value != null)
                cbAuteur.SelectedValue = Convert.ToInt32(row.Cells[5].Value);

            // CategorieId
            if (row.Cells[7].Value != null)
                cbCategorie.SelectedValue = Convert.ToInt32(row.Cells[7].Value);

            // Supp
            txtIdLivreSupp.Text = txtIdLivre.Text;
        }

        // ----------------------------
        // Validations
        // ----------------------------
        private bool ValiderAjout(out string titre, out string isbn, out int annee,
                                 out int quantite, out int auteurId, out int categorieId)
        {
            titre = txtTitre.Text.Trim();
            isbn = txtISBN.Text.Trim();
            annee = 0;
            quantite = (int)nudQuantite.Value;
            auteurId = 0;
            categorieId = 0;

            if (string.IsNullOrWhiteSpace(titre))
            {
                MessageBox.Show("Titre obligatoire.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("ISBN obligatoire.");
                return false;
            }

            if (!int.TryParse(textAnnée.Text.Trim(), out annee))
            {
                MessageBox.Show("Année invalide (ex: 2024).");
                return false;
            }

            if (cbAuteur.SelectedValue == null || cbCategorie.SelectedValue == null)
            {
                MessageBox.Show("Choisis un auteur et une catégorie.");
                return false;
            }

            auteurId = (int)cbAuteur.SelectedValue;
            categorieId = (int)cbCategorie.SelectedValue;

            if (quantite < 0)
            {
                MessageBox.Show("Quantité invalide.");
                return false;
            }

            return true;
        }

        private bool ValiderModification(out string titre, out string isbn, out int annee,
                                  out int quantite, out int auteurId, out int categorieId)
        {
            // ✅ IMPORTANT : titre vient du champ MODIF
            titre = txtTitreModif.Text.Trim();

            // ⚠️ le reste garde ton fonctionnement actuel (mêmes champs que ton form actuel)
            isbn = txtISBN.Text.Trim();
            annee = 0;
            quantite = (int)nudQuantite.Value;
            auteurId = 0;
            categorieId = 0;

            if (string.IsNullOrWhiteSpace(titre))
            {
                MessageBox.Show("Titre obligatoire (modification).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("ISBN obligatoire.");
                return false;
            }

            if (!int.TryParse(textAnnée.Text.Trim(), out annee))
            {
                MessageBox.Show("Année invalide (ex: 2024).");
                return false;
            }

            if (cbAuteur.SelectedValue == null || cbCategorie.SelectedValue == null)
            {
                MessageBox.Show("Choisis un auteur et une catégorie.");
                return false;
            }

            auteurId = (int)cbAuteur.SelectedValue;
            categorieId = (int)cbCategorie.SelectedValue;

            if (quantite < 0)
            {
                MessageBox.Show("Quantité invalide.");
                return false;
            }

            return true;
        }


        // ----------------------------
        // Retour
        // ----------------------------
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
