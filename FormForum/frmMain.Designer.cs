namespace FormForum
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tlPnlForum = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAnnulation = new System.Windows.Forms.Panel();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.dataGridViewSujet = new System.Windows.Forms.DataGridView();
            this.plConnexion = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btEditPassword = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.grBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btDeleteReponse = new System.Windows.Forms.Button();
            this.btDeleteSujet = new System.Windows.Forms.Button();
            this.btEditSujet = new System.Windows.Forms.Button();
            this.plCategories = new System.Windows.Forms.Panel();
            this.gpBoxCategories = new System.Windows.Forms.GroupBox();
            this.cbBoxCategorie = new System.Windows.Forms.ComboBox();
            this.tableLayPnlSujet = new System.Windows.Forms.TableLayoutPanel();
            this.lblReponseSujet = new System.Windows.Forms.Label();
            this.grBoxSujet = new System.Windows.Forms.GroupBox();
            this.lblSujetCat = new System.Windows.Forms.Label();
            this.cbBoxSujet = new System.Windows.Forms.ComboBox();
            this.grBoxDescriSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxDescriSujet = new System.Windows.Forms.TextBox();
            this.tlPnlForum.SuspendLayout();
            this.pnlAnnulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSujet)).BeginInit();
            this.plConnexion.SuspendLayout();
            this.grBoxAdmin.SuspendLayout();
            this.plCategories.SuspendLayout();
            this.gpBoxCategories.SuspendLayout();
            this.tableLayPnlSujet.SuspendLayout();
            this.grBoxSujet.SuspendLayout();
            this.grBoxDescriSujet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPnlForum
            // 
            this.tlPnlForum.ColumnCount = 3;
            this.tlPnlForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31538F));
            this.tlPnlForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.68462F));
            this.tlPnlForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tlPnlForum.Controls.Add(this.pnlAnnulation, 2, 2);
            this.tlPnlForum.Controls.Add(this.dataGridViewSujet, 1, 1);
            this.tlPnlForum.Controls.Add(this.plConnexion, 1, 2);
            this.tlPnlForum.Controls.Add(this.grBoxAdmin, 2, 1);
            this.tlPnlForum.Controls.Add(this.plCategories, 0, 0);
            this.tlPnlForum.Controls.Add(this.tableLayPnlSujet, 1, 0);
            this.tlPnlForum.Controls.Add(this.grBoxDescriSujet, 2, 0);
            this.tlPnlForum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPnlForum.Location = new System.Drawing.Point(0, 0);
            this.tlPnlForum.Name = "tlPnlForum";
            this.tlPnlForum.RowCount = 3;
            this.tlPnlForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.48211F));
            this.tlPnlForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.51789F));
            this.tlPnlForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlPnlForum.Size = new System.Drawing.Size(1266, 632);
            this.tlPnlForum.TabIndex = 0;
            // 
            // pnlAnnulation
            // 
            this.pnlAnnulation.Controls.Add(this.btAnnuler);
            this.pnlAnnulation.Location = new System.Drawing.Point(1046, 534);
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
            // dataGridViewSujet
            // 
            this.dataGridViewSujet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSujet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSujet.Location = new System.Drawing.Point(194, 133);
            this.dataGridViewSujet.Name = "dataGridViewSujet";
            this.dataGridViewSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSujet.Size = new System.Drawing.Size(846, 395);
            this.dataGridViewSujet.TabIndex = 4;
            // 
            // plConnexion
            // 
            this.plConnexion.Controls.Add(this.btLogout);
            this.plConnexion.Controls.Add(this.btEditPassword);
            this.plConnexion.Controls.Add(this.btLogin);
            this.plConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plConnexion.Location = new System.Drawing.Point(194, 534);
            this.plConnexion.Name = "plConnexion";
            this.plConnexion.Size = new System.Drawing.Size(846, 95);
            this.plConnexion.TabIndex = 3;
            // 
            // btLogout
            // 
            this.btLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogout.Image = global::FormForum.Properties.Resources.quitter;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(669, 32);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(122, 37);
            this.btLogout.TabIndex = 2;
            this.btLogout.Text = "&Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btEditPassword
            // 
            this.btEditPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditPassword.Image = global::FormForum.Properties.Resources.edit;
            this.btEditPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditPassword.Location = new System.Drawing.Point(360, 32);
            this.btEditPassword.Name = "btEditPassword";
            this.btEditPassword.Size = new System.Drawing.Size(122, 37);
            this.btEditPassword.TabIndex = 1;
            this.btEditPassword.Text = "&Edit Password";
            this.btEditPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditPassword.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.Image = global::FormForum.Properties.Resources.login;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(49, 32);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(122, 37);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "&Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // grBoxAdmin
            // 
            this.grBoxAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBoxAdmin.Controls.Add(this.btDeleteReponse);
            this.grBoxAdmin.Controls.Add(this.btDeleteSujet);
            this.grBoxAdmin.Controls.Add(this.btEditSujet);
            this.grBoxAdmin.Location = new System.Drawing.Point(1047, 133);
            this.grBoxAdmin.Name = "grBoxAdmin";
            this.grBoxAdmin.Size = new System.Drawing.Size(215, 395);
            this.grBoxAdmin.TabIndex = 4;
            this.grBoxAdmin.TabStop = false;
            this.grBoxAdmin.Text = "Administration Forum";
            // 
            // btDeleteReponse
            // 
            this.btDeleteReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDeleteReponse.Location = new System.Drawing.Point(43, 265);
            this.btDeleteReponse.Name = "btDeleteReponse";
            this.btDeleteReponse.Size = new System.Drawing.Size(124, 39);
            this.btDeleteReponse.TabIndex = 2;
            this.btDeleteReponse.Text = "Delete &Reponse";
            this.btDeleteReponse.UseVisualStyleBackColor = true;
            // 
            // btDeleteSujet
            // 
            this.btDeleteSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDeleteSujet.Location = new System.Drawing.Point(43, 149);
            this.btDeleteSujet.Name = "btDeleteSujet";
            this.btDeleteSujet.Size = new System.Drawing.Size(124, 39);
            this.btDeleteSujet.TabIndex = 1;
            this.btDeleteSujet.Text = "&Delete Sujet";
            this.btDeleteSujet.UseVisualStyleBackColor = true;
            // 
            // btEditSujet
            // 
            this.btEditSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditSujet.Location = new System.Drawing.Point(43, 39);
            this.btEditSujet.Name = "btEditSujet";
            this.btEditSujet.Size = new System.Drawing.Size(124, 39);
            this.btEditSujet.TabIndex = 0;
            this.btEditSujet.Text = "Edit &Sujet";
            this.btEditSujet.UseVisualStyleBackColor = true;
            // 
            // plCategories
            // 
            this.plCategories.Controls.Add(this.gpBoxCategories);
            this.plCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCategories.Location = new System.Drawing.Point(3, 3);
            this.plCategories.Name = "plCategories";
            this.plCategories.Size = new System.Drawing.Size(185, 124);
            this.plCategories.TabIndex = 5;
            // 
            // gpBoxCategories
            // 
            this.gpBoxCategories.Controls.Add(this.cbBoxCategorie);
            this.gpBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBoxCategories.Location = new System.Drawing.Point(0, 0);
            this.gpBoxCategories.Name = "gpBoxCategories";
            this.gpBoxCategories.Size = new System.Drawing.Size(185, 124);
            this.gpBoxCategories.TabIndex = 0;
            this.gpBoxCategories.TabStop = false;
            this.gpBoxCategories.Text = "Categories :";
            // 
            // cbBoxCategorie
            // 
            this.cbBoxCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCategorie.FormattingEnabled = true;
            this.cbBoxCategorie.Location = new System.Drawing.Point(3, 16);
            this.cbBoxCategorie.Name = "cbBoxCategorie";
            this.cbBoxCategorie.Size = new System.Drawing.Size(179, 21);
            this.cbBoxCategorie.TabIndex = 0;
            // 
            // tableLayPnlSujet
            // 
            this.tableLayPnlSujet.ColumnCount = 1;
            this.tableLayPnlSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPnlSujet.Controls.Add(this.lblReponseSujet, 0, 1);
            this.tableLayPnlSujet.Controls.Add(this.grBoxSujet, 0, 0);
            this.tableLayPnlSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPnlSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayPnlSujet.Location = new System.Drawing.Point(194, 3);
            this.tableLayPnlSujet.Name = "tableLayPnlSujet";
            this.tableLayPnlSujet.RowCount = 2;
            this.tableLayPnlSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.6129F));
            this.tableLayPnlSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.3871F));
            this.tableLayPnlSujet.Size = new System.Drawing.Size(846, 124);
            this.tableLayPnlSujet.TabIndex = 6;
            // 
            // lblReponseSujet
            // 
            this.lblReponseSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponseSujet.AutoSize = true;
            this.lblReponseSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponseSujet.Location = new System.Drawing.Point(226, 99);
            this.lblReponseSujet.Name = "lblReponseSujet";
            this.lblReponseSujet.Size = new System.Drawing.Size(393, 20);
            this.lblReponseSujet.TabIndex = 0;
            this.lblReponseSujet.Text = "Il n\'y a pas de reponse au sujet, pour le moment";
            // 
            // grBoxSujet
            // 
            this.grBoxSujet.Controls.Add(this.lblSujetCat);
            this.grBoxSujet.Controls.Add(this.cbBoxSujet);
            this.grBoxSujet.Location = new System.Drawing.Point(3, 3);
            this.grBoxSujet.Name = "grBoxSujet";
            this.grBoxSujet.Size = new System.Drawing.Size(840, 88);
            this.grBoxSujet.TabIndex = 1;
            this.grBoxSujet.TabStop = false;
            this.grBoxSujet.Text = "Sujet :";
            // 
            // lblSujetCat
            // 
            this.lblSujetCat.AutoSize = true;
            this.lblSujetCat.Location = new System.Drawing.Point(320, 27);
            this.lblSujetCat.Name = "lblSujetCat";
            this.lblSujetCat.Size = new System.Drawing.Size(353, 16);
            this.lblSujetCat.TabIndex = 3;
            this.lblSujetCat.Text = "La catégorie selectionnée, ne contient aucun sujet";
            // 
            // cbBoxSujet
            // 
            this.cbBoxSujet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSujet.FormattingEnabled = true;
            this.cbBoxSujet.Location = new System.Drawing.Point(6, 19);
            this.cbBoxSujet.Name = "cbBoxSujet";
            this.cbBoxSujet.Size = new System.Drawing.Size(179, 24);
            this.cbBoxSujet.TabIndex = 1;
            // 
            // grBoxDescriSujet
            // 
            this.grBoxDescriSujet.Controls.Add(this.txtBoxDescriSujet);
            this.grBoxDescriSujet.Location = new System.Drawing.Point(1046, 3);
            this.grBoxDescriSujet.Name = "grBoxDescriSujet";
            this.grBoxDescriSujet.Size = new System.Drawing.Size(217, 124);
            this.grBoxDescriSujet.TabIndex = 7;
            this.grBoxDescriSujet.TabStop = false;
            this.grBoxDescriSujet.Text = "Description Sujet :";
            // 
            // txtBoxDescriSujet
            // 
            this.txtBoxDescriSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDescriSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDescriSujet.Multiline = true;
            this.txtBoxDescriSujet.Name = "txtBoxDescriSujet";
            this.txtBoxDescriSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescriSujet.Size = new System.Drawing.Size(211, 105);
            this.txtBoxDescriSujet.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1266, 632);
            this.Controls.Add(this.tlPnlForum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Communauté des développeurs de 2ISA";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tlPnlForum.ResumeLayout(false);
            this.pnlAnnulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSujet)).EndInit();
            this.plConnexion.ResumeLayout(false);
            this.grBoxAdmin.ResumeLayout(false);
            this.plCategories.ResumeLayout(false);
            this.gpBoxCategories.ResumeLayout(false);
            this.tableLayPnlSujet.ResumeLayout(false);
            this.tableLayPnlSujet.PerformLayout();
            this.grBoxSujet.ResumeLayout(false);
            this.grBoxSujet.PerformLayout();
            this.grBoxDescriSujet.ResumeLayout(false);
            this.grBoxDescriSujet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPnlForum;
        private System.Windows.Forms.Panel pnlAnnulation;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.DataGridView dataGridViewSujet;
        private System.Windows.Forms.Panel plConnexion;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btEditPassword;
        private System.Windows.Forms.GroupBox grBoxAdmin;
        private System.Windows.Forms.Button btDeleteReponse;
        private System.Windows.Forms.Button btDeleteSujet;
        private System.Windows.Forms.Button btEditSujet;
        private System.Windows.Forms.Panel plCategories;
        private System.Windows.Forms.GroupBox gpBoxCategories;
        private System.Windows.Forms.ComboBox cbBoxCategorie;
        private System.Windows.Forms.TableLayoutPanel tableLayPnlSujet;
        private System.Windows.Forms.Label lblReponseSujet;
        private System.Windows.Forms.GroupBox grBoxSujet;
        private System.Windows.Forms.Label lblSujetCat;
        private System.Windows.Forms.ComboBox cbBoxSujet;
        private System.Windows.Forms.GroupBox grBoxDescriSujet;
        private System.Windows.Forms.TextBox txtBoxDescriSujet;
    }
}