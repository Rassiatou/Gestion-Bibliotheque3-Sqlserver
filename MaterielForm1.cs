using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class MaterielForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public MaterielForm1()
        {
            InitializeComponent();
            this.Load += MaterielForm1_Load;

            // Important: pour remplir les champs quand on clique dans la grille
            dgvMateriel.CellClick += dgvMateriel_CellClick;
        }

        // =========================
        // LOAD
        // =========================
        private void MaterielForm1_Load(object? sender, EventArgs e)
        {
            try
            {
                InitialiserCombos();
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement : " + ex.Message);
            }
        }

        private void InitialiserCombos()
        {
            // Combo Etat (Ajout)
            if (cmbEtat.Items.Count == 0)
            {
                cmbEtat.Items.AddRange(new object[]
                {
                    "Disponible",
                    "Emprunté",
                    "Brisé",
                    "Maintenance"
                });
            }
            if (cmbEtat.Items.Count > 0) cmbEtat.SelectedIndex = 0;

            // Combo Etat (Modification)
            if (cmbModifEtat.Items.Count == 0)
            {
                cmbModifEtat.Items.AddRange(new object[]
                {
                    "Disponible",
                    "Emprunté",
                    "Brisé",
                    "Maintenance"
                });
            }
            if (cmbModifEtat.Items.Count > 0) cmbModifEtat.SelectedIndex = 0;
        }

        // =========================
        // CHARGER GRILLE
        // =========================
        private void ChargerGrille()
        {
            dgvMateriel.DataSource = null;

            var data = _db.Materiels
                .Select(m => new
                {
                    m.MaterielId,
                    m.Nom,
                    m.Etat,
                    m.Quantite
                })
                .OrderBy(m => m.MaterielId)
                .ToList();

            dgvMateriel.DataSource = data;

            dgvMateriel.ReadOnly = true;
            dgvMateriel.MultiSelect = false;
            dgvMateriel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =========================
        // AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderAjout(out string nom, out string etat, out int quantite))
                    return;

                var m = new Materiel
                {
                    Nom = nom,
                    Etat = etat,
                    Quantite = quantite
                };

                _db.Materiels.Add(m);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Matériel ajouté avec succès.");
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
                if (!int.TryParse(txtIdMaterielModif.Text.Trim(), out int id))
                {
                    MessageBox.Show("Sélectionne un matériel à modifier (clique dans la liste).");
                    return;
                }

                if (!ValiderModification(out string nom, out string etat, out int quantite))
                    return;

                var m = _db.Materiels.FirstOrDefault(x => x.MaterielId == id);
                if (m == null)
                {
                    MessageBox.Show("Matériel introuvable.");
                    return;
                }

                m.Nom = nom;
                m.Etat = etat;
                m.Quantite = quantite;

                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Matériel modifié.");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Erreur BD (modification) : " + (ex.InnerException?.Message ?? ex.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (modification) : " + ex.Message);
            }
        }

        // =========================
        // SUPPRIMER
        // =========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdMaterielSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdMateriel valide pour supprimer.");
                    return;
                }

                var m = _db.Materiels.FirstOrDefault(x => x.MaterielId == id);
                if (m == null)
                {
                    MessageBox.Show("Matériel introuvable.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Voulez-vous vraiment supprimer ce matériel ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _db.Materiels.Remove(m);
                _db.SaveChanges();

                ChargerGrille();
                ViderChamps();
                MessageBox.Show("Matériel supprimé.");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Impossible de supprimer : ce matériel est déjà utilisé (contrainte FK).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (suppression) : " + ex.Message);
            }
        }

        // =========================
        // RECHERCHER par Id
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string recherche = txtListeIdMateriel.Text.Trim();

                if (string.IsNullOrWhiteSpace(recherche))
                {
                    MessageBox.Show("Entre un IdMateriel.");
                    return;
                }

                if (!int.TryParse(recherche, out int id))
                {
                    MessageBox.Show("IdMateriel invalide : entre un nombre.");
                    return;
                }

                var data = _db.Materiels
                    .Where(m => m.MaterielId == id)
                    .Select(m => new
                    {
                        m.MaterielId,
                        m.Nom,
                        m.Etat,
                        m.Quantite
                    })
                    .ToList();

                dgvMateriel.DataSource = null;
                dgvMateriel.DataSource = data;

                if (data.Count == 0)
                {
                    MessageBox.Show("Aucun matériel trouvé avec cet Id.");
                    ChargerGrille(); // optionnel : revient à la liste complète
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (recherche) : " + ex.Message);
            }
        }

        // =========================
        // ACTUALISER
        // =========================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try
            {
                ChargerGrille();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur (actualiser) : " + ex.Message);
            }
        }

        // =========================
        // VIDER
        // =========================
        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void ViderChamps()
        {
            // Ajout
            txtNomMateriel.Clear();
            if (cmbEtat.Items.Count > 0) cmbEtat.SelectedIndex = 0;
            nudQuantite.Value = 0;

            // Modif
            txtIdMaterielModif.Clear();
            txtModifNom.Clear();
            if (cmbModifEtat.Items.Count > 0) cmbModifEtat.SelectedIndex = 0;
            nudModifQuantite.Value = 0;

            // Supp
            txtIdMaterielSupp.Clear();

            // Recherche
            txtListeIdMateriel.Clear();

            txtNomMateriel.Focus();
        }

        // =========================
        // CLICK GRILLE -> Remplir Modif + Supp
        // =========================
        private void dgvMateriel_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvMateriel.Rows[e.RowIndex];
                if (row == null) return;

                // Comme la grille est bindée à un objet anonyme, on lit par noms de colonnes
                txtIdMaterielModif.Text = Convert.ToString(row.Cells["MaterielId"].Value);
                txtModifNom.Text = Convert.ToString(row.Cells["Nom"].Value);

                // IMPORTANT: utiliser les champs de modification (pas ceux d'ajout)
                cmbModifEtat.Text = Convert.ToString(row.Cells["Etat"].Value);

                int q = 0;
                int.TryParse(Convert.ToString(row.Cells["Quantite"].Value), out q);
                nudModifQuantite.Value = q;

                // Remplir aussi le champ suppression
                txtIdMaterielSupp.Text = txtIdMaterielModif.Text;
            }
            catch
            {
                // éviter crash au clic
            }
        }

        // =========================
        // VALIDATIONS (style Usager)
        // =========================
        private bool ValiderAjout(out string nom, out string etat, out int quantite)
        {
            nom = txtNomMateriel.Text.Trim();
            etat = cmbEtat.Text.Trim();
            quantite = (int)nudQuantite.Value;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Le nom du matériel est obligatoire.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(etat))
            {
                MessageBox.Show("Choisissez un état.");
                return false;
            }

            if (quantite < 0)
            {
                MessageBox.Show("Quantité invalide.");
                return false;
            }

            return true;
        }

        private bool ValiderModification(out string nom, out string etat, out int quantite)
        {
            nom = txtModifNom.Text.Trim();
            etat = cmbModifEtat.Text.Trim();
            quantite = (int)nudModifQuantite.Value;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Le nom du matériel est obligatoire (modification).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(etat))
            {
                MessageBox.Show("Choisissez un état (modification).");
                return false;
            }

            if (quantite < 0)
            {
                MessageBox.Show("Quantité invalide (modification).");
                return false;
            }

            return true;
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
