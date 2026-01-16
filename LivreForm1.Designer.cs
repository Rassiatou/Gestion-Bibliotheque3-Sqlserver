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
            textAnnée = new TextBox();
            lbAnnée = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLivres).BeginInit();
            SuspendLayout();
            // 
            // cbCategorie
            // 
            cbCategorie.FormattingEnabled = true;
            cbCategorie.Location = new Point(1049, 83);
            cbCategorie.Margin = new Padding(3, 4, 3, 4);
            cbCategorie.Name = "cbCategorie";
            cbCategorie.Size = new Size(138, 28);
            cbCategorie.TabIndex = 108;
            cbCategorie.Text = "Categorie";
            // 
            // cbAuteur
            // 
            cbAuteur.FormattingEnabled = true;
            cbAuteur.Location = new Point(605, 85);
            cbAuteur.Margin = new Padding(3, 4, 3, 4);
            cbAuteur.Name = "cbAuteur";
            cbAuteur.Size = new Size(138, 28);
            cbAuteur.TabIndex = 107;
            cbAuteur.Text = "Auteur";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1351, 83);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 106;
            // 
            // nudQuantite
            // 
            nudQuantite.Location = new Point(1351, 14);
            nudQuantite.Margin = new Padding(3, 4, 3, 4);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(137, 27);
            nudQuantite.TabIndex = 105;
            // 
            // dgvLivres
            // 
            dgvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivres.Location = new Point(11, 384);
            dgvLivres.Margin = new Padding(3, 4, 3, 4);
            dgvLivres.MultiSelect = false;
            dgvLivres.Name = "dgvLivres";
            dgvLivres.ReadOnly = true;
            dgvLivres.RowHeadersWidth = 51;
            dgvLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivres.Size = new Size(749, 244);
            dgvLivres.TabIndex = 104;
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(1049, 11);
            cmbCategorie.Margin = new Padding(3, 4, 3, 4);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(138, 28);
            cmbCategorie.TabIndex = 103;
            cmbCategorie.Text = "Categorie";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(393, 19);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 102;
            comboBox1.Text = "Auteur";
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(199, 312);
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
            btnActualiser.Location = new Point(11, 312);
            btnActualiser.Margin = new Padding(3, 4, 3, 4);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(86, 31);
            btnActualiser.TabIndex = 100;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 147);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 99;
            label6.Text = "IdLivre";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(199, 143);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 98;
            // 
            // lbIdLivre
            // 
            lbIdLivre.AutoSize = true;
            lbIdLivre.Location = new Point(129, 85);
            lbIdLivre.Name = "lbIdLivre";
            lbIdLivre.Size = new Size(53, 20);
            lbIdLivre.TabIndex = 97;
            lbIdLivre.Text = "IdLivre";
            // 
            // txtIdLivre
            // 
            txtIdLivre.Location = new Point(186, 81);
            txtIdLivre.Margin = new Padding(3, 4, 3, 4);
            txtIdLivre.Name = "txtIdLivre";
            txtIdLivre.ReadOnly = true;
            txtIdLivre.Size = new Size(114, 27);
            txtIdLivre.TabIndex = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(365, 148);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 95;
            label8.Text = "ISBN";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(429, 143);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(114, 27);
            textBox8.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1278, 84);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 93;
            label1.Text = "Quantités";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 85);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 92;
            label3.Text = "ISBN";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(854, 80);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 85);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 90;
            label5.Text = "Titre";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(406, 80);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 89;
            // 
            // lbQuantité
            // 
            lbQuantité.AutoSize = true;
            lbQuantité.Location = new Point(1273, 19);
            lbQuantité.Name = "lbQuantité";
            lbQuantité.Size = new Size(72, 20);
            lbQuantité.TabIndex = 88;
            lbQuantité.Text = "Quantités";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(565, 21);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(41, 20);
            lbISBN.TabIndex = 87;
            lbISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(629, 16);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(114, 27);
            txtISBN.TabIndex = 86;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(11, 217);
            btnVider.Margin = new Padding(3, 4, 3, 4);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(86, 31);
            btnVider.TabIndex = 85;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdClient
            // 
            lbListIdClient.AutoSize = true;
            lbListIdClient.Location = new Point(395, 319);
            lbListIdClient.Name = "lbListIdClient";
            lbListIdClient.Size = new Size(53, 20);
            lbListIdClient.TabIndex = 84;
            lbListIdClient.Text = "IdLivre";
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Location = new Point(138, 21);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(39, 20);
            lbTitre.TabIndex = 83;
            lbTitre.Text = "Titre";
            // 
            // txtListeIdClients
            // 
            txtListeIdClients.Location = new Point(471, 313);
            txtListeIdClients.Margin = new Padding(3, 4, 3, 4);
            txtListeIdClients.Name = "txtListeIdClients";
            txtListeIdClients.Size = new Size(114, 27);
            txtListeIdClients.TabIndex = 82;
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(181, 16);
            txtTitre.Margin = new Padding(3, 4, 3, 4);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(114, 27);
            txtTitre.TabIndex = 81;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(11, 137);
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
            btnRetour.Location = new Point(1502, 597);
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
            btnModifier.Location = new Point(11, 79);
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
            btnAjouter.Location = new Point(11, 16);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 77;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // textAnnée
            // 
            textAnnée.Location = new Point(894, 16);
            textAnnée.Margin = new Padding(3, 4, 3, 4);
            textAnnée.Name = "textAnnée";
            textAnnée.Size = new Size(114, 27);
            textAnnée.TabIndex = 109;
            // 
            // lbAnnée
            // 
            lbAnnée.AutoSize = true;
            lbAnnée.Location = new Point(804, 22);
            lbAnnée.Name = "lbAnnée";
            lbAnnée.Size = new Size(51, 20);
            lbAnnée.TabIndex = 110;
            lbAnnée.Text = "Année";
            // 
            // LivreForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 703);
            Controls.Add(lbAnnée);
            Controls.Add(textAnnée);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textAnnée;
        private Label lbAnnée;
        //private Label lbAnnée;
    }
}