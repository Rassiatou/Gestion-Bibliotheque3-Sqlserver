namespace TP3_BD
{
    partial class MaterielForm1
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
            txtIdMaterielSupp = new TextBox();
            lbIdMaterielSupp = new Label();
            lbIdMaterielRetour = new Label();
            dgvMateriel = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            txtIdMaterielRetour = new TextBox();
            lbListIdMateriel = new Label();
            txtListeIdMateriel = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            btnVider = new Button();
            lbNom = new Label();
            txtNomMateriel = new TextBox();
            cmbTypeMateriel = new ComboBox();
            cmbEtat = new ComboBox();
            cmbModifEtat = new ComboBox();
            cmbModifTypeMateriel = new ComboBox();
            txtModifNom = new TextBox();
            lbNomModif = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMateriel).BeginInit();
            SuspendLayout();
            // 
            // txtIdMaterielSupp
            // 
            txtIdMaterielSupp.Location = new Point(189, 103);
            txtIdMaterielSupp.Name = "txtIdMaterielSupp";
            txtIdMaterielSupp.ReadOnly = true;
            txtIdMaterielSupp.Size = new Size(100, 23);
            txtIdMaterielSupp.TabIndex = 212;
            // 
            // lbIdMaterielSupp
            // 
            lbIdMaterielSupp.AutoSize = true;
            lbIdMaterielSupp.Location = new Point(119, 107);
            lbIdMaterielSupp.Name = "lbIdMaterielSupp";
            lbIdMaterielSupp.Size = new Size(60, 15);
            lbIdMaterielSupp.TabIndex = 211;
            lbIdMaterielSupp.Text = "IdMateriel";
            // 
            // lbIdMaterielRetour
            // 
            lbIdMaterielRetour.AutoSize = true;
            lbIdMaterielRetour.Location = new Point(119, 65);
            lbIdMaterielRetour.Name = "lbIdMaterielRetour";
            lbIdMaterielRetour.Size = new Size(60, 15);
            lbIdMaterielRetour.TabIndex = 210;
            lbIdMaterielRetour.Text = "IdMateriel";
            // 
            // dgvMateriel
            // 
            dgvMateriel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriel.Location = new Point(9, 288);
            dgvMateriel.MultiSelect = false;
            dgvMateriel.Name = "dgvMateriel";
            dgvMateriel.ReadOnly = true;
            dgvMateriel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriel.Size = new Size(655, 183);
            dgvMateriel.TabIndex = 203;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(173, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 202;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(9, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 201;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // txtIdMaterielRetour
            // 
            txtIdMaterielRetour.Location = new Point(189, 60);
            txtIdMaterielRetour.Name = "txtIdMaterielRetour";
            txtIdMaterielRetour.ReadOnly = true;
            txtIdMaterielRetour.Size = new Size(100, 23);
            txtIdMaterielRetour.TabIndex = 200;
            // 
            // lbListIdMateriel
            // 
            lbListIdMateriel.AutoSize = true;
            lbListIdMateriel.Location = new Point(345, 239);
            lbListIdMateriel.Name = "lbListIdMateriel";
            lbListIdMateriel.Size = new Size(60, 15);
            lbListIdMateriel.TabIndex = 198;
            lbListIdMateriel.Text = "IdMateriel";
            // 
            // txtListeIdMateriel
            // 
            txtListeIdMateriel.Location = new Point(412, 235);
            txtListeIdMateriel.Name = "txtListeIdMateriel";
            txtListeIdMateriel.Size = new Size(100, 23);
            txtListeIdMateriel.TabIndex = 197;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(9, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 196;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(788, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 195;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(9, 59);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 194;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnRetourner_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(9, 12);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 193;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(9, 152);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 213;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(131, 16);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(34, 15);
            lbNom.TabIndex = 214;
            lbNom.Text = "Nom";
            // 
            // txtNomMateriel
            // 
            txtNomMateriel.Location = new Point(185, 12);
            txtNomMateriel.Name = "txtNomMateriel";
            txtNomMateriel.Size = new Size(100, 23);
            txtNomMateriel.TabIndex = 215;
            // 
            // cmbTypeMateriel
            // 
            cmbTypeMateriel.FormattingEnabled = true;
            cmbTypeMateriel.Location = new Point(323, 13);
            cmbTypeMateriel.Name = "cmbTypeMateriel";
            cmbTypeMateriel.Size = new Size(121, 23);
            cmbTypeMateriel.TabIndex = 216;
            cmbTypeMateriel.Text = "Materiel";
            // 
            // cmbEtat
            // 
            cmbEtat.FormattingEnabled = true;
            cmbEtat.Location = new Point(477, 13);
            cmbEtat.Name = "cmbEtat";
            cmbEtat.Size = new Size(121, 23);
            cmbEtat.TabIndex = 219;
            cmbEtat.Text = "Etat";
            // 
            // cmbModifEtat
            // 
            cmbModifEtat.FormattingEnabled = true;
            cmbModifEtat.Location = new Point(671, 63);
            cmbModifEtat.Name = "cmbModifEtat";
            cmbModifEtat.Size = new Size(121, 23);
            cmbModifEtat.TabIndex = 223;
            cmbModifEtat.Text = "Etat";
            // 
            // cmbModifTypeMateriel
            // 
            cmbModifTypeMateriel.FormattingEnabled = true;
            cmbModifTypeMateriel.Location = new Point(517, 63);
            cmbModifTypeMateriel.Name = "cmbModifTypeMateriel";
            cmbModifTypeMateriel.Size = new Size(121, 23);
            cmbModifTypeMateriel.TabIndex = 222;
            cmbModifTypeMateriel.Text = "Materiel";
            // 
            // txtModifNom
            // 
            txtModifNom.Location = new Point(379, 62);
            txtModifNom.Name = "txtModifNom";
            txtModifNom.Size = new Size(100, 23);
            txtModifNom.TabIndex = 221;
            // 
            // lbNomModif
            // 
            lbNomModif.AutoSize = true;
            lbNomModif.Location = new Point(325, 66);
            lbNomModif.Name = "lbNomModif";
            lbNomModif.Size = new Size(34, 15);
            lbNomModif.TabIndex = 220;
            lbNomModif.Text = "Nom";
            // 
            // MaterielForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 526);
            Controls.Add(cmbModifEtat);
            Controls.Add(cmbModifTypeMateriel);
            Controls.Add(txtModifNom);
            Controls.Add(lbNomModif);
            Controls.Add(cmbEtat);
            Controls.Add(cmbTypeMateriel);
            Controls.Add(txtNomMateriel);
            Controls.Add(lbNom);
            Controls.Add(btnVider);
            Controls.Add(txtIdMaterielSupp);
            Controls.Add(lbIdMaterielSupp);
            Controls.Add(lbIdMaterielRetour);
            Controls.Add(dgvMateriel);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(txtIdMaterielRetour);
            Controls.Add(lbListIdMateriel);
            Controls.Add(txtListeIdMateriel);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Name = "MaterielForm1";
            Text = "MaterielForm1";
            ((System.ComponentModel.ISupportInitialize)dgvMateriel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdMaterielSupp;
        private Label lbIdMaterielSupp;
        private Label lbIdMaterielRetour;
        private DataGridView dgvMateriel;
        private Button btnRechercher;
        private Button btnActualiser;
        private TextBox txtIdMaterielRetour;
        private Label lbListIdMateriel;
        private TextBox txtListeIdMateriel;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnVider;
        private Label lbNom;
        private TextBox txtNomMateriel;
        private ComboBox cmbTypeMateriel;
        private ComboBox cmbEtat;
        private ComboBox cmbModifEtat;
        private ComboBox cmbModifTypeMateriel;
        private TextBox txtModifNom;
        private Label lbNomModif;
    }
}