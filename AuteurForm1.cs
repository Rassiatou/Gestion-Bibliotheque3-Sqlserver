using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class AuteurForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public AuteurForm1()
        {
            InitializeComponent();

            this.Load += AuteurForm1_Load;
        }

        private void AuteurForm1_Load(object? sender, EventArgs e)
        {
            ChargerGrille();
        }

        // ==========================
        // CHARGER LA GRILLE
        // ==========================
        private void ChargerGrille()
        {
            try
            {
                dgvAuteur.DataSource = null;
                dgvAuteur.DataSource = _db.Auteurs
                    .OrderBy(a => a.Nom)
                    .ThenBy(a => a.Prenom)
                    .ToList();

                dgvAuteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement auteurs : " + ex.Message);
            }
        }

        // ==========================
        // AJOUTER
        // ==========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderChamps()) return;

                Auteur auteur = new Auteur
                {
                    Nom = txtNomAuteur.Text.Trim(),
                    Prenom = txtPrenomAuteur.Text.Trim()
                };

                _db.Auteurs.Add(auteur);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();

                MessageBox.Show("Auteur ajouté ✅");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (ajout) : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (ajout) : " + ex.Message);
            }
        }

        // ==========================
        // MODIFIER
        // ==========================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Id obligatoire
                if (!int.TryParse(txtIdAuteur.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un auteur dans la liste.");
                    return;
                }

                if (!ValiderChamps()) return;

                var auteur = _db.Auteurs.FirstOrDefault(a => a.AuteurId == id);
                if (auteur == null)
                {
                    MessageBox.Show("Auteur introuvable.");
                    return;
                }

                auteur.Nom = txtNomAuteur.Text.Trim();
                auteur.Prenom = txtPrenomAuteur.Text.Trim();

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();

                MessageBox.Show("Auteur modifié ✅");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (modif) : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (modif) : " + ex.Message);
            }
        }

        // ==========================
        // SUPPRIMER
        // ==========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdAuteur.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un auteur dans la liste.");
                    return;
                }

                // Inclure Livres pour vérifier la relation
                var auteur = _db.Auteurs
                    .Include(a => a.Livres)
                    .FirstOrDefault(a => a.AuteurId == id);

                if (auteur == null)
                {
                    MessageBox.Show("Auteur introuvable.");
                    return;
                }

                // ✅ empêche la suppression si l’auteur a des livres
                if (auteur.Livres != null && auteur.Livres.Any())
                {
                    MessageBox.Show("Suppression impossible : cet auteur a des livres associés.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Supprimer cet auteur ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _db.Auteurs.Remove(auteur);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();

                MessageBox.Show("Auteur supprimé ✅");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (suppression) : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (suppression) : " + ex.Message);
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
            txtIdAuteur.Clear();
            txtNomAuteur.Clear();
            txtPrenomAuteur.Clear();

            // ✅ IMPORTANT : change ce nom si ton champ s'appelle autrement
            txtListeIdAuteur.Clear();
        }

        // ==========================
        // ACTUALISER
        // ==========================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerGrille();
        }

        // ==========================
        // RECHERCHER (par IdAuteur)
        // ==========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ IMPORTANT : change ce nom si ton champ s'appelle autrement
                if (!int.TryParse(txtListeIdAuteur.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdAuteur valide (nombre).");
                    return;
                }

                var auteur = _db.Auteurs.FirstOrDefault(a => a.AuteurId == id);

                if (auteur == null)
                {
                    MessageBox.Show("Aucun auteur trouvé avec cet IdAuteur.");
                    return;
                }

                dgvAuteur.DataSource = null;
                dgvAuteur.DataSource = new[] { auteur }.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        // ==========================
        // RETOUR
        // ==========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================
        // VALIDATION
        // ==========================
        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtNomAuteur.Text))
            {
                MessageBox.Show("Nom obligatoire.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenomAuteur.Text))
            {
                MessageBox.Show("Prénom obligatoire.");
                return false;
            }

            return true;
        }

        // ==========================
        // OPTION : clic dans la grille
        // (À brancher dans le designer: dgvAuteurs -> CellClick)
        // ==========================
        private void dgvAuteurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvAuteur.Rows[e.RowIndex].DataBoundItem is Auteur a)
            {
                txtIdAuteur.Text = a.AuteurId.ToString();
                txtNomAuteur.Text = a.Nom;
                txtPrenomAuteur.Text = a.Prenom;
            }
        }
    }
}
