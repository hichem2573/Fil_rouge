namespace FormForum
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plCombo = new System.Windows.Forms.Panel();
            this.cbBoxSujet = new System.Windows.Forms.ComboBox();
            this.cbBoxCategorie = new System.Windows.Forms.ComboBox();
            this.pnlAnnulation = new System.Windows.Forms.Panel();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plConnexion = new System.Windows.Forms.Panel();
            this.btEditPassword = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.grBxGestion = new System.Windows.Forms.GroupBox();
            this.btDeleteSujet = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDeleteReponse = new System.Windows.Forms.Button();
            this.grBoxCreation = new System.Windows.Forms.GroupBox();
            this.btNouveauSujet = new System.Windows.Forms.Button();
            this.btNouvelleReponse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.plCombo.SuspendLayout();
            this.pnlAnnulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.plConnexion.SuspendLayout();
            this.grBxGestion.SuspendLayout();
            this.grBoxCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.68462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Controls.Add(this.plCombo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAnnulation, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.plConnexion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grBxGestion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grBoxCreation, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.09211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.9079F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1242, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // plCombo
            // 
            this.plCombo.Controls.Add(this.cbBoxSujet);
            this.plCombo.Controls.Add(this.cbBoxCategorie);
            this.plCombo.Location = new System.Drawing.Point(1024, 94);
            this.plCombo.Name = "plCombo";
            this.plCombo.Size = new System.Drawing.Size(215, 410);
            this.plCombo.TabIndex = 0;
            // 
            // cbBoxSujet
            // 
            this.cbBoxSujet.FormattingEnabled = true;
            this.cbBoxSujet.Location = new System.Drawing.Point(25, 237);
            this.cbBoxSujet.Name = "cbBoxSujet";
            this.cbBoxSujet.Size = new System.Drawing.Size(166, 21);
            this.cbBoxSujet.TabIndex = 1;
            this.cbBoxSujet.Text = "Selectionner un Sujet";
            this.cbBoxSujet.SelectedIndexChanged += new System.EventHandler(this.cbBoxSujet_SelectedIndexChanged);
            // 
            // cbBoxCategorie
            // 
            this.cbBoxCategorie.FormattingEnabled = true;
            this.cbBoxCategorie.Location = new System.Drawing.Point(25, 77);
            this.cbBoxCategorie.Name = "cbBoxCategorie";
            this.cbBoxCategorie.Size = new System.Drawing.Size(166, 21);
            this.cbBoxCategorie.TabIndex = 0;
            this.cbBoxCategorie.Text = "Selectionner une catégorie";
            this.cbBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbBoxCategorie_SelectedIndexChanged);
            // 
            // pnlAnnulation
            // 
            this.pnlAnnulation.Controls.Add(this.btAnnuler);
            this.pnlAnnulation.Location = new System.Drawing.Point(1024, 510);
            this.pnlAnnulation.Name = "pnlAnnulation";
            this.pnlAnnulation.Size = new System.Drawing.Size(215, 95);
            this.pnlAnnulation.TabIndex = 1;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Image = global::FormForum.Properties.Resources.annuler_icone_8717_32;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(43, 32);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(125, 37);
            this.btAnnuler.TabIndex = 0;
            this.btAnnuler.Text = "&Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 410);
            this.dataGridView1.TabIndex = 2;
            // 
            // plConnexion
            // 
            this.plConnexion.Controls.Add(this.btEditPassword);
            this.plConnexion.Controls.Add(this.btLogin);
            this.plConnexion.Location = new System.Drawing.Point(190, 510);
            this.plConnexion.Name = "plConnexion";
            this.plConnexion.Size = new System.Drawing.Size(828, 95);
            this.plConnexion.TabIndex = 3;
            // 
            // btEditPassword
            // 
            this.btEditPassword.Image = global::FormForum.Properties.Resources.edit;
            this.btEditPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditPassword.Location = new System.Drawing.Point(632, 32);
            this.btEditPassword.Name = "btEditPassword";
            this.btEditPassword.Size = new System.Drawing.Size(137, 37);
            this.btEditPassword.TabIndex = 1;
            this.btEditPassword.Text = "&Edit Password";
            this.btEditPassword.UseVisualStyleBackColor = true;
            this.btEditPassword.Click += new System.EventHandler(this.btEditPassword_Click);
            // 
            // btLogin
            // 
            this.btLogin.Image = global::FormForum.Properties.Resources.login;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(40, 32);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(122, 37);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "&Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // grBxGestion
            // 
            this.grBxGestion.Controls.Add(this.btDeleteReponse);
            this.grBxGestion.Controls.Add(this.btEdit);
            this.grBxGestion.Controls.Add(this.btDeleteSujet);
            this.grBxGestion.Location = new System.Drawing.Point(3, 94);
            this.grBxGestion.Name = "grBxGestion";
            this.grBxGestion.Size = new System.Drawing.Size(181, 410);
            this.grBxGestion.TabIndex = 4;
            this.grBxGestion.TabStop = false;
            this.grBxGestion.Text = "Gestion forum";
            // 
            // btDeleteSujet
            // 
            this.btDeleteSujet.Location = new System.Drawing.Point(19, 45);
            this.btDeleteSujet.Name = "btDeleteSujet";
            this.btDeleteSujet.Size = new System.Drawing.Size(136, 43);
            this.btDeleteSujet.TabIndex = 4;
            this.btDeleteSujet.Text = "Supprimer Sujet";
            this.btDeleteSujet.UseVisualStyleBackColor = true;
            this.btDeleteSujet.Click += new System.EventHandler(this.btDeleteSujet_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(19, 145);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(136, 40);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Modifier Sujet";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDeleteReponse
            // 
            this.btDeleteReponse.Location = new System.Drawing.Point(19, 237);
            this.btDeleteReponse.Name = "btDeleteReponse";
            this.btDeleteReponse.Size = new System.Drawing.Size(136, 40);
            this.btDeleteReponse.TabIndex = 6;
            this.btDeleteReponse.Text = "Supprimer Reponse";
            this.btDeleteReponse.UseVisualStyleBackColor = true;
            this.btDeleteReponse.Click += new System.EventHandler(this.btDeleteReponse_Click);
            // 
            // grBoxCreation
            // 
            this.grBoxCreation.Controls.Add(this.btNouvelleReponse);
            this.grBoxCreation.Controls.Add(this.btNouveauSujet);
            this.grBoxCreation.Location = new System.Drawing.Point(190, 3);
            this.grBoxCreation.Name = "grBoxCreation";
            this.grBoxCreation.Size = new System.Drawing.Size(828, 85);
            this.grBoxCreation.TabIndex = 5;
            this.grBoxCreation.TabStop = false;
            this.grBoxCreation.Text = "Création";
            // 
            // btNouveauSujet
            // 
            this.btNouveauSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNouveauSujet.Location = new System.Drawing.Point(56, 27);
            this.btNouveauSujet.Name = "btNouveauSujet";
            this.btNouveauSujet.Size = new System.Drawing.Size(144, 40);
            this.btNouveauSujet.TabIndex = 7;
            this.btNouveauSujet.Text = "Nouveau sujet";
            this.btNouveauSujet.UseVisualStyleBackColor = true;
            this.btNouveauSujet.Click += new System.EventHandler(this.btNouveauSujet_Click);
            // 
            // btNouvelleReponse
            // 
            this.btNouvelleReponse.Location = new System.Drawing.Point(632, 27);
            this.btNouvelleReponse.Name = "btNouvelleReponse";
            this.btNouvelleReponse.Size = new System.Drawing.Size(137, 40);
            this.btNouvelleReponse.TabIndex = 8;
            this.btNouvelleReponse.Text = "Nouvelle reponse";
            this.btNouvelleReponse.UseVisualStyleBackColor = true;
            this.btNouvelleReponse.Click += new System.EventHandler(this.btNouvelleReponse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1266, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "frmMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.plCombo.ResumeLayout(false);
            this.pnlAnnulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.plConnexion.ResumeLayout(false);
            this.grBxGestion.ResumeLayout(false);
            this.grBoxCreation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel plCombo;
        private System.Windows.Forms.ComboBox cbBoxSujet;
        private System.Windows.Forms.ComboBox cbBoxCategorie;
        private System.Windows.Forms.Panel pnlAnnulation;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel plConnexion;
        private System.Windows.Forms.Button btEditPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.GroupBox grBxGestion;
        private System.Windows.Forms.Button btDeleteReponse;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDeleteSujet;
        private System.Windows.Forms.GroupBox grBoxCreation;
        private System.Windows.Forms.Button btNouvelleReponse;
        private System.Windows.Forms.Button btNouveauSujet;
    }
}