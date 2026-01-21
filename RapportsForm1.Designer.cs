namespace TP3_BD
{
    partial class RapportsForm1
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
            btnRapportEmpruntUsager = new Button();
            btnRapportParticipants = new Button();
            btnRapportEvaluationLivre = new Button();
            panelContent = new Panel();
            panelTop = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnRapportEmpruntUsager
            // 
            btnRapportEmpruntUsager.Location = new Point(11, 17);
            btnRapportEmpruntUsager.Name = "btnRapportEmpruntUsager";
            btnRapportEmpruntUsager.Size = new Size(187, 23);
            btnRapportEmpruntUsager.TabIndex = 0;
            btnRapportEmpruntUsager.Text = "Rapport Emprunt d'un Usager";
            btnRapportEmpruntUsager.UseVisualStyleBackColor = true;
            btnRapportEmpruntUsager.Click += btnRapportEmpruntUsager_Click;
            // 
            // btnRapportParticipants
            // 
            btnRapportParticipants.Location = new Point(226, 17);
            btnRapportParticipants.Name = "btnRapportParticipants";
            btnRapportParticipants.Size = new Size(139, 23);
            btnRapportParticipants.TabIndex = 1;
            btnRapportParticipants.Text = "Rapport Participants";
            btnRapportParticipants.UseVisualStyleBackColor = true;
            btnRapportParticipants.Click += btnRapportParticipants_Click;
            // 
            // btnRapportEvaluationLivre
            // 
            btnRapportEvaluationLivre.Location = new Point(386, 17);
            btnRapportEvaluationLivre.Name = "btnRapportEvaluationLivre";
            btnRapportEvaluationLivre.Size = new Size(184, 23);
            btnRapportEvaluationLivre.TabIndex = 2;
            btnRapportEvaluationLivre.Text = "Rapport Evaluation Des Livres";
            btnRapportEvaluationLivre.UseVisualStyleBackColor = true;
            btnRapportEvaluationLivre.Click += btnRapportEvaluationLivre_Click;
            // 
            // panelContent
            // 
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Dock = DockStyle.Bottom;
            panelContent.Location = new Point(0, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 400);
            panelContent.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnRapportEmpruntUsager);
            panelTop.Controls.Add(btnRapportEvaluationLivre);
            panelTop.Controls.Add(btnRapportParticipants);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 50);
            panelTop.TabIndex = 0;
            // 
            // RapportsForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTop);
            Controls.Add(panelContent);
            Name = "RapportsForm1";
            Text = "RapportsForm1";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRapportEmpruntUsager;
        private Button btnRapportParticipants;
        private Button btnRapportEvaluationLivre;
        private Panel panelContent;
        private Panel panelTop;
    }
}