using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
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

                // Important : si pas branché dans Designer
                dgvEmprunt.CellClick -= dgvEmprunt_CellClick;
                dgvEmprunt.CellClick += dgvEmprunt_CellClick;
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
            // ✅ Usager : afficher Nom + Prenom
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

            // ✅ Livre : afficher Titre
            var livres = _db.Livres
                .OrderBy(l => l.Titre)
                .Select(l => new
                {
                    l.LivreId,
                    l.Titre
                })
                .ToList();

            cmbLivre.DataSource = livres;
            cmbLivre.DisplayMember = "Titre";
            cmbLivre.ValueMember = "LivreId";
        }

        // =========================
        // CHARGER GRILLE (avec noms lisibles)
        // =========================
        private void ChargerGrille()
        {
            dgvEmprunt.DataSource = null;

            var data = _db.Emprunts
                .Include(e => e.Usager)
                .Include(e => e.Livre)
                .OrderByDescending(e => e.DateEmprunt)
                .Select(e => new
                {
                    e.EmpruntId,
                    e.LivreId,
                    Livre = e.Livre != null ? e.Livre.Titre : "",
                    e.UsagerId,
                    Usager = e.Usager != null ? (e.Usager.Nom + " " + e.Usager.Prenom).Trim() : "",
                    e.DateEmprunt,
                    e.DateRetourPrevue,
                    DateRetour = e.DateRetour,
                    Etat = e.DateRetour == null ? "EnCours" : "Retourné"
                })
                .ToList();

            dgvEmprunt.DataSource = data;
            dgvEmprunt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmprunt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmprunt.ReadOnly = true;
            dgvEmprunt.MultiSelect = false;
        }

        // =========================
        // AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsager.SelectedValue == null || cmbLivre.SelectedValue == null)
                {
                    MessageBox.Show("Choisis un usager et un livre.");
                    return;
                }

                int usagerId = Convert.ToInt32(cmbUsager.SelectedValue);
                int livreId = Convert.ToInt32(cmbLivre.SelectedValue);

                DateTime dateEmprunt = dtpDateEmprunt.Value.Date;
                DateTime dateRetourPrevue = dtpRetourPrevu.Value.Date;

                if (dateRetourPrevue < dateEmprunt)
                {
                    MessageBox.Show("La date de retour prévue doit être >= date d'emprunt.");
                    return;
                }

                // Vérifier disponibilité du livre
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

                var emprunt = new Emprunt
                {
                    UsagerId = usagerId,
                    LivreId = livreId,
                    DateEmprunt = dateEmprunt,
                    DateRetourPrevue = dateRetourPrevue,
                    DateRetour = null
                };

                // Diminuer quantité
                livre.Quantite -= 1;

                _db.Emprunts.Add(emprunt);
                _db.SaveChanges();

                MessageBox.Show("Emprunt ajouté");
                ChargerGrille();
                ChargerCombos();
                ViderChamps();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (ajout) : " + (ex.InnerException?.Message ?? ex.Message));
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

                DateTime dateRetourReel = dtpDateRetourReel.Value.Date;

                if (dateRetourReel < emprunt.DateEmprunt.Date)
                {
                    MessageBox.Show("La date de retour ne peut pas être avant la date d'emprunt.");
                    return;
                }

                emprunt.DateRetour = dateRetourReel;

                if (emprunt.Livre != null)
                    emprunt.Livre.Quantite += 1;

                _db.SaveChanges();

                MessageBox.Show("Livre retourné");
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

                // Si pas retourné, on remet la quantité avant suppression
                if (emprunt.DateRetour == null && emprunt.Livre != null)
                    emprunt.Livre.Quantite += 1;

                _db.Emprunts.Remove(emprunt);
                _db.SaveChanges();

                MessageBox.Show("Emprunt supprimé");
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
        // RECHERCHER
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
                    .Select(e => new
                    {
                        e.EmpruntId,
                        e.LivreId,
                        Livre = e.Livre != null ? e.Livre.Titre : "",
                        e.UsagerId,
                        Usager = e.Usager != null ? (e.Usager.Nom + " " + e.Usager.Prenom).Trim() : "",
                        e.DateEmprunt,
                        e.DateRetourPrevue,
                        DateRetour = e.DateRetour,
                        Etat = e.DateRetour == null ? "EnCours" : "Retourné"
                    })
                    .ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Aucun emprunt trouvé avec cet IdEmprunt.");
                    dgvEmprunt.DataSource = null;
                    return;
                }

                dgvEmprunt.DataSource = null;
                dgvEmprunt.DataSource = data;
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
        // CLICK GRILLE -> remplir
        // =========================
        private void dgvEmprunt_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvEmprunt.Rows[e.RowIndex];
                if (row == null) return;

                // On lit par nom de colonnes (comme on projette un new {})
                txtIdEmpruntRetour.Text = row.Cells["EmpruntId"].Value?.ToString();
                txtIdEmpruntSupp.Text = row.Cells["EmpruntId"].Value?.ToString();

                // Remettre les combos via Id
                if (row.Cells["UsagerId"].Value != null)
                    cmbUsager.SelectedValue = Convert.ToInt32(row.Cells["UsagerId"].Value);

                if (row.Cells["LivreId"].Value != null)
                    cmbLivre.SelectedValue = Convert.ToInt32(row.Cells["LivreId"].Value);

                // Dates
                if (row.Cells["DateEmprunt"].Value != null)
                    dtpDateEmprunt.Value = Convert.ToDateTime(row.Cells["DateEmprunt"].Value);

                if (row.Cells["DateRetourPrevue"].Value != null)
                    dtpRetourPrevu.Value = Convert.ToDateTime(row.Cells["DateRetourPrevue"].Value);

                // DateRetour (si null -> Today)
                var valRetour = row.Cells["DateRetour"].Value;
                dtpDateRetourReel.Value = (valRetour == null || valRetour == DBNull.Value)
                    ? DateTime.Today
                    : Convert.ToDateTime(valRetour);
            }
            catch
            {
                // ne crash pas sur un clic
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
        // RETOUR
        // =========================

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
