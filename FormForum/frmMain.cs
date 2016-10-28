using ControlleurFil_Rouge;
using Fil_Rouge_Forum;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            using (FrmAuthentification frmAuthentification = new FrmAuthentification())
            {
                frmAuthentification.ShowDialog();
            }
        }

        private void btEditPassword_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Controller.GetSujetsByCategorie((int)cbBoxCategorie.SelectedValue) != null)
            {
                cbBoxSujet.DataSource = Controller.GetSujetsByCategorie((int)cbBoxCategorie.SelectedValue);
            }
            else
            {
                Sujet s1 = new Sujet(0, "aucun sujet");
                List<Sujet> s2 = new List<Sujet>();
                s2.Add(s1);
                cbBoxSujet.DataSource = s2; 
            }
        }

        private void cbBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbBoxCategorie.ValueMember = "IdCat";
            cbBoxCategorie.DisplayMember = "Nom";

            cbBoxSujet.ValueMember = "IdSujet";
            cbBoxSujet.DisplayMember = "Titre";

            cbBoxCategorie.DataSource = Controller.GetAllCategories();
            cbBoxSujet.DataSource = Controller.GetSujetsByCategorie((int)cbBoxCategorie.SelectedValue);
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
