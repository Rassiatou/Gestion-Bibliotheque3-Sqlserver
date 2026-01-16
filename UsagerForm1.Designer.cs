namespace TP3_BD
{
    partial class UsagerForm1
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
            txtPrenomUsagerModif = new TextBox();
            lbPrenomUsagerModif = new Label();
            lbNomUsagerModif = new Label();
            txtNomUsagerModif = new TextBox();
            label3 = new Label();
            txtPrenomUsager = new TextBox();
            lbPrenom = new Label();
            lbNomUsager = new Label();
            txtNomUsager = new TextBox();
            dgvUsager = new DataGridView();
            btnRechercher = new Button();
            btnActualiser = new Button();
            lbUsagerSupp = new Label();
            txtIdUsagerSupp = new TextBox();
            lbIdUsager = new Label();
            txtIdUsager = new TextBox();
            lbISBN = new Label();
            btnVider = new Button();
            lbListIdUsager = new Label();
            txtListeIdUsager = new TextBox();
            btnSupprimer = new Button();
            btnRetour = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            txtTelephone = new TextBox();
            lbTelephone = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbtypeUsager = new ComboBox();
            chkActif = new CheckBox();
            chkInactif = new CheckBox();
            txtTelephoneModif = new TextBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsager).BeginInit();
            SuspendLayout();
            // 
            // txtPrenomUsagerModif
            // 
            txtPrenomUsagerModif.Location = new Point(675, 81);
            txtPrenomUsagerModif.Margin = new Padding(3, 4, 3, 4);
            txtPrenomUsagerModif.Name = "txtPrenomUsagerModif";
            txtPrenomUsagerModif.Size = new Size(114, 27);
            txtPrenomUsagerModif.TabIndex = 141;
            // 
            // lbPrenomUsagerModif
            // 
            lbPrenomUsagerModif.AutoSize = true;
            lbPrenomUsagerModif.Location = new Point(606, 85);
            lbPrenomUsagerModif.Name = "lbPrenomUsagerModif";
            lbPrenomUsagerModif.Size = new Size(60, 20);
            lbPrenomUsagerModif.TabIndex = 140;
            lbPrenomUsagerModif.Text = "Prénom";
            // 
            // lbNomUsagerModif
            // 
            lbNomUsagerModif.AutoSize = true;
            lbNomUsagerModif.Location = new Point(365, 85);
            lbNomUsagerModif.Name = "lbNomUsagerModif";
            lbNomUsagerModif.Size = new Size(42, 20);
            lbNomUsagerModif.TabIndex = 139;
            lbNomUsagerModif.Text = "Nom";
            // 
            // txtNomUsagerModif
            // 
            txtNomUsagerModif.Location = new Point(414, 81);
            txtNomUsagerModif.Margin = new Padding(3, 4, 3, 4);
            txtNomUsagerModif.Name = "txtNomUsagerModif";
            txtNomUsagerModif.Size = new Size(114, 27);
            txtNomUsagerModif.TabIndex = 138;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 87);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 137;
            // 
            // txtPrenomUsager
            // 
            txtPrenomUsager.Location = new Point(449, 17);
            txtPrenomUsager.Margin = new Padding(3, 4, 3, 4);
            txtPrenomUsager.Name = "txtPrenomUsager";
            txtPrenomUsager.Size = new Size(114, 27);
            txtPrenomUsager.TabIndex = 136;
            txtPrenomUsager.TextChanged += txtPrenomUsager_TextChanged;
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(377, 21);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(60, 20);
            lbPrenom.TabIndex = 135;
            lbPrenom.Text = "Prénom";
            // 
            // lbNomUsager
            // 
            lbNomUsager.AutoSize = true;
            lbNomUsager.Location = new Point(141, 27);
            lbNomUsager.Name = "lbNomUsager";
            lbNomUsager.Size = new Size(42, 20);
            lbNomUsager.TabIndex = 134;
            lbNomUsager.Text = "Nom";
            // 
            // txtNomUsager
            // 
            txtNomUsager.Location = new Point(189, 16);
            txtNomUsager.Margin = new Padding(3, 4, 3, 4);
            txtNomUsager.Name = "txtNomUsager";
            txtNomUsager.Size = new Size(114, 27);
            txtNomUsager.TabIndex = 133;
            // 
            // dgvUsager
            // 
            dgvUsager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsager.Location = new Point(14, 384);
            dgvUsager.Margin = new Padding(3, 4, 3, 4);
            dgvUsager.MultiSelect = false;
            dgvUsager.Name = "dgvUsager";
            dgvUsager.ReadOnly = true;
            dgvUsager.RowHeadersWidth = 51;
            dgvUsager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsager.Size = new Size(749, 244);
            dgvUsager.TabIndex = 132;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(201, 312);
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
            btnActualiser.Location = new Point(14, 312);
            btnActualiser.Margin = new Padding(3, 4, 3, 4);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(86, 31);
            btnActualiser.TabIndex = 130;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += btnActualiser_Click;
            // 
            // lbUsagerSupp
            // 
            lbUsagerSupp.AutoSize = true;
            lbUsagerSupp.Location = new Point(131, 147);
            lbUsagerSupp.Name = "lbUsagerSupp";
            lbUsagerSupp.Size = new Size(68, 20);
            lbUsagerSupp.TabIndex = 129;
            lbUsagerSupp.Text = "IdUsager";
            // 
            // txtIdUsagerSupp
            // 
            txtIdUsagerSupp.Location = new Point(201, 143);
            txtIdUsagerSupp.Margin = new Padding(3, 4, 3, 4);
            txtIdUsagerSupp.Name = "txtIdUsagerSupp";
            txtIdUsagerSupp.ReadOnly = true;
            txtIdUsagerSupp.Size = new Size(114, 27);
            txtIdUsagerSupp.TabIndex = 128;
            // 
            // lbIdUsager
            // 
            lbIdUsager.AutoSize = true;
            lbIdUsager.Location = new Point(131, 85);
            lbIdUsager.Name = "lbIdUsager";
            lbIdUsager.Size = new Size(68, 20);
            lbIdUsager.TabIndex = 127;
            lbIdUsager.Text = "IdUsager";
            // 
            // txtIdUsager
            // 
            txtIdUsager.Location = new Point(198, 81);
            txtIdUsager.Margin = new Padding(3, 4, 3, 4);
            txtIdUsager.Name = "txtIdUsager";
            txtIdUsager.ReadOnly = true;
            txtIdUsager.Size = new Size(114, 27);
            txtIdUsager.TabIndex = 126;
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(567, 21);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(0, 20);
            lbISBN.TabIndex = 125;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(14, 217);
            btnVider.Margin = new Padding(3, 4, 3, 4);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(86, 31);
            btnVider.TabIndex = 124;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // lbListIdUsager
            // 
            lbListIdUsager.AutoSize = true;
            lbListIdUsager.Location = new Point(398, 319);
            lbListIdUsager.Name = "lbListIdUsager";
            lbListIdUsager.Size = new Size(68, 20);
            lbListIdUsager.TabIndex = 123;
            lbListIdUsager.Text = "IdUsager";
            // 
            // txtListeIdUsager
            // 
            txtListeIdUsager.Location = new Point(473, 313);
            txtListeIdUsager.Margin = new Padding(3, 4, 3, 4);
            txtListeIdUsager.Name = "txtListeIdUsager";
            txtListeIdUsager.Size = new Size(114, 27);
            txtListeIdUsager.TabIndex = 122;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(14, 137);
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
            btnRetour.Location = new Point(904, 597);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(86, 31);
            btnRetour.TabIndex = 120;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(14, 79);
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
            btnAjouter.Location = new Point(14, 16);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 118;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(697, 17);
            txtTelephone.Margin = new Padding(3, 4, 3, 4);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(114, 27);
            txtTelephone.TabIndex = 144;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new Point(625, 21);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new Size(78, 20);
            lbTelephone.TabIndex = 143;
            lbTelephone.Text = "Téléphone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(815, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 142;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1072, 23);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 145;
            // 
            // cmbtypeUsager
            // 
            cmbtypeUsager.FormattingEnabled = true;
            cmbtypeUsager.Location = new Point(927, 19);
            cmbtypeUsager.Margin = new Padding(3, 4, 3, 4);
            cmbtypeUsager.Name = "cmbtypeUsager";
            cmbtypeUsager.Size = new Size(138, 28);
            cmbtypeUsager.TabIndex = 148;
            cmbtypeUsager.Text = "TypeUsager";
            // 
            // chkActif
            // 
            chkActif.AutoSize = true;
            chkActif.Location = new Point(1161, 27);
            chkActif.Margin = new Padding(3, 4, 3, 4);
            chkActif.Name = "chkActif";
            chkActif.Size = new Size(62, 24);
            chkActif.TabIndex = 149;
            chkActif.Text = "Actif";
            chkActif.UseVisualStyleBackColor = true;
            // 
            // chkInactif
            // 
            chkInactif.AutoSize = true;
            chkInactif.Location = new Point(1275, 27);
            chkInactif.Margin = new Padding(3, 4, 3, 4);
            chkInactif.Name = "chkInactif";
            chkInactif.Size = new Size(72, 24);
            chkInactif.TabIndex = 150;
            chkInactif.Text = "Inactif";
            chkInactif.UseVisualStyleBackColor = true;
            // 
            // txtTelephoneModif
            // 
            txtTelephoneModif.Location = new Point(929, 83);
            txtTelephoneModif.Margin = new Padding(3, 4, 3, 4);
            txtTelephoneModif.Name = "txtTelephoneModif";
            txtTelephoneModif.Size = new Size(114, 27);
            txtTelephoneModif.TabIndex = 153;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(855, 87);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 152;
            label1.Text = "Téléphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1045, 87);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 151;
            // 
            // UsagerForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 653);
            Controls.Add(txtTelephoneModif);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(chkInactif);
            Controls.Add(chkActif);
            Controls.Add(cmbtypeUsager);
            Controls.Add(label4);
            Controls.Add(txtTelephone);
            Controls.Add(lbTelephone);
            Controls.Add(label2);
            Controls.Add(txtPrenomUsagerModif);
            Controls.Add(lbPrenomUsagerModif);
            Controls.Add(lbNomUsagerModif);
            Controls.Add(txtNomUsagerModif);
            Controls.Add(label3);
            Controls.Add(txtPrenomUsager);
            Controls.Add(lbPrenom);
            Controls.Add(lbNomUsager);
            Controls.Add(txtNomUsager);
            Controls.Add(dgvUsager);
            Controls.Add(btnRechercher);
            Controls.Add(btnActualiser);
            Controls.Add(lbUsagerSupp);
            Controls.Add(txtIdUsagerSupp);
            Controls.Add(lbIdUsager);
            Controls.Add(txtIdUsager);
            Controls.Add(lbISBN);
            Controls.Add(btnVider);
            Controls.Add(lbListIdUsager);
            Controls.Add(txtListeIdUsager);
            Controls.Add(btnSupprimer);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsagerForm1";
            Text = "UsagerForm1";
            ((System.ComponentModel.ISupportInitialize)dgvUsager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrenomUsagerModif;
        private Label lbPrenomUsagerModif;
        private Label lbNomUsagerModif;
        private TextBox txtNomUsagerModif;
        private Label label3;
        private TextBox txtPrenomUsager;
        private Label lbPrenom;
        private Label lbNomUsager;
        private TextBox txtNomUsager;
        private DataGridView dgvUsager;
        private Button btnRechercher;
        private Button btnActualiser;
        private Label lbUsagerSupp;
        private TextBox txtIdUsagerSupp;
        private Label lbIdUsager;
        private TextBox txtIdUsager;
        private Label lbISBN;
        private Button btnVider;
        private Label lbListIdUsager;
        private TextBox txtListeIdUsager;
        private Button btnSupprimer;
        private Button btnRetour;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtTelephone;
        private Label lbTelephone;
        private Label label2;
        private Label label4;
        private ComboBox cmbtypeUsager;
        private CheckBox chkActif;
        private CheckBox chkInactif;
        private TextBox txtTelephoneModif;
        private Label label1;
        private Label label5;
    }
}