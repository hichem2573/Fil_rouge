﻿using System;
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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main man = new Main();
            man.Show();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
