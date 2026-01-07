namespace TP3_BD
{
    partial class LivreForm1
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
            cbCategorie = new ComboBox();
            cbAuteur = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            nudQuantite = new NumericUpDown();
            dgvLivres = new DataGridView();
            cmbCategorie = new ComboBox();
            comboBox1 = new ComboBox();
            btnRechercher = new Button();
            btnActualiser = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            lbIdLivre = new Label();
            txtIdLivre = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            lbQuantité = new Label();
            lbISBN = new Label();
            txtISBN = new TextBox();
            btnVider = new Button();
            lbListIdClient = new Label();
            lbTitre = new Label();
            txtListeIdClients = new TextBox();
            txtTitre = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLivres).BeginInit();
            SuspendLayout();
            // 
            // cbCategorie
            // 
            cbCategorie.FormattingEnabled = true;
            cbCategorie.Location = new Point(918, 62);
            cbCategorie.Name = "cbCategorie";
            cbCategorie.Size = new Size(121, 23);
            cbCategorie.TabIndex = 108;
            cbCategorie.Text = "Categorie";
            // 
            // cbAuteur
            // 
            cbAuteur.FormattingEnabled = true;
            cbAuteur.Location = new Point(529, 64);
            cbAuteur.Name = "cbAuteur";
            cbAuteur.Size = new Size(121, 23);
            cbAuteur.TabIndex = 107;
            cbAuteur.Text = "Auteur";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1182, 62);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 106;
            // 
            // nudQuantite
            // 
            nudQuantite.Location = new Point(985, 12);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(120, 23);
            nudQuantite.TabIndex = 105;
            // 
            // dgvLivres
            // 
            dgvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivres.Location = new Point(10, 288);
            dgvLivres.MultiSelect = false;
            dgvLivres.Name = "dgvLivres";
            dgvLivres.ReadOnly = true;
            dgvLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivres.Size = new Size(655, 183);
            dgvLivres.TabIndex = 104;
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(701, 15);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(121, 23);
            cmbCategorie.TabIndex = 103;
            cmbCategorie.Text = "Categorie";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 102;
            comboBox1.Text = "Auteur";
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(174, 234);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 101;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(10, 234);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 100;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 110);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 99;
            label6.Text = "IdLivre";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(174, 107);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 98;
            // 
            // lbIdLivre
            // 
            lbIdLivre.AutoSize = true;
            lbIdLivre.Location = new Point(113, 64);
            lbIdLivre.Name = "lbIdLivre";
            lbIdLivre.Size = new Size(42, 15);
            lbIdLivre.TabIndex = 97;
            lbIdLivre.Text = "IdLivre";
            // 
            // txtIdLivre
            // 
            txtIdLivre.Location = new Point(163, 61);
            txtIdLivre.Name = "txtIdLivre";
            txtIdLivre.ReadOnly = true;
            txtIdLivre.Size = new Size(100, 23);
            txtIdLivre.TabIndex = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(319, 111);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 95;
            label8.Text = "ISBN";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(375, 107);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1118, 63);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 93;
            label1.Text = "Quantités";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(691, 64);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 92;
            label3.Text = "ISBN";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(747, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 64);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 90;
            label5.Text = "Titre";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(355, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 89;
            // 
            // lbQuantité
            // 
            lbQuantité.AutoSize = true;
            lbQuantité.Location = new Point(921, 15);
            lbQuantité.Name = "lbQuantité";
            lbQuantité.Size = new Size(58, 15);
            lbQuantité.TabIndex = 88;
            lbQuantité.Text = "Quantités";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(494, 16);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(32, 15);
            lbISBN.TabIndex = 87;
            lbISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(550, 12);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 86;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(10, 163);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 85;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdClient
            // 
            lbListIdClient.AutoSize = true;
            lbListIdClient.Location = new Point(346, 239);
            lbListIdClient.Name = "lbListIdClient";
            lbListIdClient.Size = new Size(48, 15);
            lbListIdClient.TabIndex = 84;
            lbListIdClient.Text = "IdClient";
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Location = new Point(121, 16);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(31, 15);
            lbTitre.TabIndex = 83;
            lbTitre.Text = "Titre";
            // 
            // txtListeIdClients
            // 
            txtListeIdClients.Location = new Point(412, 235);
            txtListeIdClients.Name = "txtListeIdClients";
            txtListeIdClients.Size = new Size(100, 23);
            txtListeIdClients.TabIndex = 82;
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(158, 12);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(100, 23);
            txtTitre.TabIndex = 81;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(10, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 80;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(1314, 448);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 79;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(10, 59);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 78;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(10, 12);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 77;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // LivreForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 527);
            Controls.Add(cbCategorie);
            Controls.Add(cbAuteur);
            Controls.Add(numericUpDown1);
            Controls.Add(nudQuantite);
            Controls.Add(dgvLivres);
            Controls.Add(cmbCategorie);
            Controls.Add(comboBox1);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(lbIdLivre);
            Controls.Add(txtIdLivre);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(lbQuantité);
            Controls.Add(lbISBN);
            Controls.Add(txtISBN);
            Controls.Add(btnVider);
            Controls.Add(lbListIdClient);
            Controls.Add(lbTitre);
            Controls.Add(txtListeIdClients);
            Controls.Add(txtTitre);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Name = "LivreForm1";
            Text = "LivreForm1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLivres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCategorie;
        private ComboBox cbAuteur;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nudQuantite;
        private DataGridView dgvLivres;
        private ComboBox cmbCategorie;
        private ComboBox comboBox1;
        private Button btnRechercher;
        private Button btnActualiser;
        private Label label6;
        private TextBox textBox6;
        private Label lbIdLivre;
        private TextBox txtIdLivre;
        private Label label8;
        private TextBox textBox8;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox5;
        private Label lbQuantité;
        private Label lbISBN;
        private TextBox txtISBN;
        private Button btnVider;
        private Label lbListIdClient;
        private Label lbTitre;
        private TextBox txtListeIdClients;
        private TextBox txtTitre;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
    }
}