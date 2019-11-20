﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Vistas
{
    public partial class frmMain : Form
    {
        frmLogin login;
        public frmMain(frmLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
