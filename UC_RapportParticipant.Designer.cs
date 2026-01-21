namespace TP3_BD
{
    partial class UC_RapportParticipant
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            dgvParticipants = new DataGridView();
            btnAfficher = new Button();
            cboActivite = new ComboBox();
            lbActiviteRapports = new Label();
            lbRapportParticipant = new Label();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            SuspendLayout();
            // 
            // dgvParticipants
            // 
            dgvParticipants.AllowUserToAddRows = false;
            dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipants.Location = new Point(24, 132);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.ReadOnly = true;
            dgvParticipants.Size = new Size(482, 303);
            dgvParticipants.TabIndex = 9;
            // 
            // btnAfficher
            // 
            btnAfficher.Location = new Point(298, 78);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(75, 23);
            btnAfficher.TabIndex = 8;
            btnAfficher.Text = "Afficher";
            btnAfficher.UseVisualStyleBackColor = true;
            btnAfficher.Click += btnAfficher_Click;
            // 
            // cboActivite
            // 
            cboActivite.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActivite.FormattingEnabled = true;
            cboActivite.Location = new Point(106, 78);
            cboActivite.Name = "cboActivite";
            cboActivite.Size = new Size(121, 23);
            cboActivite.TabIndex = 7;
            // 
            // lbActiviteRapports
            // 
            lbActiviteRapports.AutoSize = true;
            lbActiviteRapports.Location = new Point(30, 81);
            lbActiviteRapports.Name = "lbActiviteRapports";
            lbActiviteRapports.Size = new Size(47, 15);
            lbActiviteRapports.TabIndex = 6;
            lbActiviteRapports.Text = "Activite";
            // 
            // lbRapportParticipant
            // 
            lbRapportParticipant.AutoSize = true;
            lbRapportParticipant.Location = new Point(24, 34);
            lbRapportParticipant.Name = "lbRapportParticipant";
            lbRapportParticipant.Size = new Size(121, 15);
            lbRapportParticipant.TabIndex = 5;
            lbRapportParticipant.Text = "Rapports-Participants";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(431, 486);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 10;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // UC_RapportParticipant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRetour);
            Controls.Add(dgvParticipants);
            Controls.Add(btnAfficher);
            Controls.Add(cboActivite);
            Controls.Add(lbActiviteRapports);
            Controls.Add(lbRapportParticipant);
            Name = "UC_RapportParticipant";
            Size = new Size(628, 547);
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvParticipants;
        private Button btnAfficher;
        private ComboBox cboActivite;
        private Label lbActiviteRapports;
        private Label lbRapportParticipant;
        private Button btnRetour;
    }
}
