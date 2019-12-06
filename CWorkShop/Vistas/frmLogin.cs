using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWorkShop.Clases;

namespace CWorkShop.Vistas
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbDNI_Enter(object sender, EventArgs e)
        {
            if (tbDNI.Text == "DNI")
                tbDNI.Text = string.Empty;
        }

        private void tbDNI_Leave(object sender, EventArgs e)
        {
            if (tbDNI.Text==string.Empty)
                tbDNI.Text = "DNI";
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
            string msg = clsUsuario.Login(tbDNI.Text, tbContraseña.Text);
            if (msg.Equals(string.Empty))
            {
                frmMain main = new frmMain(this, tbDNI.Text);
                main.Show();
                tbDNI.Clear();
                tbDNI.Text = "DNI";
                tbDNI.Focus();
                tbContraseña.Clear();
                tbContraseña.Text = "CONTRASEÑA";
                tbContraseña.UseSystemPasswordChar = false;
                this.Hide();
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new frmMisDatos().ShowDialog();
        }
    }
}
