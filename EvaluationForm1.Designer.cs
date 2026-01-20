namespace TP3_BD
{
    partial class EvaluationForm1
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
            dtpDateEvaluation = new DateTimePicker();
            cmbUsager = new ComboBox();
            cmbLivre = new ComboBox();
            btnVider = new Button();
            txtIdEvaluationSupp = new TextBox();
            lbIdEvaluationSupp = new Label();
            lbIdEvaluation = new Label();
            dgvEvaluation = new DataGridView();
            btnActualiser = new Button();
            txtIdEvaluation = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            nudNote = new NumericUpDown();
            txtCommentaire = new TextBox();
            lbCommentaire = new Label();
            lbCommentaireModif = new Label();
            txtCommentaireModif = new TextBox();
            nudNoteModif = new NumericUpDown();
            lbNote = new Label();
            lbNoteModif = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoteModif).BeginInit();
            SuspendLayout();
            // 
            // dtpDateEvaluation
            // 
            dtpDateEvaluation.Location = new Point(935, 12);
            dtpDateEvaluation.Name = "dtpDateEvaluation";
            dtpDateEvaluation.Size = new Size(167, 23);
            dtpDateEvaluation.TabIndex = 263;
            // 
            // cmbUsager
            // 
            cmbUsager.FormattingEnabled = true;
            cmbUsager.Location = new Point(119, 12);
            cmbUsager.Name = "cmbUsager";
            cmbUsager.Size = new Size(121, 23);
            cmbUsager.TabIndex = 261;
            cmbUsager.Text = "Usager";
            // 
            // cmbLivre
            // 
            cmbLivre.FormattingEnabled = true;
            cmbLivre.Location = new Point(290, 12);
            cmbLivre.Name = "cmbLivre";
            cmbLivre.Size = new Size(121, 23);
            cmbLivre.TabIndex = 260;
            cmbLivre.Text = "Livre";
            // 
            // btnVider
            // 
            btnVider.Location = new Point(7, 151);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(75, 23);
            btnVider.TabIndex = 259;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // txtIdEvaluationSupp
            // 
            txtIdEvaluationSupp.Location = new Point(203, 102);
            txtIdEvaluationSupp.Name = "txtIdEvaluationSupp";
            txtIdEvaluationSupp.ReadOnly = true;
            txtIdEvaluationSupp.Size = new Size(100, 23);
            txtIdEvaluationSupp.TabIndex = 258;
            // 
            // lbIdEvaluationSupp
            // 
            lbIdEvaluationSupp.AutoSize = true;
            lbIdEvaluationSupp.Location = new Point(117, 106);
            lbIdEvaluationSupp.Name = "lbIdEvaluationSupp";
            lbIdEvaluationSupp.Size = new Size(72, 15);
            lbIdEvaluationSupp.TabIndex = 257;
            lbIdEvaluationSupp.Text = "IdEvaluation";
            // 
            // lbIdEvaluation
            // 
            lbIdEvaluation.AutoSize = true;
            lbIdEvaluation.Location = new Point(117, 64);
            lbIdEvaluation.Name = "lbIdEvaluation";
            lbIdEvaluation.Size = new Size(72, 15);
            lbIdEvaluation.TabIndex = 256;
            lbIdEvaluation.Text = "IdEvaluation";
            // 
            // dgvEvaluation
            // 
            dgvEvaluation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluation.Location = new Point(7, 287);
            dgvEvaluation.MultiSelect = false;
            dgvEvaluation.Name = "dgvEvaluation";
            dgvEvaluation.ReadOnly = true;
            dgvEvaluation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluation.Size = new Size(655, 183);
            dgvEvaluation.TabIndex = 255;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(7, 233);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(75, 23);
            btnActualiser.TabIndex = 253;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // txtIdEvaluation
            // 
            txtIdEvaluation.Location = new Point(200, 59);
            txtIdEvaluation.Name = "txtIdEvaluation";
            txtIdEvaluation.ReadOnly = true;
            txtIdEvaluation.Size = new Size(100, 23);
            txtIdEvaluation.TabIndex = 252;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(7, 102);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 249;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(786, 447);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 248;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(7, 58);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 247;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(7, 11);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 246;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // nudNote
            // 
            nudNote.Location = new Point(518, 11);
            nudNote.Name = "nudNote";
            nudNote.Size = new Size(120, 23);
            nudNote.TabIndex = 265;
            // 
            // txtCommentaire
            // 
            txtCommentaire.Location = new Point(786, 11);
            txtCommentaire.Multiline = true;
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.Size = new Size(100, 23);
            txtCommentaire.TabIndex = 266;
            // 
            // lbCommentaire
            // 
            lbCommentaire.AutoSize = true;
            lbCommentaire.Location = new Point(688, 15);
            lbCommentaire.Name = "lbCommentaire";
            lbCommentaire.Size = new Size(80, 15);
            lbCommentaire.TabIndex = 267;
            lbCommentaire.Text = "Commentaire";
            // 
            // lbCommentaireModif
            // 
            lbCommentaireModif.AutoSize = true;
            lbCommentaireModif.Location = new Point(607, 64);
            lbCommentaireModif.Name = "lbCommentaireModif";
            lbCommentaireModif.Size = new Size(80, 15);
            lbCommentaireModif.TabIndex = 270;
            lbCommentaireModif.Text = "Commentaire";
            // 
            // txtCommentaireModif
            // 
            txtCommentaireModif.Location = new Point(710, 58);
            txtCommentaireModif.Multiline = true;
            txtCommentaireModif.Name = "txtCommentaireModif";
            txtCommentaireModif.Size = new Size(100, 23);
            txtCommentaireModif.TabIndex = 269;
            // 
            // nudNoteModif
            // 
            nudNoteModif.Location = new Point(423, 58);
            nudNoteModif.Name = "nudNoteModif";
            nudNoteModif.Size = new Size(120, 23);
            nudNoteModif.TabIndex = 268;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Location = new Point(460, 15);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(33, 15);
            lbNote.TabIndex = 271;
            lbNote.Text = "Note";
            // 
            // lbNoteModif
            // 
            lbNoteModif.AutoSize = true;
            lbNoteModif.Location = new Point(359, 64);
            lbNoteModif.Name = "lbNoteModif";
            lbNoteModif.Size = new Size(33, 15);
            lbNoteModif.TabIndex = 272;
            lbNoteModif.Text = "Note";
            // 
            // EvaluationForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 493);
            Controls.Add(lbNoteModif);
            Controls.Add(lbNote);
            Controls.Add(lbCommentaireModif);
            Controls.Add(txtCommentaireModif);
            Controls.Add(nudNoteModif);
            Controls.Add(lbCommentaire);
            Controls.Add(txtCommentaire);
            Controls.Add(nudNote);
            Controls.Add(dtpDateEvaluation);
            Controls.Add(cmbUsager);
            Controls.Add(cmbLivre);
            Controls.Add(btnVider);
            Controls.Add(txtIdEvaluationSupp);
            Controls.Add(lbIdEvaluationSupp);
            Controls.Add(lbIdEvaluation);
            Controls.Add(dgvEvaluation);
            Controls.Add(btnActualiser);
            Controls.Add(txtIdEvaluation);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Name = "EvaluationForm1";
            Text = "EvaluationForm1";
            ((System.ComponentModel.ISupportInitialize)dgvEvaluation).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoteModif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpDateEvaluation;
        private ComboBox cmbUsager;
        private ComboBox cmbLivre;
        private Button btnVider;
        private TextBox txtIdEvaluationSupp;
        private Label lbIdEvaluationSupp;
        private Label lbIdEvaluation;
        private DataGridView dgvEvaluation;
        private Button btnActualiser;
        private TextBox txtIdEvaluation;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
        private NumericUpDown nudNote;
        private TextBox txtCommentaire;
        private Label lbCommentaire;
        private Label lbCommentaireModif;
        private TextBox txtCommentaireModif;
        private NumericUpDown nudNoteModif;
        private Label lbNote;
        private Label lbNoteModif;
    }
}