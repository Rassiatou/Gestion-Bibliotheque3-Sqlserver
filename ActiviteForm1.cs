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

            // Important : éviter double abonnement
            dgvActivite.CellClick -= dgvActivite_CellClick;
            dgvActivite.CellClick += dgvActivite_CellClick;
        }

        private void ActiviteForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                ChargerCombos();
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement : " + ex.Message);
            }
        }

        // =========================
        // AIDE : lire un TextBox par nom (sans casser si le champ n'existe pas)
        // =========================
        private string LireTexte(params string[] nomsPossibles)
        {
            foreach (var nom in nomsPossibles)
            {
                // chercher dans tous les contrôles (true = recherche récursive)
                var ctrls = this.Controls.Find(nom, true);
                if (ctrls != null && ctrls.Length > 0 && ctrls[0] is TextBox tb)
                    return tb.Text.Trim();
            }
            return string.Empty;
        }

        // =========================
        // COMBOS
        // =========================
        private void ChargerCombos()
        {
            // Types
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

            // Organisateur = Employés (Nom + Prenom)
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
            cmbModifOrganisateur.DataSource = employes.ToList();
        }

        // =========================
        // GRILLE (afficher nom organisateur)
        // =========================
        private void ChargerGrille()
        {
            dgvActivite.DataSource = null;

            var data = _db.Activites
                .Include(a => a.Organisateur)
                .OrderBy(a => a.Date)
                .Select(a => new
                {
                    a.ActiviteId,
                    a.Titre,
                    a.Type,
                    a.Date,
                    a.CapaciteMax,
                    a.OrganisateurId,
                    Organisateur = (a.Organisateur.Nom + " " + a.Organisateur.Prenom)
                })
                .ToList();

            dgvActivite.DataSource = data;
            dgvActivite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivite.ReadOnly = true;
            dgvActivite.MultiSelect = false;
        }

        // =========================
        // AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // On lit ton champ EXACT : txtTitreActivite
                // + fallback au cas où ton designer l'a nommé txtTitre
                string titre = LireTexte("txtTitreActivite", "txtTitre");

                if (!ValiderAjout(titre)) return;

                var activite = new Activite
                {
                    Titre = titre,
                    Type = cmbTypeActivite.Text.Trim(),
                    Date = dtpDateActivite.Value.Date,
                    CapaciteMax = (int)nudCapaciteMax.Value,
                    OrganisateurId = (int)cmbEmployeOrganisateur.SelectedValue
                };

                _db.Activites.Add(activite);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Activité ajoutée ");
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

          

        // =========================
        // MODIFIER
        // =========================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Tu m'as donné ce champ : txtIdActiviteModif
                if (!int.TryParse(txtIdActiviteModif.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne une activité à modifier (clique dans la liste).");
                    return;
                }

                // On récupère le titre modif (selon tes champs possibles)
                // (si ton textbox modif s'appelle autrement, il sera trouvé)
                string titreModif = LireTexte(
                    "txtModifTitreActivite",
                    "txtTitreActiviteModif",
                    "txtTitreModif",
                    "txtTitreModifActivite"
                );

                if (!ValiderModif(titreModif)) return;

                var activite = _db.Activites.FirstOrDefault(a => a.ActiviteId == id);
                if (activite == null)
                {
                    MessageBox.Show("Activité introuvable.");
                    return;
                }

                activite.Titre = titreModif;
                activite.Type = cmbModifTypeActivite.Text.Trim();
                activite.Date = dtpModifDateActivite.Value.Date;
                activite.CapaciteMax = (int)nudModifCapaciteMax.Value;
                activite.OrganisateurId = (int)cmbModifOrganisateur.SelectedValue;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Activité modifiée");
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

        // =========================
        // SUPPRIMER
        // =========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Tu m'as donné ce champ : txtIdActiviteSupp
                if (!int.TryParse(txtIdActiviteSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne une activité à supprimer.");
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

                if (activite.Participations != null && activite.Participations.Any())
                {
                    MessageBox.Show("Suppression impossible : cette activité a des participations.");
                    return;
                }

                var confirm = MessageBox.Show("Supprimer cette activité ?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _db.Activites.Remove(activite);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Activité supprimée");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (suppression) : " + ex.Message);
            }
        }

        // =========================
        // RECHERCHER
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdActivite.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdActivite valide (nombre).");
                    return;
                }

                var data = _db.Activites
                    .Include(a => a.Organisateur)
                    .Where(a => a.ActiviteId == id)
                    .Select(a => new
                    {
                        a.ActiviteId,
                        a.Titre,
                        a.Type,
                        a.Date,
                        a.CapaciteMax,
                        a.OrganisateurId,
                        Organisateur = (a.Organisateur.Nom + " " + a.Organisateur.Prenom)
                    })
                    .ToList();

                dgvActivite.DataSource = null;
                dgvActivite.DataSource = data;

                if (data.Count == 0)
                    MessageBox.Show("Aucune activité trouvée avec cet IdActivite.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e) => ChargerGrille();

        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void btnRetour_Click(object sender, EventArgs e) => this.Close();

        // =========================
        // CELLCLICK (grille en Select new => lire par colonnes)
        // =========================
        private void dgvActivite_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvActivite.Rows[e.RowIndex];
                if (row == null) return;

                // Colonnes selon ChargerGrille()
                // 0 ActiviteId, 1 Titre, 2 Type, 3 Date, 4 CapaciteMax, 5 OrganisateurId, 6 Organisateur
                string id = row.Cells[0].Value?.ToString() ?? "";

                txtIdActiviteModif.Text = id;
                txtIdActiviteSupp.Text = id;

                // Remplir le textbox modif titre si on le trouve
                var tbModif = this.Controls.Find("txtModifTitreActivite", true).FirstOrDefault() as TextBox
                              ?? this.Controls.Find("txtTitreActiviteModif", true).FirstOrDefault() as TextBox
                              ?? this.Controls.Find("txtTitreModif", true).FirstOrDefault() as TextBox
                              ?? this.Controls.Find("txtTitreModifActivite", true).FirstOrDefault() as TextBox;

                if (tbModif != null) tbModif.Text = row.Cells[1].Value?.ToString() ?? "";

                cmbModifTypeActivite.Text = row.Cells[2].Value?.ToString() ?? "";
                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime d))
                    dtpModifDateActivite.Value = d;

                if (int.TryParse(row.Cells[4].Value?.ToString(), out int cap))
                    nudModifCapaciteMax.Value = cap;

                if (int.TryParse(row.Cells[5].Value?.ToString(), out int orgId))
                    cmbModifOrganisateur.SelectedValue = orgId;
            }
            catch
            {
                // ne pas casser l'app pour un clic
            }
        }

        // =========================
        // VALIDATIONS
        // =========================
        private bool ValiderAjout(string titre)
        {
            if (string.IsNullOrWhiteSpace(titre))
            {
                MessageBox.Show("Titre obligatoire.");
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

        private bool ValiderModif(string titre)
        {
            if (string.IsNullOrWhiteSpace(titre))
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

        private void ViderChamps()
        {
            // Ajout : ton champ confirmé
            txtTitreActivite.Clear();
            dtpDateActivite.Value = DateTime.Today;
            nudCapaciteMax.Value = 0;
            if (cmbTypeActivite.Items.Count > 0) cmbTypeActivite.SelectedIndex = 0;
            if (cmbEmployeOrganisateur.Items.Count > 0) cmbEmployeOrganisateur.SelectedIndex = 0;

            // Modif
            txtIdActiviteModif.Clear();
            dtpModifDateActivite.Value = DateTime.Today;
            nudModifCapaciteMax.Value = 0;
            if (cmbModifTypeActivite.Items.Count > 0) cmbModifTypeActivite.SelectedIndex = 0;
            if (cmbModifOrganisateur.Items.Count > 0) cmbModifOrganisateur.SelectedIndex = 0;

            // vider textbox modif titre si trouvé
            var tbModif = this.Controls.Find("txtModifTitreActivite", true).FirstOrDefault() as TextBox
                          ?? this.Controls.Find("txtTitreActiviteModif", true).FirstOrDefault() as TextBox
                          ?? this.Controls.Find("txtTitreModif", true).FirstOrDefault() as TextBox
                          ?? this.Controls.Find("txtTitreModifActivite", true).FirstOrDefault() as TextBox;
            if (tbModif != null) tbModif.Clear();

            // Supp + Recherche
            txtIdActiviteSupp.Clear();
            txtListeIdActivite.Clear();
        }
    }
}
