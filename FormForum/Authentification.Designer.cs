namespace FormForum
{
    partial class Authentification
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnexion
            // 
            this.btConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnexion.Image = global::FormForum.Properties.Resources.reseau_recevoir_transmettre_icone_8164_32;
            this.btConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnexion.Location = new System.Drawing.Point(62, 308);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(114, 31);
            this.btConnexion.TabIndex = 4;
            this.btConnexion.Text = "&Submit";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancel.Image = global::FormForum.Properties.Resources.annuler_icone_8717_32;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(450, 308);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(115, 31);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.txtBoxLogin);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 125);
            this.panel1.TabIndex = 6;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.Location = new System.Drawing.Point(177, 73);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.Text = "Mot de passe";
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxLogin.Location = new System.Drawing.Point(177, 19);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(150, 20);
            this.txtBoxLogin.TabIndex = 0;
            this.txtBoxLogin.Text = "Login";
            this.txtBoxLogin.TextChanged += new System.EventHandler(this.txtBoxLogin_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password : ";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(27, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "User Name : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtBoxConfirmNewPwd);
            this.panel2.Controls.Add(this.txtBoxNewPassword);
            this.panel2.Controls.Add(this.lblConfirmPassword);
            this.panel2.Controls.Add(this.lblNewPassword);
            this.panel2.Location = new System.Drawing.Point(12, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 132);
            this.panel2.TabIndex = 7;
           
            // 
            // txtBoxConfirmNewPwd
            // 
            this.txtBoxConfirmNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConfirmNewPwd.Location = new System.Drawing.Point(177, 88);
            this.txtBoxConfirmNewPwd.Name = "txtBoxConfirmNewPwd";
            this.txtBoxConfirmNewPwd.Size = new System.Drawing.Size(150, 20);
            this.txtBoxConfirmNewPwd.TabIndex = 3;
            this.txtBoxConfirmNewPwd.Text = "***********";
            this.txtBoxConfirmNewPwd.TextChanged += new System.EventHandler(this.txtBoxConfirmNewPwd_TextChanged);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNewPassword.Location = new System.Drawing.Point(177, 25);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(150, 20);
            this.txtBoxNewPassword.TabIndex = 2;
            this.txtBoxNewPassword.Text = "***********";
            this.txtBoxNewPassword.TextChanged += new System.EventHandler(this.txtBoxNewPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(27, 91);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(100, 13);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password : ";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(27, 25);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(621, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConnexion);
            this.MaximumSize = new System.Drawing.Size(637, 406);
            this.MinimumSize = new System.Drawing.Size(530, 306);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxConfirmNewPwd;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
    }
}