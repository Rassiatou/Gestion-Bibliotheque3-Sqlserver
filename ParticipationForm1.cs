using Microsoft.EntityFrameworkCore;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class ParticipationForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public ParticipationForm1()
        {
            InitializeComponent();
            this.Load += ParticipationForm1_Load;
        }

        // =========================
        // LOAD
        // =========================
        private void ParticipationForm1_Load(object? sender, EventArgs e)
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
        // COMBOS
        // =========================
        private void ChargerCombos()
        {
            // Usager
            cmbUsager.DisplayMember = "Nom";
            cmbUsager.ValueMember = "UsagerId";
            cmbUsager.DataSource = _db.Usagers
                .OrderBy(u => u.Nom)
                .ToList();

            // Activite
            cmbActivite.DisplayMember = "Titre";
            cmbActivite.ValueMember = "ActiviteId";
            cmbActivite.DataSource = _db.Activites
                .OrderBy(a => a.Titre)
                .ToList();
        }

        // =========================
        // GRILLE
        // =========================
        private void ChargerGrille()
        {
            dgvParticipation.DataSource = null;

            dgvParticipation.DataSource = _db.Participations
                .Include(p => p.Usager)
                .Include(p => p.Activite)
                .OrderByDescending(p => p.DateInscription)
                .ToList();

            dgvParticipation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipation.ReadOnly = true;
            dgvParticipation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipation.MultiSelect = false;
        }

        // =========================
        // INSCRIRE (AJOUTER)
        // =========================
        private void btnInscrire_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderAjout()) return;

                int usagerId = (int)cmbUsager.SelectedValue;
                int activiteId = (int)cmbActivite.SelectedValue;
                DateTime date = dtpDateInscription.Value.Date;

                // 1) Empêcher double inscription (même usager + même activité)
                bool deja = _db.Participations.Any(p => p.UsagerId == usagerId && p.ActiviteId == activiteId);
                if (deja)
                {
                    MessageBox.Show("Cet usager est déjà inscrit à cette activité.");
                    return;
                }

                // 2) Vérifier la capacité max si tu as CapaciteMax dans Activite
                var activite = _db.Activites.FirstOrDefault(a => a.ActiviteId == activiteId);
                if (activite == null)
                {
                    MessageBox.Show("Activité introuvable.");
                    return;
                }

                // Si ton entity Activite a CapaciteMax :
                int nbInscrits = _db.Participations.Count(p => p.ActiviteId == activiteId);
                if (activite.CapaciteMax > 0 && nbInscrits >= activite.CapaciteMax)
                {
                    MessageBox.Show("Capacité maximale atteinte pour cette activité.");
                    return;
                }

                // 3) Créer participation
                var participation = new Participation
                {
                    UsagerId = usagerId,
                    ActiviteId = activiteId,
                    DateInscription = date,
                    Presence = chkPresence.Checked
                };

                _db.Participations.Add(participation);
                _db.SaveChanges();

                MessageBox.Show("Inscription réussie ✅");

                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Inscrire) :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (Inscrire) :\n\n" + ex.Message);
            }
        }

        private bool ValiderAjout()
        {
            if (cmbUsager.SelectedValue == null || cmbActivite.SelectedValue == null)
            {
                MessageBox.Show("Choisis un usager et une activité.");
                return false;
            }
            return true;
        }

        // =========================
        // RETIRER (SUPPRIMER)
        // =========================
        private void btnRetourner_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdParticipationRetirer.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdParticipation invalide.");
                    return;
                }

                var participation = _db.Participations.FirstOrDefault(p => p.ParticipationId == id);
                if (participation == null)
                {
                    MessageBox.Show("Participation introuvable.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Retirer cet usager de l'activité ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes) return;

                _db.Participations.Remove(participation);
                _db.SaveChanges();

                MessageBox.Show("Participation retirée ✅");

                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Retirer) :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (Retirer) :\n\n" + ex.Message);
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
        // RECHERCHER par IdParticipation
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdParticipation.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdParticipation valide.");
                    return;
                }

                var data = _db.Participations
                    .Include(p => p.Usager)
                    .Include(p => p.Activite)
                    .Where(p => p.ParticipationId == id)
                    .ToList();

                dgvParticipation.DataSource = null;
                dgvParticipation.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche :\n\n" + ex.Message);
            }
        }

        // =========================
        // CLIQUE GRILLE -> remplir champs
        // =========================
        private void dgvParticipation_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                if (dgvParticipation.Rows[e.RowIndex].DataBoundItem is Participation p)
                {
                    // Retirer
                    txtIdParticipationRetirer.Text = p.ParticipationId.ToString();

                    // Reprendre dans le formulaire (facultatif)
                    cmbUsager.SelectedValue = p.UsagerId;
                    cmbActivite.SelectedValue = p.ActiviteId;
                    dtpDateInscription.Value = p.DateInscription;
                    chkPresence.Checked = p.Presence;
                }
            }
            catch
            {
                // éviter crash sur un clic
            }
        }

        // =========================
        // RETOUR
        // =========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================
        // UTIL
        // =========================
        private void ViderChamps()
        {
            txtListeIdParticipation.Clear();
            txtIdParticipationRetirer.Clear();

            dtpDateInscription.Value = DateTime.Today;
            chkPresence.Checked = false;

            if (cmbUsager.Items.Count > 0) cmbUsager.SelectedIndex = 0;
            if (cmbActivite.Items.Count > 0) cmbActivite.SelectedIndex = 0;
        }
    }
}
