using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
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
            this.Load += EmpruntMaterielForm1_Load;

            // IMPORTANT : si pas branché dans le designer
            dgvEmpruntMateriel.CellClick -= dgvEmpruntMateriel_CellClick;
            dgvEmpruntMateriel.CellClick += dgvEmpruntMateriel_CellClick;
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
            // ✅ Combo Usager -> afficher Nom + Prenom
            var usagers = _db.Usagers
                .Select(u => new
                {
                    u.UsagerId,
                    NomComplet = (u.Nom + " " + u.Prenom)
                })
                .OrderBy(x => x.NomComplet)
                .ToList();

            cmbUsager.DisplayMember = "NomComplet";
            cmbUsager.ValueMember = "UsagerId";
            cmbUsager.DataSource = usagers;

            // ✅ Combo Materiel -> afficher Nom
            var mats = _db.Materiels
                .Select(m => new
                {
                    m.MaterielId,
                    m.Nom
                })
                .OrderBy(m => m.Nom)
                .ToList();

            cmbMateriel.DisplayMember = "Nom";
            cmbMateriel.ValueMember = "MaterielId";
            cmbMateriel.DataSource = mats;

            // ✅ Combo Etat (liste fixe)
            if (cmbEtat.Items.Count == 0)
            {
                cmbEtat.Items.Add("En bon état");
                cmbEtat.Items.Add("Abîmé");
                cmbEtat.Items.Add("Brisé");
            }
            cmbEtat.SelectedIndex = 0;
        }

        // =========================
        // CHARGER GRILLE (AVEC NOMS)
        // =========================
        private void ChargerGrille()
        {
            try
            {
                dgvEmpruntMateriel.DataSource = null;

                var data = _db.EmpruntsMateriel
                    .Include(e => e.Usager)
                    .Include(e => e.Materiel)
                    .OrderByDescending(e => e.DateEmprunt)
                    .Select(e => new
                    {
                        e.EmpruntMaterielId,
                        e.MaterielId,
                        Materiel = e.Materiel != null ? e.Materiel.Nom : "",
                        e.UsagerId,
                        Usager = e.Usager != null ? (e.Usager.Nom + " " + e.Usager.Prenom) : "",
                        DateEmprunt = e.DateEmprunt,
                        DateRetourPrevue = e.DateRetourPrevue,
                        DateRetour = e.DateRetour,
                        e.Etat
                    })
                    .ToList();

                dgvEmpruntMateriel.DataSource = data;
                dgvEmpruntMateriel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmpruntMateriel.ReadOnly = true;
                dgvEmpruntMateriel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvEmpruntMateriel.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement grille :\n\n" + ex.Message);
            }
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

                var mat = _db.Materiels.FirstOrDefault(m => m.MaterielId == materielId);
                if (mat == null)
                {
                    MessageBox.Show("Matériel introuvable.");
                    return;
                }

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

                mat.Quantite -= 1;

                _db.EmpruntsMateriel.Add(emprunt);
                _db.SaveChanges();

                MessageBox.Show("Prêt matériel ajouté");
                ChargerGrille();
                ChargerCombos();
                ViderChamps();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur BD :\n\n" + (dbEx.InnerException?.Message ?? dbEx.Message));
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
                emprunt.Etat = cmbEtat.Text;

                if (emprunt.Materiel != null)
                    emprunt.Materiel.Quantite += 1;

                _db.SaveChanges();

                MessageBox.Show("Matériel retourné");
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

                if (emprunt.DateRetour == null && emprunt.Materiel != null)
                    emprunt.Materiel.Quantite += 1;

                _db.EmpruntsMateriel.Remove(emprunt);
                _db.SaveChanges();

                MessageBox.Show("EmpruntMatériel supprimé");
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
        // RECHERCHER par IdEmpruntMateriel (avec messages)
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string saisie = txtListeIdEmpruntMateriel.Text.Trim();

                if (string.IsNullOrWhiteSpace(saisie))
                {
                    MessageBox.Show("Entre un IdEmpruntMateriel.");
                    return;
                }

                if (!int.TryParse(saisie, out int id))
                {
                    MessageBox.Show("IdEmpruntMateriel invalide (nombre uniquement).");
                    return;
                }

                var data = _db.EmpruntsMateriel
                    .Include(e => e.Usager)
                    .Include(e => e.Materiel)
                    .Where(e => e.EmpruntMaterielId == id)
                    .Select(e => new
                    {
                        e.EmpruntMaterielId,
                        e.MaterielId,
                        Materiel = e.Materiel != null ? e.Materiel.Nom : "",
                        e.UsagerId,
                        Usager = e.Usager != null ? (e.Usager.Nom + " " + e.Usager.Prenom) : "",
                        DateEmprunt = e.DateEmprunt,
                        DateRetourPrevue = e.DateRetourPrevue,
                        DateRetour = e.DateRetour,
                        e.Etat
                    })
                    .ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Aucun emprunt matériel trouvé avec cet Id.");
                    return;
                }

                dgvEmpruntMateriel.DataSource = null;
                dgvEmpruntMateriel.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur recherche :\n\n" + ex.Message);
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
        // CLIQUE GRILLE -> remplir champs
        // =========================
        private void dgvEmpruntMateriel_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvEmpruntMateriel.Rows[e.RowIndex];
                if (row == null) return;

                // Id pour Retour/Supp
                txtIdEmpruntMaterielRetour.Text = row.Cells["EmpruntMaterielId"].Value?.ToString();
                txtIdEmpruntMaterielSupp.Text = row.Cells["EmpruntMaterielId"].Value?.ToString();

                // Combos
                if (row.Cells["UsagerId"].Value != null)
                    cmbUsager.SelectedValue = Convert.ToInt32(row.Cells["UsagerId"].Value);

                if (row.Cells["MaterielId"].Value != null)
                    cmbMateriel.SelectedValue = Convert.ToInt32(row.Cells["MaterielId"].Value);

                // Dates
                if (row.Cells["DateEmprunt"].Value != null)
                    dtpDatePret.Value = Convert.ToDateTime(row.Cells["DateEmprunt"].Value);

                if (row.Cells["DateRetourPrevue"].Value != null)
                    dtpRetourPrevu.Value = Convert.ToDateTime(row.Cells["DateRetourPrevue"].Value);

                if (row.Cells["DateRetour"].Value != null && row.Cells["DateRetour"].Value != DBNull.Value)
                    dtpRetourReel.Value = Convert.ToDateTime(row.Cells["DateRetour"].Value);
                else
                    dtpRetourReel.Value = DateTime.Today;

                // Etat
                var etat = row.Cells["Etat"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(etat))
                    cmbEtat.Text = etat;
            }
            catch
            {
                // éviter crash sur clic
            }
        }

        // =========================
        // VIDER
        // =========================
        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

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
        // RETOUR
        // =========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
