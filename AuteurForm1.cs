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
            try
            {
                ChargerGrille();
                ViderChamps();

                // Important si pas fait dans le designer
                dgvAuteur.CellClick += dgvAuteur_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement : " + ex.Message);
            }
        }

        // ----------------------------
        // Charger la grille
        // ----------------------------
        private void ChargerGrille()
        {
            try
            {
                dgvAuteur.DataSource = null;

                var data = _db.Auteurs
                    .OrderBy(a => a.Nom)
                    .ThenBy(a => a.Prenom)
                    .ToList();

                dgvAuteur.DataSource = data;
                dgvAuteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAuteur.ReadOnly = true;
                dgvAuteur.MultiSelect = false;
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
                if (!ValiderAjout(out string nom, out string prenom))
                    return;

                var a = new Auteur
                {
                    Nom = nom,
                    Prenom = prenom
                };

                _db.Auteurs.Add(a);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Auteur ajouté");
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
                if (!int.TryParse(txtIdAuteur.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un auteur à modifier.");
                    return;
                }

                if (!ValiderModification(out string nom, out string prenom))
                    return;

                var a = _db.Auteurs.FirstOrDefault(x => x.AuteurId == id);
                if (a == null)
                {
                    MessageBox.Show("Auteur introuvable.");
                    return;
                }

                a.Nom = nom;
                a.Prenom = prenom;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Auteur modifié");
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
        // Supprimer (INTERDIT si utilisé par un Livre)
        // ----------------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdAuteurSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un auteur à supprimer.");
                    return;
                }

                // Règle : ne pas supprimer si un livre utilise cet auteur
                bool estUtilise = _db.Livres.Any(l => l.AuteurId == id);
                if (estUtilise)
                {
                    MessageBox.Show("Suppression interdite : cet auteur est utilisé par au moins un livre.");
                    return;
                }

                var a = _db.Auteurs.FirstOrDefault(x => x.AuteurId == id);
                if (a == null)
                {
                    MessageBox.Show("Auteur introuvable.");
                    return;
                }

                var confirm = MessageBox.Show("Confirmer suppression ?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _db.Auteurs.Remove(a);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Auteur supprimé");
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
        // Rechercher par IdAuteur
        // ----------------------------
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdAuteur.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdAuteur valide.");
                    return;
                }

                var data = _db.Auteurs
                    .Where(a => a.AuteurId == id)
                    .ToList();
                if (data.Count == 0)
                {
                    MessageBox.Show("Aucun AUTEUR trouvé avec cet IdAuteur.");
                    return;
                }

                dgvAuteur.DataSource = null;
                dgvAuteur.DataSource = data;
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
            ChargerGrille();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void ViderChamps()
        {
            // Ajout
            txtNomAuteur.Clear();
            txtPrenomAuteur.Clear();

            // Modif
            txtIdAuteur.Clear();
            txtNomAuteurModif.Clear();
            txtPrenomAuteurModif.Clear();

            // Supp
            txtIdAuteurSupp.Clear();

            // Recherche
            txtListeIdAuteur.Clear();
        }

        // ----------------------------
        // Click grille -> remplir modif/supp
        // ----------------------------
        private void dgvAuteur_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvAuteur.Rows[e.RowIndex].DataBoundItem is Auteur a)
            {
                // Modif
                txtIdAuteur.Text = a.AuteurId.ToString();
                txtNomAuteurModif.Text = a.Nom;
                txtPrenomAuteurModif.Text = a.Prenom;

                // Supp
                txtIdAuteurSupp.Text = a.AuteurId.ToString();
            }
        }

        // ----------------------------
        // Validations
        // ----------------------------
        private bool ValiderAjout(out string nom, out string prenom)
        {
            nom = txtNomAuteur.Text.Trim();
            prenom = txtPrenomAuteur.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Nom obligatoire.");
                return false;
            }

            // Prenom optionnel ? -> si tu veux l’obliger, décommente :
            // if (string.IsNullOrWhiteSpace(prenom)) { MessageBox.Show("Prénom obligatoire."); return false; }

            return true;
        }

        private bool ValiderModification(out string nom, out string prenom)
        {
            nom = txtNomAuteurModif.Text.Trim();
            prenom = txtPrenomAuteurModif.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Nom obligatoire (modification).");
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
