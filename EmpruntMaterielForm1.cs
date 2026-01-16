using Microsoft.EntityFrameworkCore;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class EmpruntMaterielForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public EmpruntMaterielForm1()
        {
            InitializeComponent();
           // Au chargement du form
            this.Load += EmpruntMaterielForm1_Load;
        }

        private void EmpruntMaterielForm1_Load(object? sender, EventArgs e)
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
        // CHARGER COMBOS
        // =========================
        private void ChargerCombos()
        {
            // Combo Usager
            cmbUsager.DisplayMember = "Nom";
            cmbUsager.ValueMember = "UsagerId";
            cmbUsager.DataSource = _db.Usagers
                .OrderBy(u => u.Nom)
                .ToList();

            // Combo Materiel
            cmbMateriel.DisplayMember = "Nom";       // adapte si ton champ = Libelle / Designation
            cmbMateriel.ValueMember = "MaterielId";
            cmbMateriel.DataSource = _db.Materiels
                .OrderBy(m => m.Nom)
                .ToList();

            // Combo Etat (si tu as déjà une liste fixe)
            // Exemple : Disponible, EnPret, Brisé, Perdu... adapte selon ton cours
            cmbEtat.Items.Clear();
            cmbEtat.Items.Add("En bon état");
            cmbEtat.Items.Add("Abîmé");
            cmbEtat.Items.Add("Brisé");
            cmbEtat.SelectedIndex = 0;
        }

        // =========================
        // CHARGER GRILLE
        // =========================
        private void ChargerGrille()
        {
            dgvEmpruntMateriel.DataSource = null;

            dgvEmpruntMateriel.DataSource = _db.EmpruntsMateriel
                .Include(e => e.Usager)
                .Include(e => e.Materiel)
                .OrderByDescending(e => e.DateEmprunt)
                .ToList();

            dgvEmpruntMateriel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpruntMateriel.ReadOnly = true;
            dgvEmpruntMateriel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpruntMateriel.MultiSelect = false;
        }

        // =========================
        // PRETER
        // =========================
        private void btnPreter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsager.SelectedValue == null || cmbMateriel.SelectedValue == null)
                {
                    MessageBox.Show("Choisis un usager et un matériel.");
                    return;
                }

                int usagerId = (int)cmbUsager.SelectedValue;
                int materielId = (int)cmbMateriel.SelectedValue;

                DateTime dateEmprunt = dtpDatePret.Value.Date;
                DateTime dateRetourPrevu = dtpRetourPrevu.Value.Date;

                if (dateRetourPrevu < dateEmprunt)
                {
                    MessageBox.Show("La date de retour prévue doit être >= date d'emprunt.");
                    return;
                }

                // Vérifier disponibilité (si tu as Quantite)
                var mat = _db.Materiels.FirstOrDefault(m => m.MaterielId == materielId);
                if (mat == null)
                {
                    MessageBox.Show("Matériel introuvable.");
                    return;
                }

                // Si tu as une Quantite : empêcher prêt si 0
                if (mat.Quantite <= 0)
                {
                    MessageBox.Show("Impossible : matériel non disponible (quantité = 0).");
                    return;
                }

                var emprunt = new EmpruntMateriel
                {
                    UsagerId = usagerId,
                    MaterielId = materielId,
                    DateEmprunt = dateEmprunt,
                    DateRetourPrevue = dateRetourPrevu,
                    DateRetour = null,
                    Etat = cmbEtat.Text
                };

                // Enlève 1 de la quantité
                mat.Quantite -= 1;

                _db.EmpruntsMateriel.Add(emprunt);
                _db.SaveChanges();

                MessageBox.Show("Prêt matériel ajouté ✅");
                ChargerGrille();
                ChargerCombos();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur prêt :\n\n" + ex.Message);
            }
        }

        // =========================
        // RETOURNER
        // =========================
        private void btnRetourner_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEmpruntMaterielRetour.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEmpruntMateriel invalide.");
                    return;
                }

                var emprunt = _db.EmpruntsMateriel
                    .Include(e => e.Materiel)
                    .FirstOrDefault(e => e.EmpruntMaterielId == id);

                if (emprunt == null)
                {
                    MessageBox.Show("EmpruntMatériel introuvable.");
                    return;
                }

                if (emprunt.DateRetour != null)
                {
                    MessageBox.Show("Cet emprunt est déjà retourné.");
                    return;
                }

                emprunt.DateRetour = dtpRetourReel.Value.Date;
                emprunt.Etat = cmbEtat.Text; // état au retour

                // Remettre le matériel dispo (Quantite++)
                if (emprunt.Materiel != null)
                    emprunt.Materiel.Quantite += 1;

                _db.SaveChanges();

                MessageBox.Show("Matériel retourné ✅");
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
        // SUPPRIMER (AUTORISÉ même si emprunt en cours)
        // =========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEmpruntMaterielSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEmpruntMateriel invalide.");
                    return;
                }

                var emprunt = _db.EmpruntsMateriel
                    .Include(e => e.Materiel)
                    .FirstOrDefault(e => e.EmpruntMaterielId == id);

                if (emprunt == null)
                {
                    MessageBox.Show("EmpruntMatériel introuvable.");
                    return;
                }

                // Si l'emprunt n'était pas retourné, on remet la quantité avant suppression
                if (emprunt.DateRetour == null && emprunt.Materiel != null)
                {
                    emprunt.Materiel.Quantite += 1;
                }

                _db.EmpruntsMateriel.Remove(emprunt);
                _db.SaveChanges();

                MessageBox.Show("EmpruntMatériel supprimé ✅");
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
        // VIDER
        // =========================
        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void ViderChamps()
        {
            txtIdEmpruntMaterielRetour.Clear();
            txtIdEmpruntMaterielSupp.Clear();
            txtListeIdEmpruntMateriel.Clear();

            dtpDatePret.Value = DateTime.Today;
            dtpRetourPrevu.Value = DateTime.Today.AddDays(14);
            dtpRetourReel.Value = DateTime.Today;

            if (cmbUsager.Items.Count > 0) cmbUsager.SelectedIndex = 0;
            if (cmbMateriel.Items.Count > 0) cmbMateriel.SelectedIndex = 0;
            if (cmbEtat.Items.Count > 0) cmbEtat.SelectedIndex = 0;
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
        // RECHERCHER par IdEmpruntMateriel
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdEmpruntMateriel.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdEmpruntMateriel valide.");
                    return;
                }

                var data = _db.EmpruntsMateriel
                    .Include(e => e.Usager)
                    .Include(e => e.Materiel)
                    .Where(e => e.EmpruntMaterielId == id)
                    .ToList();

                dgvEmpruntMateriel.DataSource = null;
                dgvEmpruntMateriel.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche :\n\n" + ex.Message);
            }
        }

        // =========================
        // CLIQUE GRILLE -> remplir champs
        // =========================
        private void dgvEmpruntMateriel_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                if (dgvEmpruntMateriel.Rows[e.RowIndex].DataBoundItem is EmpruntMateriel emp)
                {
                    txtIdEmpruntMaterielRetour.Text = emp.EmpruntMaterielId.ToString();
                    txtIdEmpruntMaterielSupp.Text = emp.EmpruntMaterielId.ToString();

                    cmbUsager.SelectedValue = emp.UsagerId;
                    cmbMateriel.SelectedValue = emp.MaterielId;

                    dtpDatePret.Value = emp.DateEmprunt;
                    dtpRetourPrevu.Value = emp.DateRetourPrevue;
                    dtpRetourReel.Value = emp.DateRetour ?? DateTime.Today;

                    // Etat
                    if (!string.IsNullOrWhiteSpace(emp.Etat))
                        cmbEtat.Text = emp.Etat;
                }
            }
            catch
            {
                // rien : on évite crash sur un clic
            }
        }

        // =========================
        // RETOUR MENU
        // =========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
