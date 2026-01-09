namespace TP3_BD
{
    partial class EmpruntMaterielForm1
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
            cmbEtat = new ComboBox();
            cmbMateriel = new ComboBox();
            btnVider = new Button();
            txtIdEmpruntMaterielSupp = new TextBox();
            lbIdEmpruntMaterielSupp = new Label();
            lbIdEmpruntMaterielRetour = new Label();
            dgvEmpruntMateriel = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            txtIdEmpruntMaterielRetour = new TextBox();
            lbListIdEmpruntMateriel = new Label();
            txtListeIdEmpruntMateriel = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnRetourner = new Button();
            btnPreter = new Button();
            cmbUsager = new ComboBox();
            dtpDatePret = new DateTimePicker();
            dtpRetourPrevu = new DateTimePicker();
            dtpRetourReel = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEmpruntMateriel).BeginInit();
            SuspendLayout();
            // 
            // cmbEtat
            // 
            cmbEtat.FormattingEnabled = true;
            cmbEtat.Location = new Point(907, 13);
            cmbEtat.Name = "cmbEtat";
            cmbEtat.Size = new Size(121, 23);
            cmbEtat.TabIndex = 241;
            cmbEtat.Text = "Etat";
            // 
            // cmbMateriel
            // 
            cmbMateriel.FormattingEnabled = true;
            cmbMateriel.Location = new Point(290, 13);
            cmbMateriel.Name = "cmbMateriel";
            cmbMateriel.Size = new Size(121, 23);
            cmbMateriel.TabIndex = 238;
            cmbMateriel.Text = "Materiel";
            // 
            // btnVider
            // 
            btnVider.Location = new Point(7, 152);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 235;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // txtIdEmpruntMaterielSupp
            // 
            txtIdEmpruntMaterielSupp.Location = new Point(236, 103);
            txtIdEmpruntMaterielSupp.Name = "txtIdEmpruntMaterielSupp";
            txtIdEmpruntMaterielSupp.ReadOnly = true;
            txtIdEmpruntMaterielSupp.Size = new Size(100, 23);
            txtIdEmpruntMaterielSupp.TabIndex = 234;
            // 
            // lbIdEmpruntMaterielSupp
            // 
            lbIdEmpruntMaterielSupp.AutoSize = true;
            lbIdEmpruntMaterielSupp.Location = new Point(117, 107);
            lbIdEmpruntMaterielSupp.Name = "lbIdEmpruntMaterielSupp";
            lbIdEmpruntMaterielSupp.Size = new Size(106, 15);
            lbIdEmpruntMaterielSupp.TabIndex = 233;
            lbIdEmpruntMaterielSupp.Text = "IdEmpruntMateriel";
            // 
            // lbIdEmpruntMaterielRetour
            // 
            lbIdEmpruntMaterielRetour.AutoSize = true;
            lbIdEmpruntMaterielRetour.Location = new Point(117, 65);
            lbIdEmpruntMaterielRetour.Name = "lbIdEmpruntMaterielRetour";
            lbIdEmpruntMaterielRetour.Size = new Size(106, 15);
            lbIdEmpruntMaterielRetour.TabIndex = 232;
            lbIdEmpruntMaterielRetour.Text = "IdEmpruntMateriel";
            // 
            // dgvEmpruntMateriel
            // 
            dgvEmpruntMateriel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpruntMateriel.Location = new Point(7, 288);
            dgvEmpruntMateriel.MultiSelect = false;
            dgvEmpruntMateriel.Name = "dgvEmpruntMateriel";
            dgvEmpruntMateriel.ReadOnly = true;
            dgvEmpruntMateriel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpruntMateriel.Size = new Size(655, 183);
            dgvEmpruntMateriel.TabIndex = 230;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(171, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 229;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(7, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 228;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // txtIdEmpruntMaterielRetour
            // 
            txtIdEmpruntMaterielRetour.Location = new Point(234, 60);
            txtIdEmpruntMaterielRetour.Name = "txtIdEmpruntMaterielRetour";
            txtIdEmpruntMaterielRetour.ReadOnly = true;
            txtIdEmpruntMaterielRetour.Size = new Size(100, 23);
            txtIdEmpruntMaterielRetour.TabIndex = 227;
            // 
            // lbListIdEmpruntMateriel
            // 
            lbListIdEmpruntMateriel.AutoSize = true;
            lbListIdEmpruntMateriel.Location = new Point(343, 239);
            lbListIdEmpruntMateriel.Name = "lbListIdEmpruntMateriel";
            lbListIdEmpruntMateriel.Size = new Size(106, 15);
            lbListIdEmpruntMateriel.TabIndex = 225;
            lbListIdEmpruntMateriel.Text = "IdEmpruntMateriel";
            // 
            // txtListeIdEmpruntMateriel
            // 
            txtListeIdEmpruntMateriel.Location = new Point(460, 235);
            txtListeIdEmpruntMateriel.Name = "txtListeIdEmpruntMateriel";
            txtListeIdEmpruntMateriel.Size = new Size(100, 23);
            txtListeIdEmpruntMateriel.TabIndex = 224;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(7, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 223;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(786, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 222;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnRetourner
            // 
            btnRetourner.Location = new Point(7, 59);
            btnRetourner.Name = "btnRetourner";
            btnRetourner.Size = new Size(75, 23);
            btnRetourner.TabIndex = 221;
            btnRetourner.Text = "Retourner";
            btnRetourner.UseVisualStyleBackColor = true;
            btnRetourner.Click += btnRetourner_Click;
            // 
            // btnPreter
            // 
            btnPreter.Location = new Point(7, 12);
            btnPreter.Name = "btnPreter";
            btnPreter.Size = new Size(75, 23);
            btnPreter.TabIndex = 220;
            btnPreter.Text = "Preter";
            btnPreter.UseVisualStyleBackColor = true;
            btnPreter.Click += btnPreter_Click;
            // 
            // cmbUsager
            // 
            cmbUsager.FormattingEnabled = true;
            cmbUsager.Location = new Point(119, 13);
            cmbUsager.Name = "cmbUsager";
            cmbUsager.Size = new Size(121, 23);
            cmbUsager.TabIndex = 242;
            cmbUsager.Text = "Usager";
            // 
            // dtpDatePret
            // 
            dtpDatePret.Location = new Point(444, 12);
            dtpDatePret.Name = "dtpDatePret";
            dtpDatePret.Size = new Size(200, 23);
            dtpDatePret.TabIndex = 243;
            // 
            // dtpRetourPrevu
            // 
            dtpRetourPrevu.Location = new Point(674, 13);
            dtpRetourPrevu.Name = "dtpRetourPrevu";
            dtpRetourPrevu.Size = new Size(200, 23);
            dtpRetourPrevu.TabIndex = 244;
            // 
            // dtpRetourReel
            // 
            dtpRetourReel.Location = new Point(401, 60);
            dtpRetourReel.Name = "dtpRetourReel";
            dtpRetourReel.Size = new Size(200, 23);
            dtpRetourReel.TabIndex = 245;
            // 
            // EmpruntMaterielForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 523);
            Controls.Add(dtpRetourReel);
            Controls.Add(dtpRetourPrevu);
            Controls.Add(dtpDatePret);
            Controls.Add(cmbUsager);
            Controls.Add(cmbEtat);
            Controls.Add(cmbMateriel);
            Controls.Add(btnVider);
            Controls.Add(txtIdEmpruntMaterielSupp);
            Controls.Add(lbIdEmpruntMaterielSupp);
            Controls.Add(lbIdEmpruntMaterielRetour);
            Controls.Add(dgvEmpruntMateriel);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(txtIdEmpruntMaterielRetour);
            Controls.Add(lbListIdEmpruntMateriel);
            Controls.Add(txtListeIdEmpruntMateriel);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnRetourner);
            Controls.Add(btnPreter);
            Name = "EmpruntMaterielForm1";
            Text = "EmpruntMaterielForm1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpruntMateriel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEtat;
        private ComboBox cmbMateriel;
        private Button btnVider;
        private TextBox txtIdEmpruntMaterielSupp;
        private Label lbIdEmpruntMaterielSupp;
        private Label lbIdEmpruntMaterielRetour;
        private DataGridView dgvEmpruntMateriel;
        private Button btnRechercher;
        private Button btnActualiser;
        private TextBox txtIdEmpruntMaterielRetour;
        private Label lbListIdEmpruntMateriel;
        private TextBox txtListeIdEmpruntMateriel;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnRetourner;
        private Button btnPreter;
        private ComboBox cmbUsager;
        private DateTimePicker dtpDatePret;
        private DateTimePicker dtpRetourPrevu;
        private DateTimePicker dtpRetourReel;
    }
}