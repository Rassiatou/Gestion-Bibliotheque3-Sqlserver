namespace TP3_BD
{
    partial class EmployeForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrenomEmployeModif = new TextBox();
            lbPrenomEmployeModif = new Label();
            lbNomEmployeModif = new Label();
            txtNomEmployeModif = new TextBox();
            label3 = new Label();
            txtPrenomEmploye = new TextBox();
            lbPrenom = new Label();
            lbNom = new Label();
            txtNomEmploye = new TextBox();
            dgvEmployes = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            lbEmployeSupp = new Label();
            txtIdEmployeSupp = new TextBox();
            lbIdEmploye = new Label();
            txtIdEmploye = new TextBox();
            lbISBN = new Label();
            btnVider = new Button();
            lbListIdEmploye = new Label();
            txtListeIdEmploye = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            cmbRole = new ComboBox();
            cmbRoleModif = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).BeginInit();
            SuspendLayout();
            // 
            // txtPrenomEmployeModif
            // 
            txtPrenomEmployeModif.Location = new Point(674, 81);
            txtPrenomEmployeModif.Margin = new Padding(3, 4, 3, 4);
            txtPrenomEmployeModif.Name = "txtPrenomEmployeModif";
            txtPrenomEmployeModif.Size = new Size(114, 27);
            txtPrenomEmployeModif.TabIndex = 141;
            // 
            // lbPrenomEmployeModif
            // 
            lbPrenomEmployeModif.AutoSize = true;
            lbPrenomEmployeModif.Location = new Point(605, 85);
            lbPrenomEmployeModif.Name = "lbPrenomEmployeModif";
            lbPrenomEmployeModif.Size = new Size(60, 20);
            lbPrenomEmployeModif.TabIndex = 140;
            lbPrenomEmployeModif.Text = "Prénom";
            // 
            // lbNomEmployeModif
            // 
            lbNomEmployeModif.AutoSize = true;
            lbNomEmployeModif.Location = new Point(363, 85);
            lbNomEmployeModif.Name = "lbNomEmployeModif";
            lbNomEmployeModif.Size = new Size(42, 20);
            lbNomEmployeModif.TabIndex = 139;
            lbNomEmployeModif.Text = "Nom";
            // 
            // txtNomEmployeModif
            // 
            txtNomEmployeModif.Location = new Point(413, 81);
            txtNomEmployeModif.Margin = new Padding(3, 4, 3, 4);
            txtNomEmployeModif.Name = "txtNomEmployeModif";
            txtNomEmployeModif.Size = new Size(114, 27);
            txtNomEmployeModif.TabIndex = 138;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(789, 87);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 137;
            // 
            // txtPrenomEmploye
            // 
            txtPrenomEmploye.Location = new Point(472, 17);
            txtPrenomEmploye.Margin = new Padding(3, 4, 3, 4);
            txtPrenomEmploye.Name = "txtPrenomEmploye";
            txtPrenomEmploye.Size = new Size(114, 27);
            txtPrenomEmploye.TabIndex = 136;
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(397, 21);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(60, 20);
            lbPrenom.TabIndex = 135;
            lbPrenom.Text = "Prénom";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(139, 23);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(42, 20);
            lbNom.TabIndex = 134;
            lbNom.Text = "Nom";
            // 
            // txtNomEmploye
            // 
            txtNomEmploye.Location = new Point(187, 17);
            txtNomEmploye.Margin = new Padding(3, 4, 3, 4);
            txtNomEmploye.Name = "txtNomEmploye";
            txtNomEmploye.Size = new Size(114, 27);
            txtNomEmploye.TabIndex = 133;
            // 
            // dgvEmployes
            // 
            dgvEmployes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployes.Location = new Point(13, 384);
            dgvEmployes.Margin = new Padding(3, 4, 3, 4);
            dgvEmployes.MultiSelect = false;
            dgvEmployes.Name = "dgvEmployes";
            dgvEmployes.ReadOnly = true;
            dgvEmployes.RowHeadersWidth = 51;
            dgvEmployes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployes.Size = new Size(749, 244);
            dgvEmployes.TabIndex = 132;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(200, 312);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(86, 31);
            btnRechercher.TabIndex = 131;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(13, 312);
            btnActualiser.Margin = new Padding(3, 4, 3, 4);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(86, 31);
            btnActualiser.TabIndex = 130;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbEmployeSupp
            // 
            lbEmployeSupp.AutoSize = true;
            lbEmployeSupp.Location = new Point(130, 147);
            lbEmployeSupp.Name = "lbEmployeSupp";
            lbEmployeSupp.Size = new Size(80, 20);
            lbEmployeSupp.TabIndex = 129;
            lbEmployeSupp.Text = "IdEmploye";
            // 
            // txtIdEmployeSupp
            // 
            txtIdEmployeSupp.Location = new Point(208, 143);
            txtIdEmployeSupp.Margin = new Padding(3, 4, 3, 4);
            txtIdEmployeSupp.Name = "txtIdEmployeSupp";
            txtIdEmployeSupp.ReadOnly = true;
            txtIdEmployeSupp.Size = new Size(114, 27);
            txtIdEmployeSupp.TabIndex = 128;
            // 
            // lbIdEmploye
            // 
            lbIdEmploye.AutoSize = true;
            lbIdEmploye.Location = new Point(130, 85);
            lbIdEmploye.Name = "lbIdEmploye";
            lbIdEmploye.Size = new Size(80, 20);
            lbIdEmploye.TabIndex = 127;
            lbIdEmploye.Text = "IdEmploye";
            // 
            // txtIdEmploye
            // 
            txtIdEmploye.Location = new Point(206, 81);
            txtIdEmploye.Margin = new Padding(3, 4, 3, 4);
            txtIdEmploye.Name = "txtIdEmploye";
            txtIdEmploye.ReadOnly = true;
            txtIdEmploye.Size = new Size(114, 27);
            txtIdEmploye.TabIndex = 126;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(566, 21);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 20);
            lbISBN.TabIndex = 125;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(13, 217);
            btnVider.Margin = new Padding(3, 4, 3, 4);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(86, 31);
            btnVider.TabIndex = 124;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdEmploye
            // 
            lbListIdEmploye.AutoSize = true;
            lbListIdEmploye.Location = new Point(397, 319);
            lbListIdEmploye.Name = "lbListIdEmploye";
            lbListIdEmploye.Size = new Size(80, 20);
            lbListIdEmploye.TabIndex = 123;
            lbListIdEmploye.Text = "IdEmploye";
            // 
            // txtListeIdEmploye
            // 
            txtListeIdEmploye.Location = new Point(474, 313);
            txtListeIdEmploye.Margin = new Padding(3, 4, 3, 4);
            txtListeIdEmploye.Name = "txtListeIdEmploye";
            txtListeIdEmploye.Size = new Size(114, 27);
            txtListeIdEmploye.TabIndex = 122;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(13, 137);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(86, 31);
            btnSupprimer.TabIndex = 121;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(903, 597);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(86, 31);
            btnRetour.TabIndex = 120;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(13, 79);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 119;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(13, 16);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 118;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(650, 17);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(138, 28);
            cmbRole.TabIndex = 142;
            cmbRole.Text = "Role";
            // 
            // cmbRoleModif
            // 
            cmbRoleModif.FormattingEnabled = true;
            cmbRoleModif.Location = new Point(838, 84);
            cmbRoleModif.Margin = new Padding(3, 4, 3, 4);
            cmbRoleModif.Name = "cmbRoleModif";
            cmbRoleModif.Size = new Size(138, 28);
            cmbRoleModif.TabIndex = 143;
            cmbRoleModif.Text = "Role";
            // 
            // EmployeForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 697);
            Controls.Add(cmbRoleModif);
            Controls.Add(cmbRole);
            Controls.Add(txtPrenomEmployeModif);
            Controls.Add(lbPrenomEmployeModif);
            Controls.Add(lbNomEmployeModif);
            Controls.Add(txtNomEmployeModif);
            Controls.Add(label3);
            Controls.Add(txtPrenomEmploye);
            Controls.Add(lbPrenom);
            Controls.Add(lbNom);
            Controls.Add(txtNomEmploye);
            Controls.Add(dgvEmployes);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(lbEmployeSupp);
            Controls.Add(txtIdEmployeSupp);
            Controls.Add(lbIdEmploye);
            Controls.Add(txtIdEmploye);
            Controls.Add(lbISBN);
            Controls.Add(btnVider);
            Controls.Add(lbListIdEmploye);
            Controls.Add(txtListeIdEmploye);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeForm1";
            Text = "EmployeForm1";
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrenomEmployeModif;
        private Label lbPrenomEmployeModif;
        private Label lbNomEmployeModif;
        private TextBox txtNomEmployeModif;
        private Label label3;
        private TextBox txtPrenomEmploye;
        private Label lbPrenom;
        private Label lbNom;
        private TextBox txtNomEmploye;
        private DataGridView dgvEmployes;
        private Button btnRechercher;
        private Button btnActualiser;
        private Label lbEmployeSupp;
        private TextBox txtIdEmployeSupp;
        private Label lbIdEmploye;
        private TextBox txtIdEmploye;
        private Label lbISBN;
        private Button btnVider;
        private Label lbListIdEmploye;
        private TextBox txtListeIdEmploye;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
        private ComboBox cmbRole;
        private ComboBox cmbRoleModif;
    }
}