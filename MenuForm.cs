namespace TP3_BD
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnLivre_Click(object sender, EventArgs e)
        {
            LivreForm1 form = new LivreForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnAuteur_Click(object sender, EventArgs e)
        {
            AuteurForm1 form = new AuteurForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            CategorieForm1 form = new CategorieForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnUsager_Click(object sender, EventArgs e)
        {
            UsagerForm1 form = new UsagerForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnEmprunt_Click(object sender, EventArgs e)
        {
            EmpruntForm1 form = new EmpruntForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnActivité_Click(object sender, EventArgs e)
        {
            ActiviteForm1 form = new ActiviteForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnParticipation_Click(object sender, EventArgs e)
        {
            ParticipationForm1 form = new ParticipationForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnMatériel_Click(object sender, EventArgs e)
        {
            MaterielForm1 form = new MaterielForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnEmpruntMatériel_Click(object sender, EventArgs e)
        {
            EmpruntMaterielForm1 form = new EmpruntMaterielForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnEmployé_Click(object sender, EventArgs e)
        {
            EmployeForm1 form = new EmployeForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnÉvaluation_Click(object sender, EventArgs e)
        {
            EvaluationForm1 form = new EvaluationForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnRapports_Click(object sender, EventArgs e)
        {
            RapportsForm1 form = new RapportsForm1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
