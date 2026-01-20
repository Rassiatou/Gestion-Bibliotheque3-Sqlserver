using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
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

            // Important : si pas branché dans Designer
            dgvEvaluation.CellClick -= dgvEvaluation_CellClick;
            dgvEvaluation.CellClick += dgvEvaluation_CellClick;
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
        // CHARGER COMBOS (Usager + Livre)  Nom complet / Titre
        // =========================
        private void ChargerCombos()
        {
            // --- Combo Usager : Nom + Prenom ---
            var usagers = _db.Usagers
                .Select(u => new
                {
                    u.UsagerId,
                    NomComplet = (u.Nom + " " + u.Prenom).Trim()
                })
                .OrderBy(x => x.NomComplet)
                .ToList();

            cmbUsager.DisplayMember = "NomComplet";
            cmbUsager.ValueMember = "UsagerId";
            cmbUsager.DataSource = usagers;

            // --- Combo Livre : Titre ---
            var livres = _db.Livres
                .Select(l => new
                {
                    l.LivreId,
                    l.Titre
                })
                .OrderBy(x => x.Titre)
                .ToList();

            cmbLivre.DisplayMember = "Titre";
            cmbLivre.ValueMember = "LivreId";
            cmbLivre.DataSource = livres;

            if (cmbUsager.Items.Count > 0) cmbUsager.SelectedIndex = 0;
            if (cmbLivre.Items.Count > 0) cmbLivre.SelectedIndex = 0;
        }

        // =========================
        // CHARGER GRILLE Affiche Nom usager + Titre livre
        // =========================
        private void ChargerGrille()
        {
            try
            {
                dgvEvaluation.DataSource = null;

                var data = _db.Evaluations
                    .Include(e => e.Usager)
                    .Include(e => e.Livre)
                    .OrderByDescending(e => e.DateEvaluation)
                    .Select(e => new
                    {
                        e.EvaluationId,
                        e.LivreId,
                        Livre = e.Livre != null ? e.Livre.Titre : "",
                        e.UsagerId,
                        Usager = e.Usager != null ? (e.Usager.Nom + " " + e.Usager.Prenom).Trim() : "",
                        e.Note,
                        e.Commentaire,
                        e.DateEvaluation
                    })
                    .ToList();

                dgvEvaluation.DataSource = data;
                dgvEvaluation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEvaluation.ReadOnly = true;
                dgvEvaluation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvEvaluation.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (chargement grille) :\n\n" + ex.Message);
            }
        }

        // =========================
        // AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
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

                _db.Evaluations.Add(eval);
                _db.SaveChanges();

                MessageBox.Show("Évaluation ajoutée");
                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Ajout) :\n\n" + (dbEx.InnerException?.Message ?? dbEx.Message));
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
                if (!int.TryParse(txtIdEvaluation.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEvaluation invalide (modification).");
                    return;
                }

                var eval = _db.Evaluations.FirstOrDefault(e => e.EvaluationId == id);
                if (eval == null)
                {
                    MessageBox.Show("Évaluation introuvable.");
                    return;
                }

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

                eval.Note = (int)nudNoteModif.Value;
                eval.Commentaire = txtCommentaireModif.Text.Trim();

                _db.SaveChanges();

                MessageBox.Show("Évaluation modifiée");
                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Modification) :\n\n" + (dbEx.InnerException?.Message ?? dbEx.Message));
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

                MessageBox.Show("Évaluation supprimée");
                ChargerGrille();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD (Suppression) :\n\n" + (dbEx.InnerException?.Message ?? dbEx.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (Suppression) :\n\n" + ex.Message);
            }
        }

        // =========================
        // VIDER
        // =========================
        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void ViderChamps()
        {
            txtCommentaire.Clear();
            nudNote.Value = 0;
            dtpDateEvaluation.Value = DateTime.Today;

            txtIdEvaluation.Clear();
            txtCommentaireModif.Clear();
            nudNoteModif.Value = 0;

            txtIdEvaluationSupp.Clear();

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
        // (Comme la grille affiche une projection, on lit les Cells)
        // =========================
        private void dgvEvaluation_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvEvaluation.Rows[e.RowIndex];
                if (row == null) return;

                // Colonnes de ChargerGrille()
                txtIdEvaluation.Text = row.Cells["EvaluationId"].Value?.ToString();
                txtIdEvaluationSupp.Text = row.Cells["EvaluationId"].Value?.ToString();

                int note = 0;
                int.TryParse(row.Cells["Note"].Value?.ToString(), out note);
                nudNoteModif.Value = note;

                txtCommentaireModif.Text = row.Cells["Commentaire"].Value?.ToString() ?? "";

                // Remplir zone ajout (facultatif)
                if (row.Cells["UsagerId"].Value != null)
                    cmbUsager.SelectedValue = Convert.ToInt32(row.Cells["UsagerId"].Value);

                if (row.Cells["LivreId"].Value != null)
                    cmbLivre.SelectedValue = Convert.ToInt32(row.Cells["LivreId"].Value);

                nudNote.Value = note;
                txtCommentaire.Text = txtCommentaireModif.Text;

                if (DateTime.TryParse(row.Cells["DateEvaluation"].Value?.ToString(), out var d))
                    dtpDateEvaluation.Value = d;
            }
            catch
            {
              
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
