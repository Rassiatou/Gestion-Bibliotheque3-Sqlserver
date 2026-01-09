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
            dgvAuteur = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).BeginInit();
            SuspendLayout();
            // 
            // txtPrenomEmployeModif
            // 
            txtPrenomEmployeModif.Location = new Point(590, 61);
            txtPrenomEmployeModif.Name = "txtPrenomEmployeModif";
            txtPrenomEmployeModif.Size = new Size(100, 23);
            txtPrenomEmployeModif.TabIndex = 141;
            // 
            // lbPrenomEmployeModif
            // 
            lbPrenomEmployeModif.AutoSize = true;
            lbPrenomEmployeModif.Location = new Point(529, 64);
            lbPrenomEmployeModif.Name = "lbPrenomEmployeModif";
            lbPrenomEmployeModif.Size = new Size(49, 15);
            lbPrenomEmployeModif.TabIndex = 140;
            lbPrenomEmployeModif.Text = "Prénom";
            // 
            // lbNomEmployeModif
            // 
            lbNomEmployeModif.AutoSize = true;
            lbNomEmployeModif.Location = new Point(318, 64);
            lbNomEmployeModif.Name = "lbNomEmployeModif";
            lbNomEmployeModif.Size = new Size(34, 15);
            lbNomEmployeModif.TabIndex = 139;
            lbNomEmployeModif.Text = "Nom";
            // 
            // txtNomEmployeModif
            // 
            txtNomEmployeModif.Location = new Point(361, 61);
            txtNomEmployeModif.Name = "txtNomEmployeModif";
            txtNomEmployeModif.Size = new Size(100, 23);
            txtNomEmployeModif.TabIndex = 138;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(690, 65);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 137;
            // 
            // txtPrenomEmploye
            // 
            txtPrenomEmploye.Location = new Point(413, 13);
            txtPrenomEmploye.Name = "txtPrenomEmploye";
            txtPrenomEmploye.Size = new Size(100, 23);
            txtPrenomEmploye.TabIndex = 136;
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(347, 16);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(49, 15);
            lbPrenom.TabIndex = 135;
            lbPrenom.Text = "Prénom";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(122, 17);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(34, 15);
            lbNom.TabIndex = 134;
            lbNom.Text = "Nom";
            // 
            // txtNomEmploye
            // 
            txtNomEmploye.Location = new Point(164, 12);
            txtNomEmploye.Name = "txtNomEmploye";
            txtNomEmploye.Size = new Size(100, 23);
            txtNomEmploye.TabIndex = 133;
            // 
            // dgvAuteur
            // 
            dgvAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuteur.Location = new Point(11, 288);
            dgvAuteur.MultiSelect = false;
            dgvAuteur.Name = "dgvAuteur";
            dgvAuteur.ReadOnly = true;
            dgvAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuteur.Size = new Size(655, 183);
            dgvAuteur.TabIndex = 132;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(175, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 131;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(11, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 130;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbEmployeSupp
            // 
            lbEmployeSupp.AutoSize = true;
            lbEmployeSupp.Location = new Point(114, 110);
            lbEmployeSupp.Name = "lbEmployeSupp";
            lbEmployeSupp.Size = new Size(63, 15);
            lbEmployeSupp.TabIndex = 129;
            lbEmployeSupp.Text = "IdEmploye";
            // 
            // txtIdEmployeSupp
            // 
            txtIdEmployeSupp.Location = new Point(182, 107);
            txtIdEmployeSupp.Name = "txtIdEmployeSupp";
            txtIdEmployeSupp.ReadOnly = true;
            txtIdEmployeSupp.Size = new Size(100, 23);
            txtIdEmployeSupp.TabIndex = 128;
            // 
            // lbIdEmploye
            // 
            lbIdEmploye.AutoSize = true;
            lbIdEmploye.Location = new Point(114, 64);
            lbIdEmploye.Name = "lbIdEmploye";
            lbIdEmploye.Size = new Size(63, 15);
            lbIdEmploye.TabIndex = 127;
            lbIdEmploye.Text = "IdEmploye";
            // 
            // txtIdEmploye
            // 
            txtIdEmploye.Location = new Point(180, 61);
            txtIdEmploye.Name = "txtIdEmploye";
            txtIdEmploye.ReadOnly = true;
            txtIdEmploye.Size = new Size(100, 23);
            txtIdEmploye.TabIndex = 126;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(495, 16);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 15);
            lbISBN.TabIndex = 125;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(11, 163);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 124;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdEmploye
            // 
            lbListIdEmploye.AutoSize = true;
            lbListIdEmploye.Location = new Point(347, 239);
            lbListIdEmploye.Name = "lbListIdEmploye";
            lbListIdEmploye.Size = new Size(63, 15);
            lbListIdEmploye.TabIndex = 123;
            lbListIdEmploye.Text = "IdEmploye";
            // 
            // txtListeIdEmploye
            // 
            txtListeIdEmploye.Location = new Point(415, 235);
            txtListeIdEmploye.Name = "txtListeIdEmploye";
            txtListeIdEmploye.Size = new Size(100, 23);
            txtListeIdEmploye.TabIndex = 122;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(11, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 121;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(790, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 120;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(11, 59);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 119;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(11, 12);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 118;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(569, 13);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 142;
            cmbRole.Text = "Role";
            // 
            // cmbRoleModif
            // 
            cmbRoleModif.FormattingEnabled = true;
            cmbRoleModif.Location = new Point(733, 63);
            cmbRoleModif.Name = "cmbRoleModif";
            cmbRoleModif.Size = new Size(121, 23);
            cmbRoleModif.TabIndex = 143;
            cmbRoleModif.Text = "Role";
            // 
            // EmployeForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 523);
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
            Controls.Add(dgvAuteur);
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
            Name = "EmployeForm1";
            Text = "EmployeForm1";
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).EndInit();
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
        private DataGridView dgvAuteur;
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