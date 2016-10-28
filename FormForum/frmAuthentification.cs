using ControlleurFil_Rouge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForum
{
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            FrmAccueil.CurrentUtilisateur = Controller.Login(txtBoxLogin.Text, txtBoxPassword.Text); 
            if(FrmAccueil.CurrentUtilisateur != null)
            {
                FrmAccueil.Isconnected = true;
                FrmAccueil.IsRoleModera = FrmAccueil.CurrentUtilisateur.IsRoleModera;
                this.Close();
            }
            else
            {
                FrmAccueil.Isconnected = false;
                MessageBox.Show("Votre Login ou votre mot de passe sont incorrect!", "Veuillez saisir vos identifiants svp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
