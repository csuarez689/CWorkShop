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
using System.Text.RegularExpressions;

namespace CWorkShop.Vistas
{
    public partial class frmLogin : Form
    {
        //Variables para ubicacion y movimiento de form
        public int xClick = 0, yClick = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbDNI_Enter(object sender, EventArgs e)
        {
            if (tbDni.Text == "DNI")
                tbDni.Text = string.Empty;
        }

        private void tbDNI_Leave(object sender, EventArgs e)
        {
            if (tbDni.Text==string.Empty)
                tbDni.Text = "DNI";
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
            string msg = Validar();
            if (msg.Equals(string.Empty)) { 
                msg = clsUsuario.Login(tbDni.Text, tbContraseña.Text);
                if (msg.Equals(string.Empty))
                {
                    frmMain main = new frmMain(this, tbDni.Text);
                    main.Show();
                    tbDni.Clear();
                    tbDni.Text = "DNI";
                    tbDni.Focus();
                    tbContraseña.Clear();
                    tbContraseña.Text = "CONTRASEÑA";
                    tbContraseña.UseSystemPasswordChar = false;
                    this.Hide();
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
              MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Comportamiento para darle movimiento al formulario mediante el mouse
        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            tbContraseña.Text="CONTRASEÑA";
            tbContraseña.UseSystemPasswordChar = false;
            tbDni.Text="DNI";
            new frmMisDatos().Show();
        }

        //Validacion campos del formulario
        private string Validar()
        {
            Regex dni = new Regex(@"^\d{8}(?:[-\s]\d{4})?$");
            if (!dni.IsMatch(tbDni.Text)) { return "Campo dni incorrecto.  Ingrese solo numeros."; }
            if(tbContraseña.Text=="CONTRASEÑA" || tbContraseña.Text == string.Empty) { return "Debe ingresar su contraseña."; }
            return string.Empty;
        }
    }
}
