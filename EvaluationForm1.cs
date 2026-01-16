using Microsoft.EntityFrameworkCore;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class EvaluationForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public EvaluationForm1()
        {
            InitializeComponent();
            this.Load += EvaluationForm1_Load;
        }


        // =========================
        // LOAD FORM
        // =========================
        private void EvaluationForm1_Load(object? sender, EventArgs e)
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
        // CHARGER COMBOS (Usager + Livre)
        // =========================
        private void ChargerCombos()
        {
            // --- Combo Usager ---
            cmbUsager.DisplayMember = "Nom";
            cmbUsager.ValueMember = "UsagerId";
            cmbUsager.DataSource = _db.Usagers
                .OrderBy(u => u.Nom)
                .ToList();

            // --- Combo Livre ---
            cmbLivre.DisplayMember = "Titre";
            cmbLivre.ValueMember = "LivreId";
            cmbLivre.DataSource = _db.Livres
                .OrderBy(l => l.Titre)
                .ToList();
        }

        // =========================
        // CHARGER GRILLE
        // =========================
        private void ChargerGrille()
        {
            dgvEvaluation.DataSource = null;

            dgvEvaluation.DataSource = _db.Evaluations
                .Include(e => e.Usager)
                .Include(e => e.Livre)
                .OrderByDescending(e => e.DateEvaluation)
                .ToList();

            dgvEvaluation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvaluation.ReadOnly = true;
            dgvEvaluation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluation.MultiSelect = false;
        }

        // =========================
        // AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Valider champs
                if (!ValiderAjout()) return;

                int usagerId = (int)cmbUsager.SelectedValue;
                int livreId = (int)cmbLivre.SelectedValue;

                var eval = new Evaluation
                {
                    UsagerId = usagerId,
                    LivreId = livreId,
                    Note = (int)nudNote.Value,
                    Commentaire = txtCommentaire.Text.Trim(),
                    DateEvaluation = dtpDateEvaluation.Value.Date
                };

                // 2) Save
                _db.Evaluations.Add(eval);
                _db.SaveChanges();

                MessageBox.Show("Évaluation ajoutée ✅");

                // 3) Refresh
                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Ajout) :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (Ajout) :\n\n" + ex.Message);
            }
        }

        private bool ValiderAjout()
        {
            if (cmbUsager.SelectedValue == null || cmbLivre.SelectedValue == null)
            {
                MessageBox.Show("Choisis un usager et un livre.");
                return false;
            }

            if (nudNote.Value < 0 || nudNote.Value > 10)
            {
                MessageBox.Show("La note doit être entre 0 et 10.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCommentaire.Text))
            {
                MessageBox.Show("Le commentaire est obligatoire.");
                return false;
            }

            return true;
        }

        // =========================
        // MODIFIER
        // =========================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Valider Id
                if (!int.TryParse(txtIdEvaluation.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEvaluation invalide (modification).");
                    return;
                }

                // 2) Charger l'évaluation
                var eval = _db.Evaluations.FirstOrDefault(e => e.EvaluationId == id);
                if (eval == null)
                {
                    MessageBox.Show("Évaluation introuvable.");
                    return;
                }

                // 3) Valider les champs modif
                if (nudNoteModif.Value < 0 || nudNoteModif.Value > 10)
                {
                    MessageBox.Show("La note (modif) doit être entre 0 et 10.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCommentaireModif.Text))
                {
                    MessageBox.Show("Le commentaire (modif) est obligatoire.");
                    return;
                }

                // 4) Appliquer modifs
                eval.Note = (int)nudNoteModif.Value;
                eval.Commentaire = txtCommentaireModif.Text.Trim();

                // (Option) si tu veux permettre de modifier la date aussi :
                // eval.DateEvaluation = dtpDateEvaluation.Value.Date;

                _db.SaveChanges();

                MessageBox.Show("Évaluation modifiée ✅");

                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Modification) :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (Modification) :\n\n" + ex.Message);
            }
        }

        // =========================
        // SUPPRIMER
        // =========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEvaluationSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEvaluation invalide (suppression).");
                    return;
                }

                var eval = _db.Evaluations.FirstOrDefault(e => e.EvaluationId == id);
                if (eval == null)
                {
                    MessageBox.Show("Évaluation introuvable.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Voulez-vous supprimer cette évaluation ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes) return;

                _db.Evaluations.Remove(eval);
                _db.SaveChanges();

                MessageBox.Show("Évaluation supprimée ✅");

                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Suppression) :\n\n" + dbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (Suppression) :\n\n" + ex.Message);
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
            // Champs ajout
            txtCommentaire.Clear();
            nudNote.Value = 0;
            dtpDateEvaluation.Value = DateTime.Today;

            // Champs modif
            txtIdEvaluation.Clear();
            txtCommentaireModif.Clear();
            nudNoteModif.Value = 0;

            // Champs supp
            txtIdEvaluationSupp.Clear();

            // Remettre combos au début
            if (cmbUsager.Items.Count > 0) cmbUsager.SelectedIndex = 0;
            if (cmbLivre.Items.Count > 0) cmbLivre.SelectedIndex = 0;
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
        // CLIQUE SUR GRILLE -> Remplir champs Modif/Supp
        // =========================
        private void dgvEvaluation_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                if (dgvEvaluation.Rows[e.RowIndex].DataBoundItem is Evaluation eval)
                {
                    // Remplir champs modif
                    txtIdEvaluation.Text = eval.EvaluationId.ToString();
                    nudNoteModif.Value = eval.Note;
                    txtCommentaireModif.Text = eval.Commentaire;

                    // Remplir champs supp
                    txtIdEvaluationSupp.Text = eval.EvaluationId.ToString();

                    // Remplir zone ajout (facultatif)
                    cmbUsager.SelectedValue = eval.UsagerId;
                    cmbLivre.SelectedValue = eval.LivreId;
                    nudNote.Value = eval.Note;
                    txtCommentaire.Text = eval.Commentaire;
                    dtpDateEvaluation.Value = eval.DateEvaluation;
                }
            }
            catch
            {
                // Eviter crash sur un clic
            }
        }

        // =========================
        // RETOUR
        // =========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
