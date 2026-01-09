namespace TP3_BD
{
    partial class ActiviteForm1
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
            txtIdActiviteSupp = new TextBox();
            lbIdActiviteSupp = new Label();
            lbIdActiciteModif = new Label();
            label2 = new Label();
            dgvActivite = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            txtIdActiviteModif = new TextBox();
            lbISBN = new Label();
            lbListIdActivite = new Label();
            txtListeIdActivite = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            btnVider = new Button();
            lbTitreActivite = new Label();
            txtTitreActivite = new TextBox();
            cmbTypeActivite = new ComboBox();
            dtpDateActivite = new DateTimePicker();
            nudCapaciteMax = new NumericUpDown();
            cmbEmployeOrganisateur = new ComboBox();
            cmbModifOrganisateur = new ComboBox();
            nudModifCapaciteMax = new NumericUpDown();
            dtpModifDateActivite = new DateTimePicker();
            cmbModifTypeActivite = new ComboBox();
            lbModifTitreActivite = new Label();
            txtModifTitreActivite = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnVoirParticipations = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActivite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapaciteMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudModifCapaciteMax).BeginInit();
            SuspendLayout();
            // 
            // txtIdActiviteSupp
            // 
            txtIdActiviteSupp.Location = new Point(192, 103);
            txtIdActiviteSupp.Name = "txtIdActiviteSupp";
            txtIdActiviteSupp.ReadOnly = true;
            txtIdActiviteSupp.Size = new Size(100, 23);
            txtIdActiviteSupp.TabIndex = 213;
            // 
            // lbIdActiviteSupp
            // 
            lbIdActiviteSupp.AutoSize = true;
            lbIdActiviteSupp.Location = new Point(122, 107);
            lbIdActiviteSupp.Name = "lbIdActiviteSupp";
            lbIdActiviteSupp.Size = new Size(57, 15);
            lbIdActiviteSupp.TabIndex = 212;
            lbIdActiviteSupp.Text = "IdActivite";
            // 
            // lbIdActiciteModif
            // 
            lbIdActiciteModif.AutoSize = true;
            lbIdActiciteModif.Location = new Point(122, 65);
            lbIdActiciteModif.Name = "lbIdActiciteModif";
            lbIdActiciteModif.Size = new Size(57, 15);
            lbIdActiciteModif.TabIndex = 211;
            lbIdActiciteModif.Text = "IdActivite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(713, 16);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 204;
            // 
            // dgvActivite
            // 
            dgvActivite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivite.Location = new Point(12, 288);
            dgvActivite.MultiSelect = false;
            dgvActivite.Name = "dgvActivite";
            dgvActivite.ReadOnly = true;
            dgvActivite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivite.Size = new Size(655, 183);
            dgvActivite.TabIndex = 203;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(176, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 202;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(12, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 201;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // txtIdActiviteModif
            // 
            txtIdActiviteModif.Location = new Point(192, 60);
            txtIdActiviteModif.Name = "txtIdActiviteModif";
            txtIdActiviteModif.ReadOnly = true;
            txtIdActiviteModif.Size = new Size(100, 23);
            txtIdActiviteModif.TabIndex = 200;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(496, 16);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 15);
            lbISBN.TabIndex = 199;
            // 
            // lbListIdActivite
            // 
            lbListIdActivite.AutoSize = true;
            lbListIdActivite.Location = new Point(348, 239);
            lbListIdActivite.Name = "lbListIdActivite";
            lbListIdActivite.Size = new Size(57, 15);
            lbListIdActivite.TabIndex = 198;
            lbListIdActivite.Text = "IdActivite";
            // 
            // txtListeIdActivite
            // 
            txtListeIdActivite.Location = new Point(415, 235);
            txtListeIdActivite.Name = "txtListeIdActivite";
            txtListeIdActivite.Size = new Size(100, 23);
            txtListeIdActivite.TabIndex = 197;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(12, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 196;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(1119, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 195;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(12, 59);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 194;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 12);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 193;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(12, 190);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 214;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbTitreActivite
            // 
            lbTitreActivite.AutoSize = true;
            lbTitreActivite.Location = new Point(129, 17);
            lbTitreActivite.Name = "lbTitreActivite";
            lbTitreActivite.Size = new Size(31, 15);
            lbTitreActivite.TabIndex = 216;
            lbTitreActivite.Text = "Titre";
            // 
            // txtTitreActivite
            // 
            txtTitreActivite.Location = new Point(192, 12);
            txtTitreActivite.Name = "txtTitreActivite";
            txtTitreActivite.ReadOnly = true;
            txtTitreActivite.Size = new Size(100, 23);
            txtTitreActivite.TabIndex = 215;
            // 
            // cmbTypeActivite
            // 
            cmbTypeActivite.FormattingEnabled = true;
            cmbTypeActivite.Location = new Point(336, 14);
            cmbTypeActivite.Name = "cmbTypeActivite";
            cmbTypeActivite.Size = new Size(121, 23);
            cmbTypeActivite.TabIndex = 217;
            cmbTypeActivite.Text = "Évènement";
            // 
            // dtpDateActivite
            // 
            dtpDateActivite.Location = new Point(497, 12);
            dtpDateActivite.Name = "dtpDateActivite";
            dtpDateActivite.Size = new Size(200, 23);
            dtpDateActivite.TabIndex = 218;
            // 
            // nudCapaciteMax
            // 
            nudCapaciteMax.Location = new Point(746, 12);
            nudCapaciteMax.Name = "nudCapaciteMax";
            nudCapaciteMax.Size = new Size(120, 23);
            nudCapaciteMax.TabIndex = 219;
            // 
            // cmbEmployeOrganisateur
            // 
            cmbEmployeOrganisateur.FormattingEnabled = true;
            cmbEmployeOrganisateur.Location = new Point(916, 12);
            cmbEmployeOrganisateur.Name = "cmbEmployeOrganisateur";
            cmbEmployeOrganisateur.Size = new Size(121, 23);
            cmbEmployeOrganisateur.TabIndex = 220;
            cmbEmployeOrganisateur.Text = "Organisateur";
            // 
            // cmbModifOrganisateur
            // 
            cmbModifOrganisateur.FormattingEnabled = true;
            cmbModifOrganisateur.Location = new Point(1104, 61);
            cmbModifOrganisateur.Name = "cmbModifOrganisateur";
            cmbModifOrganisateur.Size = new Size(121, 23);
            cmbModifOrganisateur.TabIndex = 228;
            cmbModifOrganisateur.Text = "Organisateur";
            // 
            // nudModifCapaciteMax
            // 
            nudModifCapaciteMax.Location = new Point(934, 61);
            nudModifCapaciteMax.Name = "nudModifCapaciteMax";
            nudModifCapaciteMax.Size = new Size(120, 23);
            nudModifCapaciteMax.TabIndex = 227;
            // 
            // dtpModifDateActivite
            // 
            dtpModifDateActivite.Location = new Point(685, 61);
            dtpModifDateActivite.Name = "dtpModifDateActivite";
            dtpModifDateActivite.Size = new Size(200, 23);
            dtpModifDateActivite.TabIndex = 226;
            // 
            // cmbModifTypeActivite
            // 
            cmbModifTypeActivite.FormattingEnabled = true;
            cmbModifTypeActivite.Location = new Point(524, 63);
            cmbModifTypeActivite.Name = "cmbModifTypeActivite";
            cmbModifTypeActivite.Size = new Size(121, 23);
            cmbModifTypeActivite.TabIndex = 225;
            cmbModifTypeActivite.Text = "Évènement";
            // 
            // lbModifTitreActivite
            // 
            lbModifTitreActivite.AutoSize = true;
            lbModifTitreActivite.Location = new Point(317, 66);
            lbModifTitreActivite.Name = "lbModifTitreActivite";
            lbModifTitreActivite.Size = new Size(31, 15);
            lbModifTitreActivite.TabIndex = 224;
            lbModifTitreActivite.Text = "Titre";
            // 
            // txtModifTitreActivite
            // 
            txtModifTitreActivite.Location = new Point(380, 61);
            txtModifTitreActivite.Name = "txtModifTitreActivite";
            txtModifTitreActivite.ReadOnly = true;
            txtModifTitreActivite.Size = new Size(100, 23);
            txtModifTitreActivite.TabIndex = 223;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(901, 65);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 222;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 65);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 221;
            // 
            // btnVoirParticipations
            // 
            btnVoirParticipations.Location = new Point(12, 147);
            btnVoirParticipations.Name = "btnVoirParticipations";
            btnVoirParticipations.Size = new Size(75, 23);
            btnVoirParticipations.TabIndex = 229;
            btnVoirParticipations.Text = "Participants";
            btnVoirParticipations.UseVisualStyleBackColor = true;
            btnVoirParticipations.Click += btnVoirParticipations_Click;
            // 
            // ActiviteForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 553);
            Controls.Add(btnVoirParticipations);
            Controls.Add(cmbModifOrganisateur);
            Controls.Add(nudModifCapaciteMax);
            Controls.Add(dtpModifDateActivite);
            Controls.Add(cmbModifTypeActivite);
            Controls.Add(lbModifTitreActivite);
            Controls.Add(txtModifTitreActivite);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cmbEmployeOrganisateur);
            Controls.Add(nudCapaciteMax);
            Controls.Add(dtpDateActivite);
            Controls.Add(cmbTypeActivite);
            Controls.Add(lbTitreActivite);
            Controls.Add(txtTitreActivite);
            Controls.Add(btnVider);
            Controls.Add(txtIdActiviteSupp);
            Controls.Add(lbIdActiviteSupp);
            Controls.Add(lbIdActiciteModif);
            Controls.Add(label2);
            Controls.Add(dgvActivite);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(txtIdActiviteModif);
            Controls.Add(lbISBN);
            Controls.Add(lbListIdActivite);
            Controls.Add(txtListeIdActivite);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Name = "ActiviteForm1";
            Text = "ActiviteForm1";
            ((System.ComponentModel.ISupportInitialize)dgvActivite).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapaciteMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudModifCapaciteMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdActiviteSupp;
        private Label lbIdActiviteSupp;
        private Label lbIdActiciteModif;
        private Label label2;
        private DataGridView dgvActivite;
        private Button btnRechercher;
        private Button btnActualiser;
        private TextBox txtIdActiviteModif;
        private Label lbISBN;
        private Label lbListIdActivite;
        private TextBox txtListeIdActivite;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnVider;
        private Label lbTitreActivite;
        private TextBox txtTitreActivite;
        private ComboBox cmbTypeActivite;
        private DateTimePicker dtpDateActivite;
        private NumericUpDown nudCapaciteMax;
        private ComboBox cmbEmployeOrganisateur;
        private ComboBox cmbModifOrganisateur;
        private NumericUpDown nudModifCapaciteMax;
        private DateTimePicker dtpModifDateActivite;
        private ComboBox cmbModifTypeActivite;
        private Label lbModifTitreActivite;
        private TextBox txtModifTitreActivite;
        private Label label3;
        private Label label4;
        private Button btnVoirParticipations;
    }
}