namespace TP3_BD
{
    partial class ParticipationForm1
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
            lbIdParticipationRetirer = new Label();
            dtpDateInscription = new DateTimePicker();
            cmbUsager = new ComboBox();
            cmbActivite = new ComboBox();
            label2 = new Label();
            dgvParticipation = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            txtIdParticipationRetirer = new TextBox();
            lbISBN = new Label();
            this.lbListIdParticipation = new Label();
            txtListeIdParticipation = new TextBox();
            btnRetour = new Button();
            btnRetourner = new Button();
            btnInscrire = new Button();
            chkPresence = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvParticipation).BeginInit();
            SuspendLayout();
            // 
            // lbIdParticipationRetirer
            // 
            lbIdParticipationRetirer.AutoSize = true;
            lbIdParticipationRetirer.Location = new Point(118, 65);
            lbIdParticipationRetirer.Name = "lbIdParticipationRetirer";
            lbIdParticipationRetirer.Size = new Size(84, 15);
            lbIdParticipationRetirer.TabIndex = 210;
            lbIdParticipationRetirer.Text = "IdParticipation";
            // 
            // dtpDateInscription
            // 
            dtpDateInscription.Location = new Point(463, 12);
            dtpDateInscription.Name = "dtpDateInscription";
            dtpDateInscription.Size = new Size(200, 23);
            dtpDateInscription.TabIndex = 207;
            // 
            // cmbUsager
            // 
            cmbUsager.FormattingEnabled = true;
            cmbUsager.Location = new Point(301, 12);
            cmbUsager.Name = "cmbUsager";
            cmbUsager.Size = new Size(121, 23);
            cmbUsager.TabIndex = 206;
            cmbUsager.Text = "Usager";
            // 
            // cmbActivite
            // 
            cmbActivite.FormattingEnabled = true;
            cmbActivite.Location = new Point(139, 12);
            cmbActivite.Name = "cmbActivite";
            cmbActivite.Size = new Size(121, 23);
            cmbActivite.TabIndex = 205;
            cmbActivite.Text = "Activite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 16);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 204;
            // 
            // dgvParticipation
            // 
            dgvParticipation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipation.Location = new Point(8, 288);
            dgvParticipation.MultiSelect = false;
            dgvParticipation.Name = "dgvParticipation";
            dgvParticipation.ReadOnly = true;
            dgvParticipation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipation.Size = new Size(655, 183);
            dgvParticipation.TabIndex = 203;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(172, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 202;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(8, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 201;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // txtIdParticipationRetirer
            // 
            txtIdParticipationRetirer.Location = new Point(212, 60);
            txtIdParticipationRetirer.Name = "txtIdParticipationRetirer";
            txtIdParticipationRetirer.ReadOnly = true;
            txtIdParticipationRetirer.Size = new Size(100, 23);
            txtIdParticipationRetirer.TabIndex = 200;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(492, 16);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 15);
            lbISBN.TabIndex = 199;
            // 
            // lbListIdParticipation
            // 
            this.lbListIdParticipation.AutoSize = true;
            this.lbListIdParticipation.Location = new Point(344, 239);
            this.lbListIdParticipation.Name = "lbListIdParticipation";
            this.lbListIdParticipation.Size = new Size(84, 15);
            this.lbListIdParticipation.TabIndex = 198;
            this.lbListIdParticipation.Text = "IdParticipation";
            // 
            // txtListeIdParticipation
            // 
            txtListeIdParticipation.Location = new Point(435, 235);
            txtListeIdParticipation.Name = "txtListeIdParticipation";
            txtListeIdParticipation.Size = new Size(100, 23);
            txtListeIdParticipation.TabIndex = 197;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(787, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 195;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnRetourner
            // 
            btnRetourner.Location = new Point(8, 59);
            btnRetourner.Name = "btnRetourner";
            btnRetourner.Size = new Size(75, 23);
            btnRetourner.TabIndex = 194;
            btnRetourner.Text = "Retirer";
            btnRetourner.UseVisualStyleBackColor = true;
            btnRetourner.Click += btnRetourner_Click;
            // 
            // btnInscrire
            // 
            btnInscrire.Location = new Point(8, 12);
            btnInscrire.Name = "btnInscrire";
            btnInscrire.Size = new Size(75, 23);
            btnInscrire.TabIndex = 193;
            btnInscrire.Text = "Inscrire";
            btnInscrire.UseVisualStyleBackColor = true;
            btnInscrire.Click += btnInscrire_Click;
            // 
            // chkPresence
            // 
            chkPresence.AutoSize = true;
            chkPresence.Location = new Point(715, 15);
            chkPresence.Name = "chkPresence";
            chkPresence.Size = new Size(73, 19);
            chkPresence.TabIndex = 211;
            chkPresence.Text = "Presence";
            chkPresence.UseVisualStyleBackColor = true;
            // 
            // ParticipationForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 541);
            Controls.Add(chkPresence);
            Controls.Add(lbIdParticipationRetirer);
            Controls.Add(dtpDateInscription);
            Controls.Add(cmbUsager);
            Controls.Add(cmbActivite);
            Controls.Add(label2);
            Controls.Add(dgvParticipation);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(txtIdParticipationRetirer);
            Controls.Add(lbISBN);
            Controls.Add(this.lbListIdParticipation);
            Controls.Add(txtListeIdParticipation);
            Controls.Add(btnRetour);
            Controls.Add(btnRetourner);
            Controls.Add(btnInscrire);
            Name = "ParticipationForm1";
            Text = "ParticipationForm1";
            ((System.ComponentModel.ISupportInitialize)dgvParticipation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdEmpruntSupp;
        private Label lbIdEmpruntSupp;
        private Label lbIdParticipationRetirer;
        private DateTimePicker dtpDateRetourReel;
        private DateTimePicker dtpDateInscription;
        private ComboBox cmbUsager;
        private ComboBox cmbActivite;
        private Label label2;
        private DataGridView dgvParticipation;
        private Button btnRechercher;
        private Button btnActualiser;
        private TextBox txtIdParticipationRetirer;
        private Label lbISBN;
        private Label lbListIdEmprunt;
        private TextBox txtListeIdParticipation;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnRetourner;
        private Button btnInscrire;
        private CheckBox chkPresence;
    }
}