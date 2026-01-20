using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class UsagerForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public UsagerForm1()
        {
            InitializeComponent();
            this.Load += UsagerForm1_Load;
        }

        private void UsagerForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                ChargerComboType();
                ChargerGrille();
                ViderChamps();

                dgvUsager.CellClick += dgvUsager_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement : " + ex.Message);
            }
        }

        // ----------------------------
        // Chargements
        // ----------------------------
        private void ChargerComboType()
        {
            cmbtypeUsager.Items.Clear();
            cmbtypeUsager.Items.Add("Étudiant");
            cmbtypeUsager.Items.Add("Employé");
            cmbtypeUsager.Items.Add("Externe");

            if (cmbtypeUsager.Items.Count > 0)
                cmbtypeUsager.SelectedIndex = 0;
        }

        private void ChargerGrille()
        {
            dgvUsager.DataSource = null;

            var data = _db.Usagers
                .OrderBy(u => u.Nom)
                .ThenBy(u => u.Prenom)
                .ToList();

            dgvUsager.DataSource = data;
            dgvUsager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsager.ReadOnly = true;
            dgvUsager.MultiSelect = false;
        }

        // ----------------------------
        // Ajouter
        // ----------------------------
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderAjout(out var nom, out var prenom, out var tel, out var type, out var actif))
                    return;

                var u = new Usager
                {
                    Nom = nom,
                    Prenom = prenom,
                    Telephone = tel,
                    TypeUsager = type,
                    Actif = actif
                };

                _db.Usagers.Add(u);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Usager ajouté");
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

        // ----------------------------
        // Modifier
        // ----------------------------
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdUsager.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un usager à modifier.");
                    return;
                }

                if (!ValiderModification(out var nom, out var prenom, out var tel, out var type, out var actif))
                    return;

                var u = _db.Usagers.FirstOrDefault(x => x.UsagerId == id);
                if (u == null)
                {
                    MessageBox.Show("Usager introuvable.");
                    return;
                }

                u.Nom = nom;
                u.Prenom = prenom;
                u.Telephone = tel;
                u.TypeUsager = type;
                u.Actif = actif;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Usager modifié");
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

        // ----------------------------
        // Supprimer
        // ----------------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdUsagerSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un usager à supprimer.");
                    return;
                }

                bool aDesEmprunts = _db.Emprunts.Any(em => em.UsagerId == id);
                if (aDesEmprunts)
                {
                    MessageBox.Show("Suppression interdite : cet usager a des emprunts.");
                    return;
                }

                var u = _db.Usagers.FirstOrDefault(x => x.UsagerId == id);
                if (u == null)
                {
                    MessageBox.Show("Usager introuvable.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Confirmer suppression ?",
                    "Suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes) return;

                _db.Usagers.Remove(u);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Usager supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (suppression) : " + ex.Message);
            }
        }

        // ----------------------------
        // Rechercher
        // ----------------------------
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdUsager.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdUsager valide.");
                    return;
                }

                var data = _db.Usagers
                    .Where(u => u.UsagerId == id)
                    .ToList();

                dgvUsager.DataSource = null;
                dgvUsager.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        // ----------------------------
        // Actualiser + Vider
        // ----------------------------
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try { ChargerGrille(); }
            catch (Exception ex) { MessageBox.Show("Erreur (actualiser) : " + ex.Message); }
        }

        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void ViderChamps()
        {
            txtNomUsager.Clear();
            txtPrenomUsager.Clear();
            txtTelephone.Clear();

            txtIdUsager.Clear();
            txtNomUsagerModif.Clear();
            txtPrenomUsagerModif.Clear();
            txtTelephoneModif.Clear();

            txtIdUsagerSupp.Clear();
            txtListeIdUsager.Clear();

            chkActif.Checked = true;
            chkInactif.Checked = false;

            if (cmbtypeUsager.Items.Count > 0)
                cmbtypeUsager.SelectedIndex = 0;
        }

        private void dgvUsager_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsager.Rows[e.RowIndex].DataBoundItem is Usager u)
            {
                txtIdUsager.Text = u.UsagerId.ToString();
                txtNomUsagerModif.Text = u.Nom;
                txtPrenomUsagerModif.Text = u.Prenom;
                txtTelephoneModif.Text = u.Telephone;
                cmbtypeUsager.SelectedItem = u.TypeUsager;

                chkActif.Checked = u.Actif;
                chkInactif.Checked = !u.Actif;

                txtIdUsagerSupp.Text = u.UsagerId.ToString();
            }
        }

        // ----------------------------
        // Validation du téléphone : 10 chiffres EXACTEMENT
        // ----------------------------
        private bool TelephoneValide(string tel)
        {
            return tel.All(char.IsDigit) && tel.Length == 10;
        }

        private bool ValiderAjout(out string nom, out string prenom, out string tel, out string type, out bool actif)
        {
            nom = txtNomUsager.Text.Trim();
            prenom = txtPrenomUsager.Text.Trim();
            tel = txtTelephone.Text.Trim();
            type = cmbtypeUsager.Text.Trim();
            actif = chkActif.Checked && !chkInactif.Checked;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Nom obligatoire.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(prenom))
            {
                MessageBox.Show("Prénom obligatoire.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tel))
            {
                MessageBox.Show("Téléphone obligatoire.");
                return false;
            }

            if (!TelephoneValide(tel))
            {
                MessageBox.Show("Téléphone invalide : tu dois entrer EXACTEMENT 10 chiffres.");
                return false;
            }

            if (chkActif.Checked && chkInactif.Checked)
            {
                MessageBox.Show("Choisis Actif OU Inactif.");
                return false;
            }

            if (!chkActif.Checked && !chkInactif.Checked)
            {
                MessageBox.Show("Choisis Actif ou Inactif.");
                return false;
            }

            if (chkInactif.Checked) actif = false;

            return true;
        }

        private bool ValiderModification(out string nom, out string prenom, out string tel, out string type, out bool actif)
        {
            nom = txtNomUsagerModif.Text.Trim();
            prenom = txtPrenomUsagerModif.Text.Trim();
            tel = txtTelephoneModif.Text.Trim();
            type = cmbtypeUsager.Text.Trim();
            actif = chkActif.Checked && !chkInactif.Checked;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Nom obligatoire (modification).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(prenom))
            {
                MessageBox.Show("Prénom obligatoire (modification).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tel))
            {
                MessageBox.Show("Téléphone obligatoire (modification).");
                return false;
            }

            if (!TelephoneValide(tel))
            {
                MessageBox.Show("Téléphone invalide : 10 chiffres requis.");
                return false;
            }

            if (chkActif.Checked && chkInactif.Checked)
            {
                MessageBox.Show("Choisis Actif OU Inactif.");
                return false;
            }

            if (!chkActif.Checked && !chkInactif.Checked)
            {
                MessageBox.Show("Choisis Actif ou Inactif.");
                return false;
            }

            if (chkInactif.Checked) actif = false;
            return true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
