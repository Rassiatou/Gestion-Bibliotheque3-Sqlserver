namespace TP3_BD
{
    partial class UC_RapportEvaluationLivre
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
            dgvLivres = new DataGridView();
            btnAfficher = new Button();
            cboLivres = new ComboBox();
            lbLivresRapports = new Label();
            lbRapportEvaluation = new Label();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLivres).BeginInit();
            SuspendLayout();
            // 
            // dgvLivres
            // 
            dgvLivres.AllowUserToAddRows = false;
            dgvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivres.Location = new Point(35, 137);
            dgvLivres.Name = "dgvLivres";
            dgvLivres.ReadOnly = true;
            dgvLivres.Size = new Size(482, 303);
            dgvLivres.TabIndex = 9;
            // 
            // btnAfficher
            // 
            btnAfficher.Location = new Point(309, 83);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(75, 23);
            btnAfficher.TabIndex = 8;
            btnAfficher.Text = "Afficher";
            btnAfficher.UseVisualStyleBackColor = true;
            btnAfficher.Click += btnAfficher_Click;
            // 
            // cboLivres
            // 
            cboLivres.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLivres.FormattingEnabled = true;
            cboLivres.Location = new Point(104, 83);
            cboLivres.Name = "cboLivres";
            cboLivres.Size = new Size(121, 23);
            cboLivres.TabIndex = 7;
            // 
            // lbLivresRapports
            // 
            lbLivresRapports.AutoSize = true;
            lbLivresRapports.Location = new Point(42, 86);
            lbLivresRapports.Name = "lbLivresRapports";
            lbLivresRapports.Size = new Size(32, 15);
            lbLivresRapports.TabIndex = 6;
            lbLivresRapports.Text = "Livre";
            // 
            // lbRapportEvaluation
            // 
            lbRapportEvaluation.AutoSize = true;
            lbRapportEvaluation.Location = new Point(35, 39);
            lbRapportEvaluation.Name = "lbRapportEvaluation";
            lbRapportEvaluation.Size = new Size(169, 15);
            lbRapportEvaluation.TabIndex = 5;
            lbRapportEvaluation.Text = "Rapports-Evaluation d'un Livre";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(442, 556);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 11;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // UC_RapportEvaluationLivre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRetour);
            Controls.Add(dgvLivres);
            Controls.Add(btnAfficher);
            Controls.Add(cboLivres);
            Controls.Add(lbLivresRapports);
            Controls.Add(lbRapportEvaluation);
            Name = "UC_RapportEvaluationLivre";
            Size = new Size(654, 635);
            ((System.ComponentModel.ISupportInitialize)dgvLivres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLivres;
        private Button btnAfficher;
        private ComboBox cboLivres;
        private Label lbLivresRapports;
        private Label lbRapportEvaluation;
        private Button btnRetour;
    }
}
