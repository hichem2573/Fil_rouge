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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ac = new Main();
            ac.Show();
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxConfirmNewPwd_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
