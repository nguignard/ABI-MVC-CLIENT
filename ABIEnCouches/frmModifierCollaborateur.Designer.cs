namespace ABIEnCouches
{
    partial class frmModifierCollaborateur
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
            this.grpCivil = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.lblCivilite = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.txtNumeroMatricule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.lblSituation = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCivil
            // 
            this.grpCivil.Controls.Add(this.rdbF);
            this.grpCivil.Controls.Add(this.rdbM);
            this.grpCivil.Location = new System.Drawing.Point(133, 181);
            this.grpCivil.Name = "grpCivil";
            this.grpCivil.Size = new System.Drawing.Size(200, 36);
            this.grpCivil.TabIndex = 38;
            this.grpCivil.TabStop = false;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(109, 13);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 1;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Checked = true;
            this.rdbM.Location = new System.Drawing.Point(6, 13);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // lblCivilite
            // 
            this.lblCivilite.AutoSize = true;
            this.lblCivilite.Location = new System.Drawing.Point(10, 196);
            this.lblCivilite.Name = "lblCivilite";
            this.lblCivilite.Size = new System.Drawing.Size(37, 13);
            this.lblCivilite.TabIndex = 37;
            this.lblCivilite.Text = "Civilité";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(97, 313);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(76, 22);
            this.btnValider.TabIndex = 36;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // cmbFamille
            // 
            this.cmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Items.AddRange(new object[] {
            "CELIBATAIRE",
            "MARIE",
            "DIVORCE"});
            this.cmbFamille.Location = new System.Drawing.Point(133, 271);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(200, 21);
            this.cmbFamille.TabIndex = 3;
            // 
            // txtNumeroMatricule
            // 
            this.txtNumeroMatricule.Location = new System.Drawing.Point(133, 161);
            this.txtNumeroMatricule.Name = "txtNumeroMatricule";
            this.txtNumeroMatricule.ReadOnly = true;
            this.txtNumeroMatricule.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroMatricule.TabIndex = 34;
            this.txtNumeroMatricule.Text = "000";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(133, 223);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(133, 248);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctBox.Location = new System.Drawing.Point(12, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(135, 130);
            this.pctBox.TabIndex = 31;
            this.pctBox.TabStop = false;
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(10, 274);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(91, 13);
            this.lblSituation.TabIndex = 30;
            this.lblSituation.Text = "Situation Familiale";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(10, 251);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 29;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(10, 226);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nom";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(10, 164);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 27;
            this.lblMatricule.Text = "Matricule";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(182, 313);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(82, 22);
            this.btnAnnuler.TabIndex = 39;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(270, 313);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(63, 22);
            this.btnFermer.TabIndex = 40;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmModifierCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 353);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpCivil);
            this.Controls.Add(this.lblCivilite);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.txtNumeroMatricule);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMatricule);
            this.Name = "frmModifierCollaborateur";
            this.Text = "frmModifierCollaborateur";
            this.grpCivil.ResumeLayout(false);
            this.grpCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCivil;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Label lblCivilite;
        internal System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.TextBox txtNumeroMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        internal System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.Button btnFermer;
    }
}