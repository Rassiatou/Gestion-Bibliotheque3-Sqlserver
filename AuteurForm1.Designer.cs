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
            dgvAuteur.Location = new Point(9, 381);
            dgvAuteur.Margin = new Padding(3, 4, 3, 4);
            dgvAuteur.MultiSelect = false;
            dgvAuteur.Name = "dgvAuteur";
            dgvAuteur.ReadOnly = true;
            dgvAuteur.RowHeadersWidth = 51;
            dgvAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuteur.Size = new Size(749, 244);
            dgvAuteur.TabIndex = 104;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(197, 309);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(86, 31);
            btnRechercher.TabIndex = 101;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(9, 309);
            btnActualiser.Margin = new Padding(3, 4, 3, 4);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(86, 31);
            btnActualiser.TabIndex = 100;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbAuteurSupp
            // 
            lbAuteurSupp.AutoSize = true;
            lbAuteurSupp.Location = new Point(127, 144);
            lbAuteurSupp.Name = "lbAuteurSupp";
            lbAuteurSupp.Size = new Size(66, 20);
            lbAuteurSupp.TabIndex = 99;
            lbAuteurSupp.Text = "IdAuteur";
            // 
            // txtIdAuteurSupp
            // 
            txtIdAuteurSupp.Location = new Point(197, 140);
            txtIdAuteurSupp.Margin = new Padding(3, 4, 3, 4);
            txtIdAuteurSupp.Name = "txtIdAuteurSupp";
            txtIdAuteurSupp.ReadOnly = true;
            txtIdAuteurSupp.Size = new Size(114, 27);
            txtIdAuteurSupp.TabIndex = 98;
            // 
            // lbIdAuteur
            // 
            lbIdAuteur.AutoSize = true;
            lbIdAuteur.Location = new Point(127, 83);
            lbIdAuteur.Name = "lbIdAuteur";
            lbIdAuteur.Size = new Size(66, 20);
            lbIdAuteur.TabIndex = 97;
            lbIdAuteur.Text = "IdAuteur";
            // 
            // txtIdAuteur
            // 
            txtIdAuteur.Location = new Point(193, 79);
            txtIdAuteur.Margin = new Padding(3, 4, 3, 4);
            txtIdAuteur.Name = "txtIdAuteur";
            txtIdAuteur.ReadOnly = true;
            txtIdAuteur.Size = new Size(114, 27);
            txtIdAuteur.TabIndex = 96;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(562, 19);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 20);
            lbISBN.TabIndex = 87;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(9, 215);
            btnVider.Margin = new Padding(3, 4, 3, 4);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(86, 31);
            btnVider.TabIndex = 85;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdAuteur
            // 
            lbListIdAuteur.AutoSize = true;
            lbListIdAuteur.Location = new Point(393, 316);
            lbListIdAuteur.Name = "lbListIdAuteur";
            lbListIdAuteur.Size = new Size(66, 20);
            lbListIdAuteur.TabIndex = 84;
            lbListIdAuteur.Text = "IdAuteur";
            // 
            // txtListeIdAuteur
            // 
            txtListeIdAuteur.Location = new Point(469, 311);
            txtListeIdAuteur.Margin = new Padding(3, 4, 3, 4);
            txtListeIdAuteur.Name = "txtListeIdAuteur";
            txtListeIdAuteur.Size = new Size(114, 27);
            txtListeIdAuteur.TabIndex = 82;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(9, 135);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(86, 31);
            btnSupprimer.TabIndex = 80;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(899, 595);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(86, 31);
            btnRetour.TabIndex = 79;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(9, 76);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 78;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(9, 13);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 77;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtNomAuteur
            // 
            txtNomAuteur.Location = new Point(184, 13);
            txtNomAuteur.Margin = new Padding(3, 4, 3, 4);
            txtNomAuteur.Name = "txtNomAuteur";
            txtNomAuteur.Size = new Size(114, 27);
            txtNomAuteur.TabIndex = 109;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(136, 24);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(42, 20);
            lbNom.TabIndex = 110;
            lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(393, 19);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(60, 20);
            lbPrenom.TabIndex = 111;
            lbPrenom.Text = "Prénom";
            // 
            // txtPrenomAuteur
            // 
            txtPrenomAuteur.Location = new Point(469, 15);
            txtPrenomAuteur.Margin = new Padding(3, 4, 3, 4);
            txtPrenomAuteur.Name = "txtPrenomAuteur";
            txtPrenomAuteur.Size = new Size(114, 27);
            txtPrenomAuteur.TabIndex = 112;
            // 
            // txtPrenomAuteurModif
            // 
            txtPrenomAuteurModif.Location = new Point(671, 79);
            txtPrenomAuteurModif.Margin = new Padding(3, 4, 3, 4);
            txtPrenomAuteurModif.Name = "txtPrenomAuteurModif";
            txtPrenomAuteurModif.Size = new Size(114, 27);
            txtPrenomAuteurModif.TabIndex = 117;
            // 
            // lbPrenomAuteurModif
            // 
            lbPrenomAuteurModif.AutoSize = true;
            lbPrenomAuteurModif.Location = new Point(601, 83);
            lbPrenomAuteurModif.Name = "lbPrenomAuteurModif";
            lbPrenomAuteurModif.Size = new Size(60, 20);
            lbPrenomAuteurModif.TabIndex = 116;
            lbPrenomAuteurModif.Text = "Prénom";
            // 
            // lbNomAuteurModif
            // 
            lbNomAuteurModif.AutoSize = true;
            lbNomAuteurModif.Location = new Point(360, 83);
            lbNomAuteurModif.Name = "lbNomAuteurModif";
            lbNomAuteurModif.Size = new Size(42, 20);
            lbNomAuteurModif.TabIndex = 115;
            lbNomAuteurModif.Text = "Nom";
            // 
            // txtNomAuteurModif
            // 
            txtNomAuteurModif.Location = new Point(409, 79);
            txtNomAuteurModif.Margin = new Padding(3, 4, 3, 4);
            txtNomAuteurModif.Name = "txtNomAuteurModif";
            txtNomAuteurModif.Size = new Size(114, 27);
            txtNomAuteurModif.TabIndex = 114;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(785, 84);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 113;
            // 
            // AuteurForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 680);
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
            Margin = new Padding(3, 4, 3, 4);
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