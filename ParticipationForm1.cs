using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
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

            // important: si pas branché dans designer
            dgvParticipation.CellClick -= dgvParticipation_CellClick;
            dgvParticipation.CellClick += dgvParticipation_CellClick;
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
        // COMBOS (afficher des noms lisibles)
        // =========================
        private void ChargerCombos()
        {
            // --- Usager : Nom + Prenom ---
            var usagers = _db.Usagers
                .OrderBy(u => u.Nom)
                .ThenBy(u => u.Prenom)
                .Select(u => new
                {
                    u.UsagerId,
                    NomComplet = (u.Nom + " " + u.Prenom).Trim()
                })
                .ToList();

            cmbUsager.DataSource = usagers;
            cmbUsager.DisplayMember = "NomComplet";
            cmbUsager.ValueMember = "UsagerId";

            // --- Activite : Titre ---
            var activites = _db.Activites
                .OrderBy(a => a.Titre)
                .Select(a => new
                {
                    a.ActiviteId,
                    a.Titre
                })
                .ToList();

            cmbActivite.DataSource = activites;
            cmbActivite.DisplayMember = "Titre";
            cmbActivite.ValueMember = "ActiviteId";
        }

        // =========================
        // GRILLE (afficher des textes)
        // =========================
        private void ChargerGrille()
        {
            dgvParticipation.DataSource = null;

            var data = _db.Participations
                .Include(p => p.Usager)
                .Include(p => p.Activite)
                .OrderByDescending(p => p.DateInscription)
                .Select(p => new
                {
                    p.ParticipationId,
                    p.ActiviteId,
                    Activite = p.Activite != null ? p.Activite.Titre : "",
                    p.UsagerId,
                    Usager = p.Usager != null ? (p.Usager.Nom + " " + p.Usager.Prenom).Trim() : "",
                    p.Presence,
                    p.DateInscription
                })
                .ToList();

            dgvParticipation.DataSource = data;
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

                int usagerId = Convert.ToInt32(cmbUsager.SelectedValue);
                int activiteId = Convert.ToInt32(cmbActivite.SelectedValue);
                DateTime date = dtpDateInscription.Value.Date;

                // Empêcher double inscription
                bool deja = _db.Participations.Any(p => p.UsagerId == usagerId && p.ActiviteId == activiteId);
                if (deja)
                {
                    MessageBox.Show("Cet usager est déjà inscrit à cette activité.");
                    return;
                }

                var activite = _db.Activites.FirstOrDefault(a => a.ActiviteId == activiteId);
                if (activite == null)
                {
                    MessageBox.Show("Activité introuvable.");
                    return;
                }

                int nbInscrits = _db.Participations.Count(p => p.ActiviteId == activiteId);
                if (activite.CapaciteMax > 0 && nbInscrits >= activite.CapaciteMax)
                {
                    MessageBox.Show("Capacité maximale atteinte pour cette activité.");
                    return;
                }

                var participation = new Participation
                {
                    UsagerId = usagerId,
                    ActiviteId = activiteId,
                    DateInscription = date,
                    Presence = chkPresence.Checked
                };

                _db.Participations.Add(participation);
                _db.SaveChanges();

                MessageBox.Show("Inscription réussie");
                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Inscrire) :\n\n" + (dbEx.InnerException?.Message ?? dbEx.Message));
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
                if (!int.TryParse(txtIdParticipationRetirer.Text.Trim(), out int id) || id <= 0)
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

                MessageBox.Show("Participation retirée");
                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Retirer) :\n\n" + (dbEx.InnerException?.Message ?? dbEx.Message));
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
        // RECHERCHER par IdParticipation (avec erreurs)
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = txtListeIdParticipation.Text.Trim();

                if (string.IsNullOrWhiteSpace(txt))
                {
                    MessageBox.Show("Entre un IdParticipation.");
                    return;
                }

                if (!int.TryParse(txt, out int id) || id <= 0)
                {
                    MessageBox.Show("IdParticipation invalide (nombre positif).");
                    return;
                }

                var data = _db.Participations
                    .Include(p => p.Usager)
                    .Include(p => p.Activite)
                    .Where(p => p.ParticipationId == id)
                    .Select(p => new
                    {
                        p.ParticipationId,
                        p.ActiviteId,
                        Activite = p.Activite != null ? p.Activite.Titre : "",
                        p.UsagerId,
                        Usager = p.Usager != null ? (p.Usager.Nom + " " + p.Usager.Prenom).Trim() : "",
                        p.Presence,
                        p.DateInscription
                    })
                    .ToList();

                dgvParticipation.DataSource = null;
                dgvParticipation.DataSource = data;

                if (data.Count == 0)
                    MessageBox.Show("Aucune participation trouvée avec cet Id.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche :\n\n" + ex.Message);
            }
        }

        // =========================
        // CLIQUE GRILLE -> remplir champs (IMPORTANT: lecture par colonnes)
        // =========================
        private void dgvParticipation_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvParticipation.Rows[e.RowIndex];
                if (row == null) return;

                // Comme la grille = Select(new { ... }) => on lit par noms de colonnes
                txtIdParticipationRetirer.Text = row.Cells["ParticipationId"].Value?.ToString() ?? "";

                if (row.Cells["UsagerId"].Value != null)
                    cmbUsager.SelectedValue = Convert.ToInt32(row.Cells["UsagerId"].Value);

                if (row.Cells["ActiviteId"].Value != null)
                    cmbActivite.SelectedValue = Convert.ToInt32(row.Cells["ActiviteId"].Value);

                if (row.Cells["DateInscription"].Value != null)
                    dtpDateInscription.Value = Convert.ToDateTime(row.Cells["DateInscription"].Value);

                var presenceVal = row.Cells["Presence"].Value;
                chkPresence.Checked = presenceVal != null && presenceVal != DBNull.Value && Convert.ToBoolean(presenceVal);
            }
            catch
            {
                // éviter crash sur clic
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
