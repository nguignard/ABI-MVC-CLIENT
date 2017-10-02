namespace ABIEnCouches
{
    partial class frmAjouterCollab
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
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.lblSituation = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAjouterPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblEcole = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.grpTypeContrat = new System.Windows.Forms.GroupBox();
            this.rdbStage = new System.Windows.Forms.RadioButton();
            this.rdbCDD = new System.Windows.Forms.RadioButton();
            this.rdbCDI = new System.Windows.Forms.RadioButton();
            this.grpStage = new System.Windows.Forms.GroupBox();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.grpAttributsContrats = new System.Windows.Forms.GroupBox();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.txtQualif = new System.Windows.Forms.TextBox();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.grpCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.grpTypeContrat.SuspendLayout();
            this.grpStage.SuspendLayout();
            this.grpAttributsContrats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCivil
            // 
            this.grpCivil.Controls.Add(this.rdbF);
            this.grpCivil.Controls.Add(this.rdbM);
            this.grpCivil.Location = new System.Drawing.Point(142, 181);
            this.grpCivil.Name = "grpCivil";
            this.grpCivil.Size = new System.Drawing.Size(97, 36);
            this.grpCivil.TabIndex = 39;
            this.grpCivil.TabStop = false;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(46, 13);
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
            this.lblCivilite.Location = new System.Drawing.Point(19, 196);
            this.lblCivilite.Name = "lblCivilite";
            this.lblCivilite.Size = new System.Drawing.Size(37, 13);
            this.lblCivilite.TabIndex = 38;
            this.lblCivilite.Text = "Civilité";
            // 
            // cmbFamille
            // 
            this.cmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Items.AddRange(new object[] {
            "CELIBATAIRE",
            "DIVORCE",
            "MARIE"});
            this.cmbFamille.Location = new System.Drawing.Point(142, 271);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(200, 21);
            this.cmbFamille.Sorted = true;
            this.cmbFamille.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(142, 223);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(142, 248);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctBox.Location = new System.Drawing.Point(21, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(135, 130);
            this.pctBox.TabIndex = 32;
            this.pctBox.TabStop = false;
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(19, 275);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(91, 13);
            this.lblSituation.TabIndex = 31;
            this.lblSituation.Text = "Situation Familiale";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(19, 251);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 30;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(19, 226);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 29;
            this.lblNom.Text = "Nom";
            // 
            // btnAjouterPhoto
            // 
            this.btnAjouterPhoto.Enabled = false;
            this.btnAjouterPhoto.Location = new System.Drawing.Point(22, 344);
            this.btnAjouterPhoto.Name = "btnAjouterPhoto";
            this.btnAjouterPhoto.Size = new System.Drawing.Size(106, 23);
            this.btnAjouterPhoto.TabIndex = 15;
            this.btnAjouterPhoto.Text = "A&jouter une Photo";
            this.btnAjouterPhoto.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(581, 344);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(662, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(743, 344);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 14;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(13, 16);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(62, 13);
            this.lblDateDebut.TabIndex = 44;
            this.lblDateDebut.Text = "Date Début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(12, 36);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(62, 13);
            this.lblDateFin.TabIndex = 45;
            this.lblDateFin.Text = "Date de Fin";
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(12, 87);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(65, 13);
            this.lblQualification.TabIndex = 46;
            this.lblQualification.Text = "Qualification";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(13, 113);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(35, 13);
            this.lblStatut.TabIndex = 47;
            this.lblStatut.Text = "Statut";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(13, 61);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(97, 13);
            this.lblSalaire.TabIndex = 48;
            this.lblSalaire.Text = "Salaire Brut Annuel";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(13, 139);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 49;
            this.lblMotif.Text = "Motif";
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(13, 26);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(34, 13);
            this.lblEcole.TabIndex = 50;
            this.lblEcole.Text = "Ecole";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(13, 49);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(42, 13);
            this.lblMission.TabIndex = 51;
            this.lblMission.Text = "Mission";
            // 
            // grpTypeContrat
            // 
            this.grpTypeContrat.Controls.Add(this.rdbStage);
            this.grpTypeContrat.Controls.Add(this.rdbCDD);
            this.grpTypeContrat.Controls.Add(this.rdbCDI);
            this.grpTypeContrat.Location = new System.Drawing.Point(505, 12);
            this.grpTypeContrat.Name = "grpTypeContrat";
            this.grpTypeContrat.Size = new System.Drawing.Size(313, 41);
            this.grpTypeContrat.TabIndex = 4;
            this.grpTypeContrat.TabStop = false;
            this.grpTypeContrat.Text = "Type de contrat";
            // 
            // rdbStage
            // 
            this.rdbStage.AutoSize = true;
            this.rdbStage.Location = new System.Drawing.Point(115, 18);
            this.rdbStage.Name = "rdbStage";
            this.rdbStage.Size = new System.Drawing.Size(53, 17);
            this.rdbStage.TabIndex = 2;
            this.rdbStage.Text = "Stage";
            this.rdbStage.UseVisualStyleBackColor = true;
            this.rdbStage.CheckedChanged += new System.EventHandler(this.rdbStage_CheckedChanged);
            // 
            // rdbCDD
            // 
            this.rdbCDD.AutoSize = true;
            this.rdbCDD.Location = new System.Drawing.Point(61, 18);
            this.rdbCDD.Name = "rdbCDD";
            this.rdbCDD.Size = new System.Drawing.Size(48, 17);
            this.rdbCDD.TabIndex = 1;
            this.rdbCDD.Text = "CDD";
            this.rdbCDD.UseVisualStyleBackColor = true;
            this.rdbCDD.CheckedChanged += new System.EventHandler(this.rdbCDD_CheckedChanged);
            // 
            // rdbCDI
            // 
            this.rdbCDI.AutoSize = true;
            this.rdbCDI.Checked = true;
            this.rdbCDI.Location = new System.Drawing.Point(12, 18);
            this.rdbCDI.Name = "rdbCDI";
            this.rdbCDI.Size = new System.Drawing.Size(43, 17);
            this.rdbCDI.TabIndex = 0;
            this.rdbCDI.TabStop = true;
            this.rdbCDI.Text = "CDI";
            this.rdbCDI.UseVisualStyleBackColor = true;
            this.rdbCDI.CheckedChanged += new System.EventHandler(this.rdbCDI_CheckedChanged);
            // 
            // grpStage
            // 
            this.grpStage.Controls.Add(this.txtMission);
            this.grpStage.Controls.Add(this.txtEcole);
            this.grpStage.Controls.Add(this.lblEcole);
            this.grpStage.Controls.Add(this.lblMission);
            this.grpStage.Location = new System.Drawing.Point(505, 239);
            this.grpStage.Name = "grpStage";
            this.grpStage.Size = new System.Drawing.Size(313, 79);
            this.grpStage.TabIndex = 53;
            this.grpStage.TabStop = false;
            this.grpStage.Text = "pour les Stages";
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(114, 46);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(179, 20);
            this.txtMission.TabIndex = 9;
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(114, 23);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(179, 20);
            this.txtEcole.TabIndex = 8;
            // 
            // grpAttributsContrats
            // 
            this.grpAttributsContrats.Controls.Add(this.dateFin);
            this.grpAttributsContrats.Controls.Add(this.dateDebut);
            this.grpAttributsContrats.Controls.Add(this.txtMotif);
            this.grpAttributsContrats.Controls.Add(this.txtStatut);
            this.grpAttributsContrats.Controls.Add(this.txtQualif);
            this.grpAttributsContrats.Controls.Add(this.txtSalaire);
            this.grpAttributsContrats.Controls.Add(this.lblDateDebut);
            this.grpAttributsContrats.Controls.Add(this.lblMotif);
            this.grpAttributsContrats.Controls.Add(this.lblDateFin);
            this.grpAttributsContrats.Controls.Add(this.lblQualification);
            this.grpAttributsContrats.Controls.Add(this.lblStatut);
            this.grpAttributsContrats.Controls.Add(this.lblSalaire);
            this.grpAttributsContrats.Location = new System.Drawing.Point(505, 74);
            this.grpAttributsContrats.Name = "grpAttributsContrats";
            this.grpAttributsContrats.Size = new System.Drawing.Size(313, 159);
            this.grpAttributsContrats.TabIndex = 54;
            this.grpAttributsContrats.TabStop = false;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(93, 35);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 20);
            this.dateFin.TabIndex = 57;
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(93, 10);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(200, 20);
            this.dateDebut.TabIndex = 5;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(116, 136);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(177, 20);
            this.txtMotif.TabIndex = 7;
            // 
            // txtStatut
            // 
            this.txtStatut.Location = new System.Drawing.Point(116, 110);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(177, 20);
            this.txtStatut.TabIndex = 6;
            // 
            // txtQualif
            // 
            this.txtQualif.Location = new System.Drawing.Point(116, 84);
            this.txtQualif.Name = "txtQualif";
            this.txtQualif.Size = new System.Drawing.Size(177, 20);
            this.txtQualif.TabIndex = 5;
            this.txtQualif.TabStop = false;
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(116, 58);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(177, 20);
            this.txtSalaire.TabIndex = 4;
            // 
            // frmAjouterCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 379);
            this.Controls.Add(this.grpAttributsContrats);
            this.Controls.Add(this.grpStage);
            this.Controls.Add(this.grpTypeContrat);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouterPhoto);
            this.Controls.Add(this.grpCivil);
            this.Controls.Add(this.lblCivilite);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmAjouterCollab";
            this.Text = "frmAjouterCollab";
            this.grpCivil.ResumeLayout(false);
            this.grpCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.grpTypeContrat.ResumeLayout(false);
            this.grpTypeContrat.PerformLayout();
            this.grpStage.ResumeLayout(false);
            this.grpStage.PerformLayout();
            this.grpAttributsContrats.ResumeLayout(false);
            this.grpAttributsContrats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCivil;
        internal System.Windows.Forms.RadioButton rdbF;
        internal System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Label lblCivilite;
        internal System.Windows.Forms.ComboBox cmbFamille;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.TextBox txtPrenom;
        internal System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        internal System.Windows.Forms.Button btnAjouterPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.GroupBox grpTypeContrat;
        internal System.Windows.Forms.RadioButton rdbStage;
        internal System.Windows.Forms.RadioButton rdbCDD;
        internal System.Windows.Forms.RadioButton rdbCDI;
        private System.Windows.Forms.GroupBox grpStage;
        private System.Windows.Forms.GroupBox grpAttributsContrats;
        internal System.Windows.Forms.TextBox txtMission;
        internal System.Windows.Forms.TextBox txtEcole;
        internal System.Windows.Forms.TextBox txtMotif;
        internal System.Windows.Forms.TextBox txtStatut;
        internal System.Windows.Forms.TextBox txtQualif;
        internal System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
    }
}