namespace TP3_BD
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        public void btnLivre_Click(object sender, EventArgs e)
        {
            using var livreForm = new LivreForm();
            livreForm.ShowDialog(); // fenêtre modale (recommandé pour CRUD)
                                    // ou: frm.Show(); // non-modale
        }

        private void btnAuteur_Click(object sender, EventArgs e)
        {
            var auteurform = new AuteurForm();
            auteurform.ShowDialog();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            var categorieform = new CategorieForm();
            categorieform.ShowDialog();
        }

        private void btnUsager_Click(object sender, EventArgs e)
        {
            var usagerform = new UsagerForm();
            usagerform.ShowDialog();
        }

        private void btnEmprunt_Click(object sender, EventArgs e)
        {
            var empruntform = new EmpruntForm();
            empruntform.ShowDialog();
        }

        private void btnActivité_Click(object sender, EventArgs e)
        {
            var activiteform = new ActiviteForm();
            activiteform.ShowDialog();
        }

        private void btnParticipation_Click(object sender, EventArgs e)
        {
            var participationform = new ParticipationForm();
            participationform.ShowDialog();
        }

        private void btnMatériel_Click(object sender, EventArgs e)
        {
            var materielform = new MaterielForm();
            materielform.ShowDialog();
        }

        private void btnEmpruntMatériel_Click(object sender, EventArgs e)
        {
            var empruntMatérielform = new EmpruntMatérielForm();
            empruntMatérielform.ShowDialog();
        }

        private void btnEmployé_Click(object sender, EventArgs e)
        {
            var employeform = new EmployeForm();
            employeform.ShowDialog();
        }

        private void btnÉvaluation_Click(object sender, EventArgs e)
        {
            var evaluationform = new EvaluationForm();
            evaluationform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
