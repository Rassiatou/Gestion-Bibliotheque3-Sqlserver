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
        // ✅ DbContext pour EF
        private readonly BiblioContext _db = new BiblioContext();

        public LivreForm1()
        {
            InitializeComponent();
            this.Load += LivreForm1_Load;
        }


        // ==========================
        // AU CHARGEMENT DU FORM
        // ==========================
        private void LivreForm1_Load(object? sender, EventArgs e)
        {
            SeedSiVide();
            ChargerCombos();
            ChargerGrille();
        }

        private void SeedSiVide()
        {
            // Si pas d'auteurs, on met quelques données
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

        private void ChargerCombos()
        {
            // Auteur
            cbAuteur.DisplayMember = "Nom";
            cbAuteur.ValueMember = "AuteurId";
            cbAuteur.DataSource = _db.Auteurs.OrderBy(a => a.Nom).ToList();

            // Catégorie
            cbCategorie.DisplayMember = "Nom";
            cbCategorie.ValueMember = "CategorieId";
            cbCategorie.DataSource = _db.Categories.OrderBy(c => c.Nom).ToList();
        }

        private void ChargerGrille()
        {
            dgvLivres.DataSource = null;
            dgvLivres.DataSource = _db.Livres
                .Include(l => l.Auteur)
                .Include(l => l.Categorie)
                .OrderBy(l => l.Titre)
                .ToList();

            dgvLivres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==========================
        // AJOUTER
        // ==========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps(out int annee)) return;

            var livre = new Livre
            {
                Titre = txtTitre.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Annee = annee,
                Quantite = (int)nudQuantite.Value,
                AuteurId = (int)cbAuteur.SelectedValue,
                CategorieId = (int)cbCategorie.SelectedValue
            };

            _db.Livres.Add(livre);
            _db.SaveChanges();

            ChargerGrille();
            ViderChamps();
            MessageBox.Show("Livre ajouté ✅");
        }

        // ==========================
        // MODIFIER (on code après si tu veux)
        // ==========================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // ✅ Version simple : on modifie le livre sélectionné via txtIdLivre
            if (!int.TryParse(txtIdLivre.Text, out int id))
            {
                MessageBox.Show("Sélectionne un livre dans la liste.");
                return;
            }

            if (!ValiderChamps(out int annee)) return;

            var livre = _db.Livres.FirstOrDefault(l => l.LivreId == id);
            if (livre == null)
            {
                MessageBox.Show("Livre introuvable.");
                return;
            }

            livre.Titre = txtTitre.Text.Trim();
            livre.ISBN = txtISBN.Text.Trim();
            livre.Annee = annee;
            livre.Quantite = (int)nudQuantite.Value;
            livre.AuteurId = (int)cbAuteur.SelectedValue;
            livre.CategorieId = (int)cbCategorie.SelectedValue;

            _db.SaveChanges();

            ChargerGrille();
            ViderChamps();
            MessageBox.Show("Livre modifié ✅");
        }

        // ==========================
        // SUPPRIMER
        // ==========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdLivreSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdLivre invalide.");
                    return;
                }

                bool estEmprunte = _db.Emprunts.Any(em => em.LivreId == id && em.DateRetour == null);

                if (estEmprunte)
                {
                    MessageBox.Show("Impossible de supprimer : ce livre est actuellement emprunté.");
                    return;
                }

                // (optionnel) si tu veux bloquer même si emprunt retourné :
                // bool aHistorique = _db.Emprunts.Any(em => em.LivreId == id);
                // if (aHistorique) { MessageBox.Show("Impossible : historique d'emprunt."); return; }

                var livre = _db.Livres.FirstOrDefault(l => l.LivreId == id);
                if (livre == null)
                {
                    MessageBox.Show("Livre introuvable.");
                    return;
                }

                _db.Livres.Remove(livre);
                _db.SaveChanges();

                MessageBox.Show("Livre supprimé ✅");
                ChargerGrille();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression livre:\n\n" + ex.Message);
            }
        }


        // ==========================
        // VIDER
        // ==========================
        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void ViderChamps()
        {
            txtIdLivre.Clear();
            txtTitre.Clear();
            txtISBN.Clear();
            textAnnée.Clear();
            nudQuantite.Value = 0;

            if (cbAuteur.Items.Count > 0) cbAuteur.SelectedIndex = 0;
            if (cbCategorie.Items.Count > 0) cbCategorie.SelectedIndex = 0;


            // ✅ ICI : on vide TON champ de recherche réel
            txtListeIdClients.Clear();
        }

        // ==========================
        // ACTUALISER
        // ==========================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerGrille();
        }

        // ==========================
        // RECHERCHER
        // ==========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // Vérifier que l'utilisateur a bien entré un nombre
            if (!int.TryParse(txtListeIdClients.Text.Trim(), out int idLivre))
            {
                MessageBox.Show("Entre un IdLivre valide (nombre).");
                return;
            }

            var livre = _db.Livres
                .Include(l => l.Auteur)
                .Include(l => l.Categorie)
                .FirstOrDefault(l => l.LivreId == idLivre);

            if (livre == null)
            {
                MessageBox.Show("Aucun livre trouvé avec cet IdLivre.");
                return;
            }

            // On affiche uniquement ce livre dans la grille
            dgvLivres.DataSource = null;
            dgvLivres.DataSource = new List<Livre> { livre };
        }

        // ==========================
        // RETOUR
        // ==========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================
        // EVENT INUTILE (tu peux le laisser vide)
        // ==========================
        private void label2_Click(object sender, EventArgs e)
        {
            // rien
        }

        // ==========================
        // VALIDATION
        // ==========================
        private bool ValiderChamps(out int annee)
        {
            annee = 0;

            if (string.IsNullOrWhiteSpace(txtTitre.Text))
            {
                MessageBox.Show("Titre obligatoire.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("ISBN obligatoire.");
                return false;
            }

            if (!int.TryParse(textAnnée.Text, out annee))
            {
                MessageBox.Show("Année invalide (ex: 2024).");
                return false;
            }

            if (cbAuteur.SelectedValue == null || cbCategorie.SelectedValue == null)
            {
                MessageBox.Show("Choisis un auteur et une catégorie.");
                return false;
            }

            return true;
        }
    }
}
