using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class CategorieForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public CategorieForm1()
        {
            InitializeComponent();
            this.Load += CategorieForm1_Load;
        }

        private void CategorieForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                ChargerGrille();
                ViderChamps();

                // Important : si pas branché dans le Designer
                dgvCategorie.CellClick -= dgvCategorie_CellClick;
                dgvCategorie.CellClick += dgvCategorie_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement : " + ex.Message);
            }
        }

        // ----------------------------
        // Chargement grille
        // ----------------------------
        private void ChargerGrille()
        {
            dgvCategorie.DataSource = null;

            var data = _db.Categories
                .OrderBy(c => c.Nom)
                .ToList();

            dgvCategorie.DataSource = data;
            dgvCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorie.ReadOnly = true;
            dgvCategorie.MultiSelect = false;
        }

        // ----------------------------
        // Ajouter
        // ----------------------------
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderAjout(out string nom, out string desc))
                    return;

                // (Optionnel) éviter doublon Nom
                bool existe = _db.Categories.Any(c => c.Nom == nom);
                if (existe)
                {
                    MessageBox.Show("Cette catégorie existe déjà.");
                    return;
                }

                var cat = new Categorie
                {
                    Nom = nom,
                    Description = desc
                };

                _db.Categories.Add(cat);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Catégorie ajoutée");
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
                if (!int.TryParse(txtIdCategorie.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne une catégorie à modifier.");
                    return;
                }

                if (!ValiderModification(out string nom, out string desc))
                    return;

                var cat = _db.Categories.FirstOrDefault(c => c.CategorieId == id);
                if (cat == null)
                {
                    MessageBox.Show("Catégorie introuvable.");
                    return;
                }

                // (Optionnel) éviter doublon Nom avec une autre catégorie
                bool doublon = _db.Categories.Any(c => c.Nom == nom && c.CategorieId != id);
                if (doublon)
                {
                    MessageBox.Show("Une autre catégorie porte déjà ce nom.");
                    return;
                }

                cat.Nom = nom;
                cat.Description = desc;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Catégorie modifiée");
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
        // Supprimer (bloqué si utilisée par des livres)
        // ----------------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdCategorieSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne une catégorie à supprimer.");
                    return;
                }

                var cat = _db.Categories
                    .Include(c => c.Livres)
                    .FirstOrDefault(c => c.CategorieId == id);

                if (cat == null)
                {
                    MessageBox.Show("Catégorie introuvable.");
                    return;
                }

                if (cat.Livres != null && cat.Livres.Count > 0)
                {
                    MessageBox.Show("Suppression interdite : cette catégorie est utilisée par des livres.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Confirmer suppression ?",
                    "Suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes) return;

                _db.Categories.Remove(cat);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Catégorie supprimée");
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
        // Rechercher par IdCategorie
        // ----------------------------
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdCategorie.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdCategorie valide.");
                    return;
                }

                var data = _db.Categories
                    .Where(c => c.CategorieId == id)
                    .ToList();

                dgvCategorie.DataSource = null;
                dgvCategorie.DataSource = data;

                if (data.Count == 0)
                    MessageBox.Show("Aucune catégorie trouvée avec cet Id.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        // ----------------------------
        // Actualiser + Vider + Retour
        // ----------------------------
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try { ChargerGrille(); }
            catch (Exception ex) { MessageBox.Show("Erreur (actualiser) : " + ex.Message); }
        }

        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void btnRetour_Click(object sender, EventArgs e) => this.Close();

        private void ViderChamps()
        {
            // Ajout
            txtNomCategorie.Clear();
            txtDescription.Clear();

            // Modif
            txtIdCategorie.Clear();
            txtNomCategorieModif.Clear();
            txtDescriptionModif.Clear();

            // Supp
            txtIdCategorieSupp.Clear();

            // Recherche
            txtListeIdCategorie.Clear();
        }

        // ----------------------------
        // Click ligne -> remplir modif/supp
        // ----------------------------
        private void dgvCategorie_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCategorie.Rows[e.RowIndex].DataBoundItem is Categorie cat)
            {
                // Modif
                txtIdCategorie.Text = cat.CategorieId.ToString();
                txtNomCategorieModif.Text = cat.Nom;
                txtDescriptionModif.Text = cat.Description;

                // Supp
                txtIdCategorieSupp.Text = cat.CategorieId.ToString();
            }
        }

        // ----------------------------
        // Validations
        // ----------------------------
        private bool ValiderAjout(out string nom, out string desc)
        {
            nom = txtNomCategorie.Text.Trim();
            desc = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Nom obligatoire.");
                return false;
            }

            // Description peut être vide (OK)
            return true;
        }

        private bool ValiderModification(out string nom, out string desc)
        {
            nom = txtNomCategorieModif.Text.Trim();
            desc = txtDescriptionModif.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Nom obligatoire (modification).");
                return false;
            }

            return true;
        }
    }
}
