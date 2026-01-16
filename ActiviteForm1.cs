using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class ActiviteForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public ActiviteForm1()
        {
            InitializeComponent();
            this.Load += ActiviteForm1_Load;

            // Optionnel : brancher le click si pas fait dans le designer
            dgvActivite.CellClick += dgvActivite_CellClick;
        }

        // ==========================
        // AU CHARGEMENT DU FORM
        // ==========================
        private void ActiviteForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                ChargerCombos();
                ChargerGrille();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement form : " + ex.Message);
            }
        }

        // ==========================
        // COMBOS
        // ==========================
        private void ChargerCombos()
        {
            // 1) Types (si tu ne les as pas mis dans le designer)
            if (cmbTypeActivite.Items.Count == 0)
            {
                cmbTypeActivite.Items.Add("Évènement");
                cmbTypeActivite.Items.Add("Concours");
                cmbTypeActivite.SelectedIndex = 0;
            }

            if (cmbModifTypeActivite.Items.Count == 0)
            {
                cmbModifTypeActivite.Items.Add("Évènement");
                cmbModifTypeActivite.Items.Add("Concours");
                cmbModifTypeActivite.SelectedIndex = 0;
            }

            // 2) Organisateur = Employés
            var employes = _db.Employes
                .Select(e => new
                {
                    e.EmployeId,
                    NomComplet = (e.Nom + " " + e.Prenom)
                })
                .OrderBy(x => x.NomComplet)
                .ToList();

            cmbEmployeOrganisateur.DisplayMember = "NomComplet";
            cmbEmployeOrganisateur.ValueMember = "EmployeId";
            cmbEmployeOrganisateur.DataSource = employes;

            cmbModifOrganisateur.DisplayMember = "NomComplet";
            cmbModifOrganisateur.ValueMember = "EmployeId";
            cmbModifOrganisateur.DataSource = employes.ToList(); // copie
        }

        // ==========================
        // CHARGER GRILLE
        // ==========================
        private void ChargerGrille()
        {
            dgvActivite.DataSource = null;

            dgvActivite.DataSource = _db.Activites
                .Include(a => a.Organisateur)
                .OrderBy(a => a.Date)
                .ToList();

            dgvActivite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==========================
        // AJOUTER
        // ==========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderAjout()) return;

                var activite = new Activite
                {
                    Titre = txtTitreActivite.Text.Trim(),
                    Type = cmbTypeActivite.Text.Trim(),
                    Date = dtpDateActivite.Value.Date,
                    CapaciteMax = (int)nudCapaciteMax.Value,
                    OrganisateurId = (int)cmbEmployeOrganisateur.SelectedValue
                };

                _db.Activites.Add(activite);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();

                MessageBox.Show("Activité ajoutée ✅");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (ajout) : " + ex.InnerException?.Message ?? ex.Message);
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
                if (!int.TryParse(txtIdActiviteModif.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne une activité dans la liste.");
                    return;
                }

                if (!ValiderModif()) return;

                var activite = _db.Activites.FirstOrDefault(a => a.ActiviteId == id);
                if (activite == null)
                {
                    MessageBox.Show("Activité introuvable.");
                    return;
                }

                activite.Titre = txtModifTitreActivite.Text.Trim();
                activite.Type = cmbModifTypeActivite.Text.Trim();
                activite.Date = dtpModifDateActivite.Value.Date;
                activite.CapaciteMax = (int)nudModifCapaciteMax.Value;
                activite.OrganisateurId = (int)cmbModifOrganisateur.SelectedValue;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();

                MessageBox.Show("Activité modifiée ✅");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (modif) : " + ex.InnerException?.Message ?? ex.Message);
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
                if (!int.TryParse(txtIdActiviteSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne une activité dans la liste.");
                    return;
                }

                var activite = _db.Activites
                    .Include(a => a.Participations)
                    .FirstOrDefault(a => a.ActiviteId == id);

                if (activite == null)
                {
                    MessageBox.Show("Activité introuvable.");
                    return;
                }

                // ✅ Empêche suppression si participations (FK Restrict)
                if (activite.Participations != null && activite.Participations.Any())
                {
                    MessageBox.Show("Suppression impossible : cette activité a des participations.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Supprimer cette activité ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _db.Activites.Remove(activite);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();

                MessageBox.Show("Activité supprimée ✅");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (suppression) : " + ex.InnerException?.Message ?? ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (suppression) : " + ex.Message);
            }
        }

        // ==========================
        // RECHERCHER (par IdActivite)
        // txtListeIdActivite
        // ==========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdActivite.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdActivite valide (nombre).");
                    return;
                }

                var activite = _db.Activites
                    .Include(a => a.Organisateur)
                    .FirstOrDefault(a => a.ActiviteId == id);

                if (activite == null)
                {
                    MessageBox.Show("Aucune activité trouvée avec cet IdActivite.");
                    return;
                }

                dgvActivite.DataSource = null;
                dgvActivite.DataSource = new[] { activite }.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        // ==========================
        // ACTUALISER
        // ==========================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerGrille();
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
            // Ajout
            txtTitreActivite.Clear();
            dtpDateActivite.Value = DateTime.Today;
            nudCapaciteMax.Value = 0;
            if (cmbTypeActivite.Items.Count > 0) cmbTypeActivite.SelectedIndex = 0;
            if (cmbEmployeOrganisateur.Items.Count > 0) cmbEmployeOrganisateur.SelectedIndex = 0;

            // Modif
            txtIdActiviteModif.Clear();
            txtModifTitreActivite.Clear();
            dtpModifDateActivite.Value = DateTime.Today;
            nudModifCapaciteMax.Value = 0;
            if (cmbModifTypeActivite.Items.Count > 0) cmbModifTypeActivite.SelectedIndex = 0;
            if (cmbModifOrganisateur.Items.Count > 0) cmbModifOrganisateur.SelectedIndex = 0;

            // Supp
            txtIdActiviteSupp.Clear();

            // Recherche
            txtListeIdActivite.Clear();
        }

        // ==========================
        // RETOUR
        // ==========================
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================
        // CLICK GRILLE => remplir zones Modif + Supp
        // ==========================
        private void dgvActivite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                if (dgvActivite.Rows[e.RowIndex].DataBoundItem is Activite a)
                {
                    // Remplir Supp
                    txtIdActiviteSupp.Text = a.ActiviteId.ToString();

                    // Remplir Modif
                    txtIdActiviteModif.Text = a.ActiviteId.ToString();
                    txtModifTitreActivite.Text = a.Titre;
                    cmbModifTypeActivite.Text = a.Type;
                    dtpModifDateActivite.Value = a.Date;
                    nudModifCapaciteMax.Value = a.CapaciteMax;
                    cmbModifOrganisateur.SelectedValue = a.OrganisateurId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sélection : " + ex.Message);
            }
        }

        // ==========================
        // VALIDATIONS
        // ==========================
        private bool ValiderAjout()
        {
            if (string.IsNullOrWhiteSpace(txtTitreActivite.Text))
            {
                MessageBox.Show("Titre obligatoire.");
                return false;
            }

            if (cmbTypeActivite.SelectedItem == null && string.IsNullOrWhiteSpace(cmbTypeActivite.Text))
            {
                MessageBox.Show("Choisis un type (Évènement/Concours).");
                return false;
            }

            if (cmbEmployeOrganisateur.SelectedValue == null)
            {
                MessageBox.Show("Choisis un organisateur.");
                return false;
            }

            if (nudCapaciteMax.Value <= 0)
            {
                MessageBox.Show("Capacité doit être > 0.");
                return false;
            }

            return true;
        }

        private bool ValiderModif()
        {
            if (string.IsNullOrWhiteSpace(txtModifTitreActivite.Text))
            {
                MessageBox.Show("Titre obligatoire (modification).");
                return false;
            }

            if (cmbModifOrganisateur.SelectedValue == null)
            {
                MessageBox.Show("Choisis un organisateur (modification).");
                return false;
            }

            if (nudModifCapaciteMax.Value <= 0)
            {
                MessageBox.Show("Capacité doit être > 0 (modification).");
                return false;
            }

            return true;
        }
    }
}
