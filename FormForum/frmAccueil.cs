using Fil_Rouge_ForumDLL;
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
    public partial class FrmAccueil : Form
    {
        static internal bool IsRoleModera;
        static internal Utilisateur CurrentUtilisateur;
        static internal bool Isconnected;

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            using (FrmMain frmMain = new FrmMain())
            {
                frmMain.ShowDialog();
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
