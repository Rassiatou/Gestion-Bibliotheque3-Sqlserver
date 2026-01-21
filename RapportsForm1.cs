using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_BD
{
    public partial class RapportsForm1 : Form
    {
        private UC_RapportEmpruntUsager _ucEmprunts = new UC_RapportEmpruntUsager();
        private UC_RapportParticipant _ucParticipants = new UC_RapportParticipant();
        private UC_RapportEvaluationLivre _ucEvaluations = new UC_RapportEvaluationLivre();
        public RapportsForm1()
        {
            InitializeComponent();
            AfficherUC(_ucEmprunts);
        }

        private void AfficherUC(UserControl uc)
        {
            panelContent.Controls.Clear();   
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnRapportEmpruntUsager_Click(object sender, EventArgs e)
        {
            AfficherUC(_ucEmprunts);
        }

        private void btnRapportParticipants_Click(object sender, EventArgs e)
        {
            AfficherUC(_ucParticipants);
        }

        private void btnRapportEvaluationLivre_Click(object sender, EventArgs e)
        {
            AfficherUC(_ucEvaluations);
        }
    }
}
