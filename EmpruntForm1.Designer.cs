namespace TP3_BD
{
    partial class EmpruntForm1
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
            label2 = new Label();
            dgvEmprunt = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            txtIdEmpruntRetour = new TextBox();
            lbISBN = new Label();
            lbListIdEmprunt = new Label();
            txtListeIdEmprunt = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnRetourner = new Button();
            btnAjouter = new Button();
            cmbUsager = new ComboBox();
            cmbLivre = new ComboBox();
            dtpDateEmprunt = new DateTimePicker();
            dtpRetourPrevu = new DateTimePicker();
            dtpDateRetourReel = new DateTimePicker();
            lbIdEmpruntRetour = new Label();
            lbIdEmpruntSupp = new Label();
            txtIdEmpruntSupp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunt).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 16);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 178;
            // 
            // dgvEmprunt
            // 
            dgvEmprunt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunt.Location = new Point(8, 288);
            dgvEmprunt.MultiSelect = false;
            dgvEmprunt.Name = "dgvEmprunt";
            dgvEmprunt.ReadOnly = true;
            dgvEmprunt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmprunt.Size = new Size(655, 183);
            dgvEmprunt.TabIndex = 168;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(172, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 167;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(8, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 166;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // txtIdEmpruntRetour
            // 
            txtIdEmpruntRetour.Location = new Point(188, 60);
            txtIdEmpruntRetour.Name = "txtIdEmpruntRetour";
            txtIdEmpruntRetour.ReadOnly = true;
            txtIdEmpruntRetour.Size = new Size(100, 23);
            txtIdEmpruntRetour.TabIndex = 162;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(492, 16);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 15);
            lbISBN.TabIndex = 161;
            // 
            // lbListIdEmprunt
            // 
            lbListIdEmprunt.AutoSize = true;
            lbListIdEmprunt.Location = new Point(344, 239);
            lbListIdEmprunt.Name = "lbListIdEmprunt";
            lbListIdEmprunt.Size = new Size(63, 15);
            lbListIdEmprunt.TabIndex = 159;
            lbListIdEmprunt.Text = "IdEmprunt";
            // 
            // txtListeIdEmprunt
            // 
            txtListeIdEmprunt.Location = new Point(411, 235);
            txtListeIdEmprunt.Name = "txtListeIdEmprunt";
            txtListeIdEmprunt.Size = new Size(100, 23);
            txtListeIdEmprunt.TabIndex = 158;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(8, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 157;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(787, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 156;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click_1;
            // 
            // btnRetourner
            // 
            btnRetourner.Location = new Point(8, 59);
            btnRetourner.Name = "btnRetourner";
            btnRetourner.Size = new Size(75, 23);
            btnRetourner.TabIndex = 155;
            btnRetourner.Text = "Retourner";
            btnRetourner.UseVisualStyleBackColor = true;
            btnRetourner.Click += btnRetourner_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(8, 12);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 154;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cmbUsager
            // 
            cmbUsager.FormattingEnabled = true;
            cmbUsager.Location = new Point(139, 12);
            cmbUsager.Name = "cmbUsager";
            cmbUsager.Size = new Size(121, 23);
            cmbUsager.TabIndex = 184;
            cmbUsager.Text = "Usager";
            // 
            // cmbLivre
            // 
            cmbLivre.FormattingEnabled = true;
            cmbLivre.Location = new Point(301, 12);
            cmbLivre.Name = "cmbLivre";
            cmbLivre.Size = new Size(121, 23);
            cmbLivre.TabIndex = 185;
            cmbLivre.Text = "Livre";
            // 
            // dtpDateEmprunt
            // 
            dtpDateEmprunt.Location = new Point(463, 12);
            dtpDateEmprunt.Name = "dtpDateEmprunt";
            dtpDateEmprunt.Size = new Size(200, 23);
            dtpDateEmprunt.TabIndex = 186;
            // 
            // dtpRetourPrevu
            // 
            dtpRetourPrevu.Location = new Point(709, 12);
            dtpRetourPrevu.Name = "dtpRetourPrevu";
            dtpRetourPrevu.Size = new Size(200, 23);
            dtpRetourPrevu.TabIndex = 187;
            // 
            // dtpDateRetourReel
            // 
            dtpDateRetourReel.Location = new Point(375, 61);
            dtpDateRetourReel.Name = "dtpDateRetourReel";
            dtpDateRetourReel.Size = new Size(200, 23);
            dtpDateRetourReel.TabIndex = 189;
            // 
            // lbIdEmpruntRetour
            // 
            lbIdEmpruntRetour.AutoSize = true;
            lbIdEmpruntRetour.Location = new Point(118, 65);
            lbIdEmpruntRetour.Name = "lbIdEmpruntRetour";
            lbIdEmpruntRetour.Size = new Size(63, 15);
            lbIdEmpruntRetour.TabIndex = 190;
            lbIdEmpruntRetour.Text = "IdEmprunt";
            // 
            // lbIdEmpruntSupp
            // 
            lbIdEmpruntSupp.AutoSize = true;
            lbIdEmpruntSupp.Location = new Point(118, 107);
            lbIdEmpruntSupp.Name = "lbIdEmpruntSupp";
            lbIdEmpruntSupp.Size = new Size(63, 15);
            lbIdEmpruntSupp.TabIndex = 191;
            lbIdEmpruntSupp.Text = "IdEmprunt";
            // 
            // txtIdEmpruntSupp
            // 
            txtIdEmpruntSupp.Location = new Point(188, 103);
            txtIdEmpruntSupp.Name = "txtIdEmpruntSupp";
            txtIdEmpruntSupp.ReadOnly = true;
            txtIdEmpruntSupp.Size = new Size(100, 23);
            txtIdEmpruntSupp.TabIndex = 192;
            // 
            // EmpruntForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 517);
            Controls.Add(txtIdEmpruntSupp);
            Controls.Add(lbIdEmpruntSupp);
            Controls.Add(lbIdEmpruntRetour);
            Controls.Add(dtpDateRetourReel);
            Controls.Add(dtpRetourPrevu);
            Controls.Add(dtpDateEmprunt);
            Controls.Add(cmbLivre);
            Controls.Add(cmbUsager);
            Controls.Add(label2);
            Controls.Add(dgvEmprunt);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(txtIdEmpruntRetour);
            Controls.Add(lbISBN);
            Controls.Add(lbListIdEmprunt);
            Controls.Add(txtListeIdEmprunt);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnRetourner);
            Controls.Add(btnAjouter);
            Name = "EmpruntForm1";
            Text = "EmpruntForm1";
            ((System.ComponentModel.ISupportInitialize)dgvEmprunt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvEmprunt;
        private Button btnRechercher;
        private Button btnActualiser;
        private TextBox txtIdEmpruntRetour;
        private Label lbISBN;
        private Label lbListIdEmprunt;
        private TextBox txtListeIdEmprunt;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnRetourner;
        private Button btnAjouter;
        private ComboBox cmbUsager;
        private ComboBox cmbLivre;
        private DateTimePicker dtpDateEmprunt;
        private DateTimePicker dtpRetourPrevu;
        private DateTimePicker dtpDateRetourReel;
        private Label lbIdEmpruntRetour;
        private Label lbIdEmpruntSupp;
        private TextBox txtIdEmpruntSupp;
    }
}