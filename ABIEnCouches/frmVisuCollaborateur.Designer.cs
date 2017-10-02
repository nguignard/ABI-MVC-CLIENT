namespace ABIEnCouches
{
    partial class frmVisuCollaborateur
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
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblSituation = new System.Windows.Forms.Label();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumeroMatricule = new System.Windows.Forms.TextBox();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grdContrats = new System.Windows.Forms.DataGridView();
            this.lblContrats = new System.Windows.Forms.Label();
            this.btnCreateContrat = new System.Windows.Forms.Button();
            this.lblCivilite = new System.Windows.Forms.Label();
            this.grpCivil = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnContratInitial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContrats)).BeginInit();
            this.grpCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(10, 164);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(10, 226);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(10, 251);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(10, 274);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(91, 13);
            this.lblSituation.TabIndex = 4;
            this.lblSituation.Text = "Situation Familiale";
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctBox.Location = new System.Drawing.Point(12, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(135, 130);
            this.pctBox.TabIndex = 6;
            this.pctBox.TabStop = false;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(133, 248);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(133, 223);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 11;
            // 
            // txtNumeroMatricule
            // 
            this.txtNumeroMatricule.Location = new System.Drawing.Point(133, 161);
            this.txtNumeroMatricule.Name = "txtNumeroMatricule";
            this.txtNumeroMatricule.ReadOnly = true;
            this.txtNumeroMatricule.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroMatricule.TabIndex = 18;
            this.txtNumeroMatricule.Text = "000";
            // 
            // cmbFamille
            // 
            this.cmbFamille.Enabled = false;
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Items.AddRange(new object[] {
            "CELIBATAIRE",
            "MARIE",
            "DIVORCE"});
            this.cmbFamille.Location = new System.Drawing.Point(133, 271);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(200, 21);
            this.cmbFamille.TabIndex = 19;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 332);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 22);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "&Modifier Collaborateur";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // grdContrats
            // 
            this.grdContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContrats.Location = new System.Drawing.Point(401, 37);
            this.grdContrats.Name = "grdContrats";
            this.grdContrats.Size = new System.Drawing.Size(459, 281);
            this.grdContrats.TabIndex = 22;
            // 
            // lblContrats
            // 
            this.lblContrats.AutoSize = true;
            this.lblContrats.Location = new System.Drawing.Point(398, 12);
            this.lblContrats.Name = "lblContrats";
            this.lblContrats.Size = new System.Drawing.Size(46, 13);
            this.lblContrats.TabIndex = 23;
            this.lblContrats.Text = "Contrats";
            // 
            // btnCreateContrat
            // 
            this.btnCreateContrat.Location = new System.Drawing.Point(401, 332);
            this.btnCreateContrat.Name = "btnCreateContrat";
            this.btnCreateContrat.Size = new System.Drawing.Size(130, 22);
            this.btnCreateContrat.TabIndex = 24;
            this.btnCreateContrat.Text = "&Creer un Contrat";
            this.btnCreateContrat.UseVisualStyleBackColor = true;
            // 
            // lblCivilite
            // 
            this.lblCivilite.AutoSize = true;
            this.lblCivilite.Location = new System.Drawing.Point(10, 196);
            this.lblCivilite.Name = "lblCivilite";
            this.lblCivilite.Size = new System.Drawing.Size(37, 13);
            this.lblCivilite.TabIndex = 25;
            this.lblCivilite.Text = "Civilité";
            // 
            // grpCivil
            // 
            this.grpCivil.Controls.Add(this.rdbF);
            this.grpCivil.Controls.Add(this.rdbM);
            this.grpCivil.Enabled = false;
            this.grpCivil.Location = new System.Drawing.Point(133, 181);
            this.grpCivil.Name = "grpCivil";
            this.grpCivil.Size = new System.Drawing.Size(200, 36);
            this.grpCivil.TabIndex = 26;
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
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(785, 332);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 27;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnContratInitial
            // 
            this.btnContratInitial.Location = new System.Drawing.Point(549, 333);
            this.btnContratInitial.Name = "btnContratInitial";
            this.btnContratInitial.Size = new System.Drawing.Size(130, 22);
            this.btnContratInitial.TabIndex = 28;
            this.btnContratInitial.Text = "Contrat Initial";
            this.btnContratInitial.UseVisualStyleBackColor = true;
            this.btnContratInitial.Visible = false;
            // 
            // frmVisuCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 366);
            this.Controls.Add(this.btnContratInitial);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpCivil);
            this.Controls.Add(this.lblCivilite);
            this.Controls.Add(this.btnCreateContrat);
            this.Controls.Add(this.lblContrats);
            this.Controls.Add(this.grdContrats);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.txtNumeroMatricule);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMatricule);
            this.Name = "frmVisuCollaborateur";
            this.Text = "0";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContrats)).EndInit();
            this.grpCivil.ResumeLayout(false);
            this.grpCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumeroMatricule;
        private System.Windows.Forms.ComboBox cmbFamille;
        internal System.Windows.Forms.Button btnModifier;
        internal System.Windows.Forms.DataGridView grdContrats;
        private System.Windows.Forms.Label lblContrats;
        internal System.Windows.Forms.Button btnCreateContrat;
        private System.Windows.Forms.Label lblCivilite;
        private System.Windows.Forms.GroupBox grpCivil;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Button btnFermer;
        internal System.Windows.Forms.Button btnContratInitial;
    }
}