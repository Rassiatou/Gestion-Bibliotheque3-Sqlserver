using Microsoft.EntityFrameworkCore;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class EmpruntForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public EmpruntForm1()
        {
            InitializeComponent();
            this.Load += EmpruntForm1_Load;
        }


        private void EmpruntForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                ChargerCombos();
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement :\n\n" + ex.Message);
            }
        }

        // =========================
        // CHARGEMENTS
        // =========================
        private void ChargerCombos()
        {
            // Combo Usager
            cmbUsager.DisplayMember = "Nom";      // adapte si ton Usager a Nom/Prenom
            cmbUsager.ValueMember = "UsagerId";
            cmbUsager.DataSource = _db.Usagers
                .OrderBy(u => u.Nom)
                .ToList();

            // Combo Livre (on affiche le titre)
            cmbLivre.DisplayMember = "Titre";
            cmbLivre.ValueMember = "LivreId";
            cmbLivre.DataSource = _db.Livres
                .OrderBy(l => l.Titre)
                .ToList();
        }

        private void ChargerGrille()
        {
            dgvEmprunt.DataSource = null;

            dgvEmprunt.DataSource = _db.Emprunts
                .Include(e => e.Usager)
                .Include(e => e.Livre)
                .OrderByDescending(e => e.DateEmprunt)
                .ToList();

            dgvEmprunt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmprunt.ReadOnly = true;
            dgvEmprunt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmprunt.MultiSelect = false;
        }

        // =========================
        // AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Validations de base
                if (cmbUsager.SelectedValue == null || cmbLivre.SelectedValue == null)
                {
                    MessageBox.Show("Choisis un usager et un livre.");
                    return;
                }

                int usagerId = (int)cmbUsager.SelectedValue;
                int livreId = (int)cmbLivre.SelectedValue;

                DateTime dateEmprunt = dtpDateEmprunt.Value.Date;
                DateTime dateRetourPrevue = dtpRetourPrevu.Value.Date;

                if (dateRetourPrevue < dateEmprunt)
                {
                    MessageBox.Show("La date de retour prévue doit être >= date d'emprunt.");
                    return;
                }

                // 2) Vérifier la quantité du livre
                var livre = _db.Livres.FirstOrDefault(l => l.LivreId == livreId);
                if (livre == null)
                {
                    MessageBox.Show("Livre introuvable.");
                    return;
                }

                if (livre.Quantite <= 0)
                {
                    MessageBox.Show("Impossible : ce livre n'est pas disponible (quantité = 0).");
                    return;
                }

                // 3) Créer l'emprunt
                var emprunt = new Emprunt
                {
                    UsagerId = usagerId,
                    LivreId = livreId,
                    DateEmprunt = dateEmprunt,
                    DateRetourPrevue = dateRetourPrevue,
                    DateRetour = null // pas retourné
                };

                // 4) Diminuer quantité
                livre.Quantite -= 1;

                // 5) Sauvegarde
                _db.Emprunts.Add(emprunt);
                _db.SaveChanges();

                MessageBox.Show("Emprunt ajouté ✅");
                ChargerGrille();
                ChargerCombos(); // pour rafraîchir si tu filtres des livres dispo plus tard
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur base de données :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ajout emprunt :\n\n" + ex.Message);
            }
        }

        // =========================
        // RETOURNER
        // =========================
        private void btnRetourner_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEmpruntRetour.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEmprunt invalide.");
                    return;
                }

                var emprunt = _db.Emprunts
                    .Include(e => e.Livre)
                    .FirstOrDefault(e => e.EmpruntId == id);

                if (emprunt == null)
                {
                    MessageBox.Show("Emprunt introuvable.");
                    return;
                }

                if (emprunt.DateRetour != null)
                {
                    MessageBox.Show("Cet emprunt est déjà retourné.");
                    return;
                }

                // Retour
                emprunt.DateRetour = dtpDateRetourReel.Value.Date;

                // Remettre le livre disponible
                if (emprunt.Livre != null)
                    emprunt.Livre.Quantite += 1;

                _db.SaveChanges();

                MessageBox.Show("Livre retourné ✅");
                ChargerGrille();
                ChargerCombos();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur retour :\n\n" + ex.Message);
            }
        }

        // =========================
        // SUPPRIMER
        // =========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEmpruntSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEmprunt invalide.");
                    return;
                }

                var emprunt = _db.Emprunts
                    .Include(e => e.Livre)
                    .FirstOrDefault(e => e.EmpruntId == id);

                if (emprunt == null)
                {
                    MessageBox.Show("Emprunt introuvable.");
                    return;
                }

                // Si emprunt pas retourné, on remet la quantité du livre avant suppression
                if (emprunt.DateRetour == null && emprunt.Livre != null)
                {
                    emprunt.Livre.Quantite += 1;
                }

                _db.Emprunts.Remove(emprunt);
                _db.SaveChanges();

                MessageBox.Show("Emprunt supprimé ✅");
                ChargerGrille();
                ChargerCombos();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression :\n\n" + ex.Message);
            }
        }

        // =========================
        // ACTUALISER
        // =========================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try
            {
                ChargerCombos();
                ChargerGrille();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur actualiser :\n\n" + ex.Message);
            }
        }

        // =========================
        // RECHERCHER par IdEmprunt
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdEmprunt.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdEmprunt valide.");
                    return;
                }

                var data = _db.Emprunts
                    .Include(e => e.Usager)
                    .Include(e => e.Livre)
                    .Where(e => e.EmpruntId == id)
                    .ToList();

                dgvEmprunt.DataSource = null;
                dgvEmprunt.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche :\n\n" + ex.Message);
            }
        }

        // =========================
        // CLICK GRILLE -> remplit
        // =========================
        private void dgvEmprunts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                if (dgvEmprunt.Rows[e.RowIndex].DataBoundItem is Emprunt emp)
                {
                    // Remplir les zones Id pour Retour/Supp
                    txtIdEmpruntRetour.Text = emp.EmpruntId.ToString();
                    txtIdEmpruntSupp.Text = emp.EmpruntId.ToString();

                    // Remplir les combos + dates
                    cmbUsager.SelectedValue = emp.UsagerId;
                    cmbLivre.SelectedValue = emp.LivreId;

                    dtpDateEmprunt.Value = emp.DateEmprunt;
                    dtpRetourPrevu.Value = emp.DateRetourPrevue;

                    // Si pas retourné -> on met aujourd'hui par défaut
                    dtpDateRetourReel.Value = emp.DateRetour ?? DateTime.Today;
                }
            }
            catch
            {
                // On évite de casser l'app juste pour un clic
            }
        }

        // =========================
        // VIDER
        // =========================
        private void ViderChamps()
        {
            txtIdEmpruntRetour.Clear();
            txtIdEmpruntSupp.Clear();
            txtListeIdEmprunt.Clear();

            dtpDateEmprunt.Value = DateTime.Today;
            dtpRetourPrevu.Value = DateTime.Today.AddDays(14);
            dtpDateRetourReel.Value = DateTime.Today;

            if (cmbUsager.Items.Count > 0) cmbUsager.SelectedIndex = 0;
            if (cmbLivre.Items.Count > 0) cmbLivre.SelectedIndex = 0;
        }

        // =========================
        // RETOUR FORM
        // =========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
