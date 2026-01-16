using Microsoft.EntityFrameworkCore;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class EmployeForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public EmployeForm1()
        {
            InitializeComponent();
            this.Load += EmployeForm1_Load;
        }

        private void EmployeForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                RemplirRoles();
                SeedRolesSiVide();
                ChargerGrille();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // ROLES (ComboBox)
        // -------------------------
        private void RemplirRoles()
        {
            // Tu peux ajuster la liste selon ton projet
            var roles = new List<string> { "Admin", "Bibliothécaire", "Employé", "Gestionnaire" };

            cmbRole.DataSource = roles.ToList();

            // si tu as un combo pour la partie modifier
            if (cmbRoleModif != null)
                cmbRoleModif.DataSource = roles.ToList();
        }

        private void SeedRolesSiVide()
        {
            // Facultatif : créer 2 employés si ta table est vide
            if (!_db.Employes.Any())
            {
                _db.Employes.AddRange(
                    new Employe { Nom = "Diallo", Prenom = "Bella", Role = "Gestionnaire" },
                    new Employe { Nom = "Barry", Prenom = "Woundé", Role = "Bibliothécaire" }
                );
                _db.SaveChanges();
            }
        }

        // -------------------------
        // CHARGER LA GRILLE
        // -------------------------
        private void ChargerGrille()
        {
            dgvEmployes.DataSource = null;
            dgvEmployes.DataSource = _db.Employes
                .OrderBy(e => e.Nom)
                .ThenBy(e => e.Prenom)
                .ToList();

            dgvEmployes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // -------------------------
        // AJOUTER
        // -------------------------
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                var nom = txtNomEmploye.Text.Trim();
                var prenom = txtPrenomEmploye.Text.Trim();
                var role = cmbRole.SelectedItem?.ToString() ?? "";

                if (string.IsNullOrWhiteSpace(nom))
                {
                    MessageBox.Show("Nom obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(prenom))
                {
                    MessageBox.Show("Prénom obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("Choisis un rôle.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var emp = new Employe
                {
                    Nom = nom,
                    Prenom = prenom,
                    Role = role
                };

                _db.Employes.Add(emp);
                _db.SaveChanges();

                MessageBox.Show("Employé ajouté ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // MODIFIER
        // -------------------------
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEmploye.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEmploye invalide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var emp = _db.Employes.FirstOrDefault(x => x.EmployeId == id);
                if (emp == null)
                {
                    MessageBox.Show("Employé introuvable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var nom = txtNomEmployeModif.Text.Trim();
                var prenom = txtPrenomEmployeModif.Text.Trim();
                var role = cmbRoleModif.SelectedItem?.ToString() ?? "";

                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("Nom / Prénom / Rôle obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                emp.Nom = nom;
                emp.Prenom = prenom;
                emp.Role = role;

                _db.SaveChanges();

                MessageBox.Show("Employé modifié ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // SUPPRIMER
        // -------------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdEmployeSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdEmploye invalide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var emp = _db.Employes.FirstOrDefault(x => x.EmployeId == id);
                if (emp == null)
                {
                    MessageBox.Show("Employé introuvable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show("Supprimer cet employé ?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                _db.Employes.Remove(emp);
                _db.SaveChanges();

                MessageBox.Show("Employé supprimé ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // RECHERCHER (par IdEmploye)
        // -------------------------
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdEmploye.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdEmploye valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var data = _db.Employes.Where(x => x.EmployeId == id).ToList();

                dgvEmployes.DataSource = null;
                dgvEmployes.DataSource = data;

                if (data.Count == 0)
                    MessageBox.Show("Aucun résultat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e) => ChargerGrille();

        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void btnRetour_Click(object sender, EventArgs e) => this.Close();

        private void ViderChamps()
        {
            try
            {
                // Ajout
                txtNomEmploye.Clear();
                txtPrenomEmploye.Clear();
                if (cmbRole.Items.Count > 0) cmbRole.SelectedIndex = 0;

                // Modifier
                txtIdEmploye.Clear();
                txtNomEmployeModif.Clear();
                txtPrenomEmployeModif.Clear();
                if (cmbRoleModif.Items.Count > 0) cmbRoleModif.SelectedIndex = 0;

                // Supprimer
                txtIdEmployeSupp.Clear();

                // Recherche
                txtListeIdEmploye.Clear();
            }
            catch
            {
                // évite crash si un control a été renommé/supprimé
            }
        }
    }
}
