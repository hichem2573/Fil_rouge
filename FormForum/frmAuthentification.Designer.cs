﻿namespace FormForum
{
    partial class FrmAuthentification
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
            this.btConnexion = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gpBoxAuthentification = new System.Windows.Forms.GroupBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbNom_Utilisateur = new System.Windows.Forms.Label();
            this.grBoxChangementMpd = new System.Windows.Forms.GroupBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.gpBoxAuthentification.SuspendLayout();
            this.grBoxChangementMpd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnexion
            // 
            this.btConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnexion.Image = global::FormForum.Properties.Resources.reseau_recevoir_transmettre_icone_8164_32;
            this.btConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnexion.Location = new System.Drawing.Point(53, 324);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(114, 31);
            this.btConnexion.TabIndex = 6;
            this.btConnexion.Text = "&Submit";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancel.Image = global::FormForum.Properties.Resources.annuler_icone_8717_32;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(452, 324);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(115, 31);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // gpBoxAuthentification
            // 
            this.gpBoxAuthentification.Controls.Add(this.txtBoxPassword);
            this.gpBoxAuthentification.Controls.Add(this.txtBoxLogin);
            this.gpBoxAuthentification.Controls.Add(this.lblPassword);
            this.gpBoxAuthentification.Controls.Add(this.lbNom_Utilisateur);
            this.gpBoxAuthentification.Location = new System.Drawing.Point(12, 12);
            this.gpBoxAuthentification.Name = "gpBoxAuthentification";
            this.gpBoxAuthentification.Size = new System.Drawing.Size(597, 165);
            this.gpBoxAuthentification.TabIndex = 6;
            this.gpBoxAuthentification.TabStop = false;
            this.gpBoxAuthentification.Text = "Authentification";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(223, 106);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.Text = "**********";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(223, 44);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(150, 20);
            this.txtBoxLogin.TabIndex = 1;
            this.txtBoxLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // lbNom_Utilisateur
            // 
            this.lbNom_Utilisateur.AutoSize = true;
            this.lbNom_Utilisateur.Location = new System.Drawing.Point(38, 47);
            this.lbNom_Utilisateur.Name = "lbNom_Utilisateur";
            this.lbNom_Utilisateur.Size = new System.Drawing.Size(84, 13);
            this.lbNom_Utilisateur.TabIndex = 0;
            this.lbNom_Utilisateur.Text = "Nom Utilisateur :";
            // 
            // grBoxChangementMpd
            // 
            this.grBoxChangementMpd.Controls.Add(this.txtBoxNewPassword);
            this.grBoxChangementMpd.Controls.Add(this.lblNewPassword);
            this.grBoxChangementMpd.Location = new System.Drawing.Point(12, 183);
            this.grBoxChangementMpd.Name = "grBoxChangementMpd";
            this.grBoxChangementMpd.Size = new System.Drawing.Size(597, 119);
            this.grBoxChangementMpd.TabIndex = 7;
            this.grBoxChangementMpd.TabStop = false;
            this.grBoxChangementMpd.Text = "Changement_Password";
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(223, 49);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxNewPassword.TabIndex = 5;
            this.txtBoxNewPassword.Text = "**********";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(38, 52);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(117, 13);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "Nouveu mot de passe :";
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(621, 367);
            this.Controls.Add(this.grBoxChangementMpd);
            this.Controls.Add(this.gpBoxAuthentification);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConnexion);
            this.MaximumSize = new System.Drawing.Size(637, 406);
            this.MinimumSize = new System.Drawing.Size(530, 306);
            this.Name = "frmAuthentification";
            this.Text = "Authentification";
            this.gpBoxAuthentification.ResumeLayout(false);
            this.gpBoxAuthentification.PerformLayout();
            this.grBoxChangementMpd.ResumeLayout(false);
            this.grBoxChangementMpd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gpBoxAuthentification;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lbNom_Utilisateur;
        private System.Windows.Forms.GroupBox grBoxChangementMpd;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
    }
}