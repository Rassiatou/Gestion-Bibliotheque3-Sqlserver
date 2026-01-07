namespace TP3_BD
{
    partial class AuteurForm1
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
            dgvAuteur = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            lbAuteurSupp = new Label();
            txtIdAuteurSupp = new TextBox();
            lbIdAuteur = new Label();
            txtIdAuteur = new TextBox();
            lbISBN = new Label();
            btnVider = new Button();
            lbListIdAuteur = new Label();
            txtListeIdAuteur = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            txtNomAuteur = new TextBox();
            lbNom = new Label();
            lbPrenom = new Label();
            txtPrenomAuteur = new TextBox();
            txtPrenomAuteurModif = new TextBox();
            lbPrenomAuteurModif = new Label();
            lbNomAuteurModif = new Label();
            txtNomAuteurModif = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).BeginInit();
            SuspendLayout();
            // 
            // dgvAuteur
            // 
            dgvAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuteur.Location = new Point(8, 286);
            dgvAuteur.MultiSelect = false;
            dgvAuteur.Name = "dgvAuteur";
            dgvAuteur.ReadOnly = true;
            dgvAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuteur.Size = new Size(655, 183);
            dgvAuteur.TabIndex = 104;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(172, 232);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 101;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(8, 232);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 100;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbAuteurSupp
            // 
            lbAuteurSupp.AutoSize = true;
            lbAuteurSupp.Location = new Point(111, 108);
            lbAuteurSupp.Name = "lbAuteurSupp";
            lbAuteurSupp.Size = new Size(53, 15);
            lbAuteurSupp.TabIndex = 99;
            lbAuteurSupp.Text = "IdAuteur";
            // 
            // txtIdAuteurSupp
            // 
            txtIdAuteurSupp.Location = new Point(172, 105);
            txtIdAuteurSupp.Name = "txtIdAuteurSupp";
            txtIdAuteurSupp.ReadOnly = true;
            txtIdAuteurSupp.Size = new Size(100, 23);
            txtIdAuteurSupp.TabIndex = 98;
            // 
            // lbIdAuteur
            // 
            lbIdAuteur.AutoSize = true;
            lbIdAuteur.Location = new Point(111, 62);
            lbIdAuteur.Name = "lbIdAuteur";
            lbIdAuteur.Size = new Size(53, 15);
            lbIdAuteur.TabIndex = 97;
            lbIdAuteur.Text = "IdAuteur";
            // 
            // txtIdAuteur
            // 
            txtIdAuteur.Location = new Point(169, 59);
            txtIdAuteur.Name = "txtIdAuteur";
            txtIdAuteur.ReadOnly = true;
            txtIdAuteur.Size = new Size(100, 23);
            txtIdAuteur.TabIndex = 96;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(492, 14);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 15);
            lbISBN.TabIndex = 87;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(8, 161);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 85;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdAuteur
            // 
            lbListIdAuteur.AutoSize = true;
            lbListIdAuteur.Location = new Point(344, 237);
            lbListIdAuteur.Name = "lbListIdAuteur";
            lbListIdAuteur.Size = new Size(53, 15);
            lbListIdAuteur.TabIndex = 84;
            lbListIdAuteur.Text = "IdAuteur";
            // 
            // txtListeIdAuteur
            // 
            txtListeIdAuteur.Location = new Point(410, 233);
            txtListeIdAuteur.Name = "txtListeIdAuteur";
            txtListeIdAuteur.Size = new Size(100, 23);
            txtListeIdAuteur.TabIndex = 82;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(8, 101);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 80;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(787, 446);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 79;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(8, 57);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 78;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(8, 10);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 77;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtNomAuteur
            // 
            txtNomAuteur.Location = new Point(161, 10);
            txtNomAuteur.Name = "txtNomAuteur";
            txtNomAuteur.Size = new Size(100, 23);
            txtNomAuteur.TabIndex = 109;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(119, 18);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(34, 15);
            lbNom.TabIndex = 110;
            lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(344, 14);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(49, 15);
            lbPrenom.TabIndex = 111;
            lbPrenom.Text = "Prénom";
            // 
            // txtPrenomAuteur
            // 
            txtPrenomAuteur.Location = new Point(410, 11);
            txtPrenomAuteur.Name = "txtPrenomAuteur";
            txtPrenomAuteur.Size = new Size(100, 23);
            txtPrenomAuteur.TabIndex = 112;
            // 
            // txtPrenomAuteurModif
            // 
            txtPrenomAuteurModif.Location = new Point(587, 59);
            txtPrenomAuteurModif.Name = "txtPrenomAuteurModif";
            txtPrenomAuteurModif.Size = new Size(100, 23);
            txtPrenomAuteurModif.TabIndex = 117;
            // 
            // lbPrenomAuteurModif
            // 
            lbPrenomAuteurModif.AutoSize = true;
            lbPrenomAuteurModif.Location = new Point(526, 62);
            lbPrenomAuteurModif.Name = "lbPrenomAuteurModif";
            lbPrenomAuteurModif.Size = new Size(49, 15);
            lbPrenomAuteurModif.TabIndex = 116;
            lbPrenomAuteurModif.Text = "Prénom";
            // 
            // lbNomAuteurModif
            // 
            lbNomAuteurModif.AutoSize = true;
            lbNomAuteurModif.Location = new Point(315, 62);
            lbNomAuteurModif.Name = "lbNomAuteurModif";
            lbNomAuteurModif.Size = new Size(34, 15);
            lbNomAuteurModif.TabIndex = 115;
            lbNomAuteurModif.Text = "Nom";
            // 
            // txtNomAuteurModif
            // 
            txtNomAuteurModif.Location = new Point(358, 59);
            txtNomAuteurModif.Name = "txtNomAuteurModif";
            txtNomAuteurModif.Size = new Size(100, 23);
            txtNomAuteurModif.TabIndex = 114;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(687, 63);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 113;
            // 
            // AuteurForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 510);
            Controls.Add(txtPrenomAuteurModif);
            Controls.Add(lbPrenomAuteurModif);
            Controls.Add(lbNomAuteurModif);
            Controls.Add(txtNomAuteurModif);
            Controls.Add(label3);
            Controls.Add(txtPrenomAuteur);
            Controls.Add(lbPrenom);
            Controls.Add(lbNom);
            Controls.Add(txtNomAuteur);
            Controls.Add(dgvAuteur);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(lbAuteurSupp);
            Controls.Add(txtIdAuteurSupp);
            Controls.Add(lbIdAuteur);
            Controls.Add(txtIdAuteur);
            Controls.Add(lbISBN);
            Controls.Add(btnVider);
            Controls.Add(lbListIdAuteur);
            Controls.Add(txtListeIdAuteur);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Name = "AuteurForm1";
            Text = "AuteurForm1";
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvAuteur;
        private Button btnRechercher;
        private Button btnActualiser;
        private Label lbAuteurSupp;
        private TextBox txtIdAuteurSupp;
        private Label lbIdAuteur;
        private TextBox txtIdAuteur;
        private Label lbISBN;
        private Button btnVider;
        private Label lbListIdAuteur;
        private TextBox txtListeIdAuteur;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtNomAuteur;
        private Label lbNom;
        private Label lbPrenom;
        private TextBox txtPrenomAuteur;
        private TextBox txtPrenomAuteurModif;
        private Label lbPrenomAuteurModif;
        private Label lbNomAuteurModif;
        private TextBox txtNomAuteurModif;
        private Label label3;
    }
}