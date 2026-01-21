namespace TP3_BD
{
    partial class UC_RapportEmpruntUsager
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
            lbUsager = new Label();
            lbUsagerRapports = new Label();
            cboUsagers = new ComboBox();
            btnAfficher = new Button();
            dgvEmprunts = new DataGridView();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).BeginInit();
            SuspendLayout();
            // 
            // lbUsager
            // 
            lbUsager.AutoSize = true;
            lbUsager.Location = new Point(28, 40);
            lbUsager.Name = "lbUsager";
            lbUsager.Size = new Size(176, 15);
            lbUsager.TabIndex = 0;
            lbUsager.Text = "Rapports-Emprunts d'un Usager";
            // 
            // lbUsagerRapports
            // 
            lbUsagerRapports.AutoSize = true;
            lbUsagerRapports.Location = new Point(34, 87);
            lbUsagerRapports.Name = "lbUsagerRapports";
            lbUsagerRapports.Size = new Size(43, 15);
            lbUsagerRapports.TabIndex = 1;
            lbUsagerRapports.Text = "Usager";
            // 
            // cboUsagers
            // 
            cboUsagers.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsagers.FormattingEnabled = true;
            cboUsagers.Location = new Point(106, 84);
            cboUsagers.Name = "cboUsagers";
            cboUsagers.Size = new Size(121, 23);
            cboUsagers.TabIndex = 2;
            // 
            // btnAfficher
            // 
            btnAfficher.Location = new Point(302, 84);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(75, 23);
            btnAfficher.TabIndex = 3;
            btnAfficher.Text = "Afficher";
            btnAfficher.UseVisualStyleBackColor = true;
            btnAfficher.Click += btnAfficher_Click;
            // 
            // dgvEmprunts
            // 
            dgvEmprunts.AllowUserToAddRows = false;
            dgvEmprunts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunts.Location = new Point(28, 138);
            dgvEmprunts.Name = "dgvEmprunts";
            dgvEmprunts.ReadOnly = true;
            dgvEmprunts.Size = new Size(482, 303);
            dgvEmprunts.TabIndex = 4;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(435, 473);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 5;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // UC_RapportEmpruntUsager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRetour);
            Controls.Add(dgvEmprunts);
            Controls.Add(btnAfficher);
            Controls.Add(cboUsagers);
            Controls.Add(lbUsagerRapports);
            Controls.Add(lbUsager);
            Name = "UC_RapportEmpruntUsager";
            Size = new Size(526, 526);
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsager;
        private Label lbUsagerRapports;
        private ComboBox cboUsagers;
        private Button btnAfficher;
        private DataGridView dgvEmprunts;
        private Button btnRetour;
    }
}
