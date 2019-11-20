using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblLogin.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDNI_Enter(object sender, EventArgs e)
        {
            if (tbDNI.Text == "DNI")
            {
                tbDNI.Text = string.Empty;
            }
        }

        private void tbDNI_Leave(object sender, EventArgs e)
        {
            if (tbDNI.Text==string.Empty)
            {
                tbDNI.Text = "DNI";
            }
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "CONTRASEÑA")
            {
                tbContraseña.Text = string.Empty;
                tbContraseña.UseSystemPasswordChar = true;
            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == string.Empty)
            {
                tbContraseña.UseSystemPasswordChar = false;
                tbContraseña.Text = "CONTRASEÑA"; 
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(this);
            main.Show();
            this.Hide();
        }
    }
}
