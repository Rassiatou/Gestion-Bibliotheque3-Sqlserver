namespace TP3_BD
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLivre = new Button();
            btnAuteur = new Button();
            btnCategorie = new Button();
            btnUsager = new Button();
            btnEmprunt = new Button();
            btnActivité = new Button();
            btnParticipation = new Button();
            btnMatériel = new Button();
            btnEmpruntMatériel = new Button();
            btnEmployé = new Button();
            btnÉvaluation = new Button();
            btnRapports = new Button();
            SuspendLayout();
            // 
            // btnLivre
            // 
            btnLivre.Location = new Point(132, 121);
            btnLivre.Name = "btnLivre";
            btnLivre.Size = new Size(75, 23);
            btnLivre.TabIndex = 0;
            btnLivre.Text = "Livre";
            btnLivre.UseVisualStyleBackColor = true;
            btnLivre.Click += btnLivre_Click;
            // 
            // btnAuteur
            // 
            btnAuteur.Location = new Point(226, 121);
            btnAuteur.Name = "btnAuteur";
            btnAuteur.Size = new Size(75, 23);
            btnAuteur.TabIndex = 1;
            btnAuteur.Text = "Auteur";
            btnAuteur.UseVisualStyleBackColor = true;
            btnAuteur.Click += btnAuteur_Click;
            // 
            // btnCategorie
            // 
            btnCategorie.Location = new Point(319, 121);
            btnCategorie.Name = "btnCategorie";
            btnCategorie.Size = new Size(75, 23);
            btnCategorie.TabIndex = 2;
            btnCategorie.Text = "Catégorie";
            btnCategorie.UseVisualStyleBackColor = true;
            btnCategorie.Click += btnCategorie_Click;
            // 
            // btnUsager
            // 
            btnUsager.Location = new Point(411, 121);
            btnUsager.Name = "btnUsager";
            btnUsager.Size = new Size(75, 23);
            btnUsager.TabIndex = 3;
            btnUsager.Text = "Usager";
            btnUsager.UseVisualStyleBackColor = true;
            btnUsager.Click += btnUsager_Click;
            // 
            // btnEmprunt
            // 
            btnEmprunt.Location = new Point(501, 121);
            btnEmprunt.Name = "btnEmprunt";
            btnEmprunt.Size = new Size(75, 23);
            btnEmprunt.TabIndex = 4;
            btnEmprunt.Text = "Emprunt";
            btnEmprunt.UseVisualStyleBackColor = true;
            btnEmprunt.Click += btnEmprunt_Click;
            // 
            // btnActivité
            // 
            btnActivité.Location = new Point(592, 121);
            btnActivité.Name = "btnActivité";
            btnActivité.Size = new Size(75, 23);
            btnActivité.TabIndex = 5;
            btnActivité.Text = "Activité";
            btnActivité.UseVisualStyleBackColor = true;
            btnActivité.Click += btnActivité_Click;
            // 
            // btnParticipation
            // 
            btnParticipation.Location = new Point(155, 174);
            btnParticipation.Name = "btnParticipation";
            btnParticipation.Size = new Size(92, 23);
            btnParticipation.TabIndex = 6;
            btnParticipation.Text = "Participation";
            btnParticipation.UseVisualStyleBackColor = true;
            btnParticipation.Click += btnParticipation_Click;
            // 
            // btnMatériel
            // 
            btnMatériel.Location = new Point(269, 174);
            btnMatériel.Name = "btnMatériel";
            btnMatériel.Size = new Size(75, 23);
            btnMatériel.TabIndex = 7;
            btnMatériel.Text = "Matériel";
            btnMatériel.UseVisualStyleBackColor = true;
            btnMatériel.Click += btnMatériel_Click;
            // 
            // btnEmpruntMatériel
            // 
            btnEmpruntMatériel.Location = new Point(363, 174);
            btnEmpruntMatériel.Name = "btnEmpruntMatériel";
            btnEmpruntMatériel.Size = new Size(125, 23);
            btnEmpruntMatériel.TabIndex = 8;
            btnEmpruntMatériel.Text = "EmpruntMatériel";
            btnEmpruntMatériel.UseVisualStyleBackColor = true;
            btnEmpruntMatériel.Click += btnEmpruntMatériel_Click;
            // 
            // btnEmployé
            // 
            btnEmployé.Location = new Point(512, 174);
            btnEmployé.Name = "btnEmployé";
            btnEmployé.Size = new Size(75, 23);
            btnEmployé.TabIndex = 9;
            btnEmployé.Text = "Employé";
            btnEmployé.UseVisualStyleBackColor = true;
            btnEmployé.Click += btnEmployé_Click;
            // 
            // btnÉvaluation
            // 
            btnÉvaluation.Location = new Point(607, 174);
            btnÉvaluation.Name = "btnÉvaluation";
            btnÉvaluation.Size = new Size(75, 23);
            btnÉvaluation.TabIndex = 10;
            btnÉvaluation.Text = "Évaluation";
            btnÉvaluation.UseVisualStyleBackColor = true;
            btnÉvaluation.Click += btnÉvaluation_Click;
            // 
            // btnRapports
            // 
            btnRapports.Location = new Point(349, 225);
            btnRapports.Name = "btnRapports";
            btnRapports.Size = new Size(75, 23);
            btnRapports.TabIndex = 11;
            btnRapports.Text = "Rapports";
            btnRapports.UseVisualStyleBackColor = true;
            btnRapports.Click += btnRapports_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRapports);
            Controls.Add(btnÉvaluation);
            Controls.Add(btnEmployé);
            Controls.Add(btnEmpruntMatériel);
            Controls.Add(btnMatériel);
            Controls.Add(btnParticipation);
            Controls.Add(btnActivité);
            Controls.Add(btnEmprunt);
            Controls.Add(btnUsager);
            Controls.Add(btnCategorie);
            Controls.Add(btnAuteur);
            Controls.Add(btnLivre);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLivre;
        private Button btnAuteur;
        private Button btnCategorie;
        private Button btnUsager;
        private Button btnEmprunt;
        private Button btnActivité;
        private Button btnParticipation;
        private Button btnMatériel;
        private Button btnEmpruntMatériel;
        private Button btnEmployé;
        private Button btnÉvaluation;
        private Button btnRapports;
    }
}
