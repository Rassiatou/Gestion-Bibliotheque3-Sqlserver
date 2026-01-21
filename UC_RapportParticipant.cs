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
    public partial class UC_RapportParticipant : UserControl
    {
        private readonly BiblioContext _db = new BiblioContext();
        private readonly RapportsService _service = new RapportsService();
        public UC_RapportParticipant()
        {
            InitializeComponent();
            ChargerActivites();
            ConfigurerGrille();
        }

        private void ChargerActivites()
        {
            var activites = _db.Activites
                .OrderBy(a => a.Date)
                .ToList();

            cboActivite.DataSource = activites;
            cboActivite.DisplayMember = "Titre";      // assure-toi que Activite a bien "Titre"
            cboActivite.ValueMember = "ActiviteId";  // assure-toi que c'est le bon Id
            cboActivite.SelectedIndex = activites.Count > 0 ? 0 : -1;
        }

        private void ConfigurerGrille()
        {
            dgvParticipants.ReadOnly = true;
            dgvParticipants.AllowUserToAddRows = false;
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (cboActivite.SelectedValue == null)
            {
                MessageBox.Show("Choisis une activité.");
                return;
            }

            int activiteId = (int)cboActivite.SelectedValue;

            dgvParticipants.DataSource = _service.GetParticipantsParConcours(activiteId);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
