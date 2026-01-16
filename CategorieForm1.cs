using Microsoft.EntityFrameworkCore;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class CategorieForm1 : Form
    {
        private readonly BiblioContext _db = new BiblioContext();

        public CategorieForm1()
        {
            InitializeComponent();

            // Quand le form s'ouvre, on charge la grille
            this.Load += CategorieForm1_Load;
        }

        private void CategorieForm1_Load(object? sender, EventArgs e)
        {
            ChargerGrille();
        }

        // =========================
        // 1) CHARGER LA GRILLE
        // =========================
        private void ChargerGrille()
        {
            try
            {
                dgvCategorie.DataSource = null;

                var data = _db.Categories
                    .OrderBy(c => c.Nom)
                    .ToList();

                dgvCategorie.DataSource = data;
                dgvCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des catégories.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // 2) AJOUTER
        // =========================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                var nom = txtNomCategorie.Text.Trim();
                var desc = txtDescription.Text.Trim();

                if (string.IsNullOrWhiteSpace(nom))
                {
                    MessageBox.Show("Le nom est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optionnel: éviter doublons
                bool existe = _db.Categories.Any(c => c.Nom == nom);
                if (existe)
                {
                    MessageBox.Show("Cette catégorie existe déjà.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cat = new Categorie
                {
                    Nom = nom,
                    Description = desc
                };

                _db.Categories.Add(cat);
                _db.SaveChanges();

                MessageBox.Show("Catégorie ajoutée ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // 3) MODIFIER
        // =========================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdCategorie.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdCategorie invalide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nom = txtNomCategorieModif.Text.Trim();
                var desc = txtDescriptionModif.Text.Trim();

                if (string.IsNullOrWhiteSpace(nom))
                {
                    MessageBox.Show("Le nom est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cat = _db.Categories.FirstOrDefault(c => c.CategorieId == id);
                if (cat == null)
                {
                    MessageBox.Show("Catégorie introuvable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cat.Nom = nom;
                cat.Description = desc;

                _db.SaveChanges();

                MessageBox.Show("Catégorie modifiée ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // 4) SUPPRIMER
        // =========================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdCategorieSupp.Text.Trim(), out int id))
                {
                    MessageBox.Show("IdCategorie invalide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cat = _db.Categories
                    .Include(c => c.Livres) // pour vérifier si utilisée
                    .FirstOrDefault(c => c.CategorieId == id);

                if (cat == null)
                {
                    MessageBox.Show("Catégorie introuvable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Protection: si catégorie déjà utilisée par des livres
                if (cat.Livres != null && cat.Livres.Count > 0)
                {
                    MessageBox.Show("Impossible de supprimer : cette catégorie est utilisée par des livres.",
                        "Bloqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Supprimer cette catégorie ?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                _db.Categories.Remove(cat);
                _db.SaveChanges();

                MessageBox.Show("Catégorie supprimée ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerGrille();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // 5) RECHERCHER (par IdCategorie)
        // =========================
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtListeIdCategorie.Text.Trim(), out int id))
                {
                    MessageBox.Show("Entre un IdCategorie valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cat = _db.Categories
                    .Where(c => c.CategorieId == id)
                    .ToList();

                dgvCategorie.DataSource = null;
                dgvCategorie.DataSource = cat;

                if (cat.Count == 0)
                {
                    MessageBox.Show("Aucun résultat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // 6) VIDER / ACTUALISER / RETOUR
        // =========================
        private void btnVider_Click(object sender, EventArgs e) => ViderChamps();

        private void btnActualiser_Click(object sender, EventArgs e) => ChargerGrille();

        private void btnRetour_Click(object sender, EventArgs e) => this.Close();

        private void ViderChamps()
        {
            try
            {
                // Ajout
                txtNomCategorie.Clear();
                txtDescription.Clear();

                // Modifier
                txtIdCategorie.Clear();
                txtNomCategorieModif.Clear();
                txtDescriptionModif.Clear();

                // Supprimer
                txtIdCategorieSupp.Clear();

                // Recherche
                txtIdCategorie.Clear();
            }
            catch
            {
                // Ici on évite de crasher si un champ n'existe pas
                // (pratique quand tu renommes des textbox dans le designer)
            }
        }

        private void txtListeIdCategorie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
