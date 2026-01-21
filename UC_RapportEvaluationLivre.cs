using System;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class UC_RapportEvaluationLivre : UserControl
    {
        private readonly BiblioContext _db = new BiblioContext();
        private readonly RapportsService _service = new RapportsService();

        public UC_RapportEvaluationLivre()
        {
            InitializeComponent();
            ChargerLivres();
            ConfigurerGrille();
        }

        private void ChargerLivres()
        {
            var livres = _db.Livres
                .OrderBy(l => l.Titre)
                .ToList();

            cboLivres.DataSource = livres;
            cboLivres.DisplayMember = "Titre";   // ce que l'utilisateur voit
            cboLivres.ValueMember = "LivreId";  // ⚠️ CE POINT EST CRUCIAL
            cboLivres.SelectedIndex = livres.Count > 0 ? 0 : -1;
        }


        private void ConfigurerGrille()
        {
            dgvLivres.ReadOnly = true;
            dgvLivres.AllowUserToAddRows = false;
            dgvLivres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivres.MultiSelect = false;
        }

        public List<RapportEvaluationLivre> GetEvaluationResumeParLivre(int livreId)
        {
            return _db.Evaluations
                .Where(e => e.LivreId == livreId)
                .GroupBy(e => e.Livre!.Titre)
                .Select(g => new RapportEvaluationLivre
                {
                    Livre = g.Key,
                    NoteMoyenne = Math.Round(g.Average(x => x.Note), 2),
                    NombreEvaluations = g.Count()
                })
                .ToList();
        }



        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (cboLivres.SelectedValue == null)
            {
                MessageBox.Show("Choisis un livre.");
                return;
            }

            int livreId = (int)cboLivres.SelectedValue;

            var data = _service.GetEvaluationsDetailsParLivre(livreId);

            if (data.Count == 0)
            {
                dgvLivres.DataSource = null;
                MessageBox.Show("Ce livre n'a aucune évaluation.");
                return;
            }

            dgvLivres.DataSource = data;

            // (optionnel) titres des colonnes plus beaux
            dgvLivres.Columns["Usager"].HeaderText = "Usager";
            dgvLivres.Columns["Note"].HeaderText = "Note";
            dgvLivres.Columns["Commentaire"].HeaderText = "Commentaire";
            dgvLivres.Columns["DateEvaluation"].HeaderText = "Date";
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
