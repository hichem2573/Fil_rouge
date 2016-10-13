namespace FormForum
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btQuitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btConnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuitter.AutoSize = true;
            this.btQuitter.Image = global::FormForum.Properties.Resources.quitte;
            this.btQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.Location = new System.Drawing.Point(712, 425);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(122, 41);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::FormForum.Properties.Resources.forum_discussion;
            this.pictureBox1.Location = new System.Drawing.Point(333, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btConnexion
            // 
            this.btConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnexion.AutoSize = true;
            this.btConnexion.Image = global::FormForum.Properties.Resources.ConnexionForm;
            this.btConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnexion.Location = new System.Drawing.Point(99, 428);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(175, 38);
            this.btConnexion.TabIndex = 2;
            this.btConnexion.Text = "Accès au forum";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.btConnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btQuitter);
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(780, 550);
            this.Name = "Accueil";
            this.Text = "Communauté des développeurs de 2ISA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btConnexion;
    }
}

