namespace TP3_BD
{
    partial class CategorieForm1
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
            txtDescriptionModif = new TextBox();
            lbDescriptionModif = new Label();
            lbNomCategorieModif = new Label();
            txtNomCategorieModif = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            lbDescription = new Label();
            lbNom = new Label();
            txtNomCategorie = new TextBox();
            dgvCategorie = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            lbCategorieSupp = new Label();
            txtIdCategorieSupp = new TextBox();
            lbIdAuteur = new Label();
            txtIdCategorie = new TextBox();
            lbISBN = new Label();
            btnVider = new Button();
            lbListIdCategorie = new Label();
            txtListeIdCategorie = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorie).BeginInit();
            SuspendLayout();
            // 
            // txtDescriptionModif
            // 
            txtDescriptionModif.Location = new Point(693, 75);
            txtDescriptionModif.Margin = new Padding(3, 4, 3, 4);
            txtDescriptionModif.Name = "txtDescriptionModif";
            txtDescriptionModif.Size = new Size(114, 27);
            txtDescriptionModif.TabIndex = 141;
            // 
            // lbDescriptionModif
            // 
            lbDescriptionModif.AutoSize = true;
            lbDescriptionModif.Location = new Point(610, 79);
            lbDescriptionModif.Name = "lbDescriptionModif";
            lbDescriptionModif.Size = new Size(85, 20);
            lbDescriptionModif.TabIndex = 140;
            lbDescriptionModif.Text = "Description";
            // 
            // lbNomCategorieModif
            // 
            lbNomCategorieModif.AutoSize = true;
            lbNomCategorieModif.Location = new Point(369, 79);
            lbNomCategorieModif.Name = "lbNomCategorieModif";
            lbNomCategorieModif.Size = new Size(42, 20);
            lbNomCategorieModif.TabIndex = 139;
            lbNomCategorieModif.Text = "Nom";
            // 
            // txtNomCategorieModif
            // 
            txtNomCategorieModif.Location = new Point(418, 75);
            txtNomCategorieModif.Margin = new Padding(3, 4, 3, 4);
            txtNomCategorieModif.Name = "txtNomCategorieModif";
            txtNomCategorieModif.Size = new Size(114, 27);
            txtNomCategorieModif.TabIndex = 138;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(794, 80);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 137;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(482, 11);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(114, 27);
            txtDescription.TabIndex = 136;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(402, 15);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 135;
            lbDescription.Text = "Description";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(145, 20);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(42, 20);
            lbNom.TabIndex = 134;
            lbNom.Text = "Nom";
            // 
            // txtNomCategorie
            // 
            txtNomCategorie.Location = new Point(193, 9);
            txtNomCategorie.Margin = new Padding(3, 4, 3, 4);
            txtNomCategorie.Name = "txtNomCategorie";
            txtNomCategorie.Size = new Size(114, 27);
            txtNomCategorie.TabIndex = 133;
            // 
            // dgvCategorie
            // 
            dgvCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorie.Location = new Point(18, 377);
            dgvCategorie.Margin = new Padding(3, 4, 3, 4);
            dgvCategorie.MultiSelect = false;
            dgvCategorie.Name = "dgvCategorie";
            dgvCategorie.ReadOnly = true;
            dgvCategorie.RowHeadersWidth = 51;
            dgvCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorie.Size = new Size(749, 244);
            dgvCategorie.TabIndex = 132;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(206, 305);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(86, 31);
            btnRechercher.TabIndex = 131;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(18, 305);
            btnActualiser.Margin = new Padding(3, 4, 3, 4);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(86, 31);
            btnActualiser.TabIndex = 130;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbCategorieSupp
            // 
            lbCategorieSupp.AutoSize = true;
            lbCategorieSupp.Location = new Point(136, 140);
            lbCategorieSupp.Name = "lbCategorieSupp";
            lbCategorieSupp.Size = new Size(87, 20);
            lbCategorieSupp.TabIndex = 129;
            lbCategorieSupp.Text = "IdCategorie";
            // 
            // txtIdCategorieSupp
            // 
            txtIdCategorieSupp.Location = new Point(222, 136);
            txtIdCategorieSupp.Margin = new Padding(3, 4, 3, 4);
            txtIdCategorieSupp.Name = "txtIdCategorieSupp";
            txtIdCategorieSupp.ReadOnly = true;
            txtIdCategorieSupp.Size = new Size(114, 27);
            txtIdCategorieSupp.TabIndex = 128;
            // 
            // lbIdAuteur
            // 
            lbIdAuteur.AutoSize = true;
            lbIdAuteur.Location = new Point(136, 79);
            lbIdAuteur.Name = "lbIdAuteur";
            lbIdAuteur.Size = new Size(87, 20);
            lbIdAuteur.TabIndex = 127;
            lbIdAuteur.Text = "IdCategorie";
            // 
            // txtIdCategorie
            // 
            txtIdCategorie.Location = new Point(219, 75);
            txtIdCategorie.Margin = new Padding(3, 4, 3, 4);
            txtIdCategorie.Name = "txtIdCategorie";
            txtIdCategorie.ReadOnly = true;
            txtIdCategorie.Size = new Size(114, 27);
            txtIdCategorie.TabIndex = 126;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(571, 15);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 20);
            lbISBN.TabIndex = 125;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(18, 211);
            btnVider.Margin = new Padding(3, 4, 3, 4);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(86, 31);
            btnVider.TabIndex = 124;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdCategorie
            // 
            lbListIdCategorie.AutoSize = true;
            lbListIdCategorie.Location = new Point(402, 312);
            lbListIdCategorie.Name = "lbListIdCategorie";
            lbListIdCategorie.Size = new Size(87, 20);
            lbListIdCategorie.TabIndex = 123;
            lbListIdCategorie.Text = "IdCategorie";
            // 
            // txtListeIdCategorie
            // 
            txtListeIdCategorie.Location = new Point(485, 307);
            txtListeIdCategorie.Margin = new Padding(3, 4, 3, 4);
            txtListeIdCategorie.Name = "txtListeIdCategorie";
            txtListeIdCategorie.Size = new Size(114, 27);
            txtListeIdCategorie.TabIndex = 122;
            txtListeIdCategorie.TextChanged += txtListeIdCategorie_TextChanged;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(18, 131);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(86, 31);
            btnSupprimer.TabIndex = 121;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(909, 591);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(86, 31);
            btnRetour.TabIndex = 120;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(18, 72);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 119;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(18, 9);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 118;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // CategorieForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 667);
            Controls.Add(txtDescriptionModif);
            Controls.Add(lbDescriptionModif);
            Controls.Add(lbNomCategorieModif);
            Controls.Add(txtNomCategorieModif);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(lbDescription);
            Controls.Add(lbNom);
            Controls.Add(txtNomCategorie);
            Controls.Add(dgvCategorie);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(lbCategorieSupp);
            Controls.Add(txtIdCategorieSupp);
            Controls.Add(lbIdAuteur);
            Controls.Add(txtIdCategorie);
            Controls.Add(lbISBN);
            Controls.Add(btnVider);
            Controls.Add(lbListIdCategorie);
            Controls.Add(txtListeIdCategorie);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategorieForm1";
            Text = "CategorieForm1";
            ((System.ComponentModel.ISupportInitialize)dgvCategorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescriptionModif;
        private Label lbDescriptionModif;
        private Label lbNomCategorieModif;
        private TextBox txtNomCategorieModif;
        private Label label3;
        private TextBox txtDescription;
        private Label lbDescription;
        private Label lbNom;
        private TextBox txtNomCategorie;
        private DataGridView dgvCategorie;
        private Button btnRechercher;
        private Button btnActualiser;
        private Label lbCategorieSupp;
        private TextBox txtIdCategorieSupp;
        private Label lbIdAuteur;
        private TextBox txtIdCategorie;
        private Label lbISBN;
        private Button btnVider;
        private Label lbListIdCategorie;
        private TextBox txtListeIdCategorie;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
    }
}