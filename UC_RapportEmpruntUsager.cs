using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD
{
    public partial class UC_RapportEmpruntUsager : UserControl
    {
        private readonly BiblioContext _db = new BiblioContext();
        private RapportsService _service = new RapportsService();
        public UC_RapportEmpruntUsager()
        {
            InitializeComponent();
            ChargerUsagers();
            ConfigurerGrille();
        }

        private void ChargerUsagers()
        {
            var usagers = _db.Usagers
                .OrderBy(u => u.Nom)
                .ThenBy(u => u.Prenom)
                .ToList();

            cboUsagers.DataSource = usagers;
            cboUsagers.DisplayMember = "Nom";      // ou "Prenom" selon ton choix
            cboUsagers.ValueMember = "UsagerId";
            cboUsagers.SelectedIndex = usagers.Count > 0 ? 0 : -1;
        }

        private void ConfigurerGrille()
        {
            dgvEmprunts.ReadOnly = true;
            dgvEmprunts.AllowUserToAddRows = false;
            dgvEmprunts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            int UsagerId = (int)cboUsagers.SelectedValue;
            dgvEmprunts.DataSource = _service.GetEmpruntsParUsager(UsagerId);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
