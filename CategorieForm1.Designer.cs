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
            txtDescriptionModif.Location = new Point(606, 56);
            txtDescriptionModif.Name = "txtDescriptionModif";
            txtDescriptionModif.Size = new Size(100, 23);
            txtDescriptionModif.TabIndex = 141;
            // 
            // lbDescriptionModif
            // 
            lbDescriptionModif.AutoSize = true;
            lbDescriptionModif.Location = new Point(534, 59);
            lbDescriptionModif.Name = "lbDescriptionModif";
            lbDescriptionModif.Size = new Size(67, 15);
            lbDescriptionModif.TabIndex = 140;
            lbDescriptionModif.Text = "Description";
            // 
            // lbNomCategorieModif
            // 
            lbNomCategorieModif.AutoSize = true;
            lbNomCategorieModif.Location = new Point(323, 59);
            lbNomCategorieModif.Name = "lbNomCategorieModif";
            lbNomCategorieModif.Size = new Size(34, 15);
            lbNomCategorieModif.TabIndex = 139;
            lbNomCategorieModif.Text = "Nom";
            // 
            // txtNomCategorieModif
            // 
            txtNomCategorieModif.Location = new Point(366, 56);
            txtNomCategorieModif.Name = "txtNomCategorieModif";
            txtNomCategorieModif.Size = new Size(100, 23);
            txtNomCategorieModif.TabIndex = 138;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 60);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 137;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(422, 8);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 136;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(352, 11);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 135;
            lbDescription.Text = "Description";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(127, 15);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(34, 15);
            lbNom.TabIndex = 134;
            lbNom.Text = "Nom";
            // 
            // txtNomCategorie
            // 
            txtNomCategorie.Location = new Point(169, 7);
            txtNomCategorie.Name = "txtNomCategorie";
            txtNomCategorie.Size = new Size(100, 23);
            txtNomCategorie.TabIndex = 133;
            // 
            // dgvCategorie
            // 
            dgvCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorie.Location = new Point(16, 283);
            dgvCategorie.MultiSelect = false;
            dgvCategorie.Name = "dgvCategorie";
            dgvCategorie.ReadOnly = true;
            dgvCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorie.Size = new Size(655, 183);
            dgvCategorie.TabIndex = 132;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(180, 229);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(75, 23);
            btnRechercher.TabIndex = 131;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(16, 229);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 130;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbCategorieSupp
            // 
            lbCategorieSupp.AutoSize = true;
            lbCategorieSupp.Location = new Point(119, 105);
            lbCategorieSupp.Name = "lbCategorieSupp";
            lbCategorieSupp.Size = new Size(68, 15);
            lbCategorieSupp.TabIndex = 129;
            lbCategorieSupp.Text = "IdCategorie";
            // 
            // txtIdCategorieSupp
            // 
            txtIdCategorieSupp.Location = new Point(194, 102);
            txtIdCategorieSupp.Name = "txtIdCategorieSupp";
            txtIdCategorieSupp.ReadOnly = true;
            txtIdCategorieSupp.Size = new Size(100, 23);
            txtIdCategorieSupp.TabIndex = 128;
            // 
            // lbIdAuteur
            // 
            lbIdAuteur.AutoSize = true;
            lbIdAuteur.Location = new Point(119, 59);
            lbIdAuteur.Name = "lbIdAuteur";
            lbIdAuteur.Size = new Size(68, 15);
            lbIdAuteur.TabIndex = 127;
            lbIdAuteur.Text = "IdCategorie";
            // 
            // txtIdCategorie
            // 
            txtIdCategorie.Location = new Point(192, 56);
            txtIdCategorie.Name = "txtIdCategorie";
            txtIdCategorie.ReadOnly = true;
            txtIdCategorie.Size = new Size(100, 23);
            txtIdCategorie.TabIndex = 126;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(500, 11);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 15);
            lbISBN.TabIndex = 125;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(16, 158);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 124;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdCategorie
            // 
            lbListIdCategorie.AutoSize = true;
            lbListIdCategorie.Location = new Point(352, 234);
            lbListIdCategorie.Name = "lbListIdCategorie";
            lbListIdCategorie.Size = new Size(68, 15);
            lbListIdCategorie.TabIndex = 123;
            lbListIdCategorie.Text = "IdCategorie";
            // 
            // txtListeIdCategorie
            // 
            txtListeIdCategorie.Location = new Point(424, 230);
            txtListeIdCategorie.Name = "txtListeIdCategorie";
            txtListeIdCategorie.Size = new Size(100, 23);
            txtListeIdCategorie.TabIndex = 122;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(16, 98);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 121;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(795, 443);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 120;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(16, 54);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 119;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(16, 7);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 118;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // CategorieForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 500);
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