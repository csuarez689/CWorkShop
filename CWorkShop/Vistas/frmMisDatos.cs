using CWorkShop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Vistas
{
    public partial class frmMisDatos : Form
    {
        clsUsuario userLog;
        frmMain padre;
        public frmMisDatos()
        {
            InitializeComponent();
            tbContraseña.UseSystemPasswordChar = true;
            tbConfirmar.UseSystemPasswordChar = true;
            lblTitulo.Text = "REGISTRO";
            btnGuardar.Hide();
            btnLimpiar.Show();
            btnRegistrar.Show();
            userLog = new clsUsuario();
            pbCerrar.Show();
        }
        public frmMisDatos(frmMain padre, clsUsuario userLog)
        {
            InitializeComponent();
            lblTitulo.Text = "MIS DATOS";
            tbDni.Enabled = false;
            tbContraseña.UseSystemPasswordChar = true;
            tbConfirmar.UseSystemPasswordChar = true;
            this.padre = padre;
            this.userLog = userLog;
            tbDni.Text = userLog.Dni;
            tbNombre.Text = userLog.Nombre;
            tbApellido.Text = userLog.Apellido;
            tbCorreo.Text = userLog.Mail;
            tbTelefono.Text = userLog.Telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = this.Validar();
            if (msg.Equals(string.Empty))
            {
                userLog.Nombre = tbNombre.Text;
                userLog.Apellido = tbApellido.Text;
                userLog.Telefono = tbTelefono.Text;
                userLog.Mail = tbCorreo.Text;
                if (!tbContraseña.Text.Equals(string.Empty))
                    userLog.Contraseña = tbContraseña.Text;
                msg = userLog.Actualizar();
                if (msg.Equals(String.Empty))
                {
                    padre.ActualizarBtnDatos(userLog);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string msg = Validar();
            if (msg.Equals(string.Empty))
            {
                userLog.Dni = tbDni.Text;
                userLog.Nombre = tbNombre.Text;
                userLog.Apellido = tbApellido.Text;
                userLog.Telefono = tbTelefono.Text;
                userLog.Mail = tbCorreo.Text;
                userLog.Contraseña = tbContraseña.Text;
                msg = userLog.Guardar();
                this.Close();
            }
            else
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Validacion campos del formulario
        private string Validar()
        {
            Regex nameApellido = new Regex(@"^[a-zA-Z]+(([a-zA-Z ])?[a-zA-Z]*)*$");
            Regex dni = new Regex(@"^\d{8}(?:[-\s]\d{4})?$");
            Regex mail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
            Regex telefono = new Regex(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$");
            Regex contraseña = new Regex(@"^(?=\w*\d)(?=\w*[a-z])\S{5,16}$");
            if (!dni.IsMatch(tbDni.Text)) { return "Campo dni incorrecto.  Ingrese solo numeros.346"; }
            if (!nameApellido.IsMatch(tbNombre.Text)) { return "Campo nombre incorrecto."; }
            if (!nameApellido.IsMatch(tbApellido.Text)) { return "Campo apellido incorrecto."; }
            if (!mail.IsMatch(tbCorreo.Text)) { return "Campo correo incorrecto."; }
            if (!telefono.IsMatch(tbTelefono.Text)) { return "Campo telefono incorrecto."; }
            if (userLog.Contraseña == string.Empty || (tbContraseña.Text != string.Empty && tbConfirmar.Text != string.Empty))
            {
                if (!contraseña.IsMatch(tbContraseña.Text)) { return "Campo contraseña incorrecto. La contraseña debe ser alfanumerica, entre 5 y 16 caracteres."; }
            }
            if (!tbContraseña.Text.Equals(tbConfirmar.Text)) { return "Las contraseñas no coinciden."; }
            return string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control x in pnlContainer.Controls)
            {
                if (x is TextBox)
                    ((TextBox)x).Clear();
                else if (x is ComboBox)
                    ((ComboBox)x).SelectedIndex = -1;
            }
        }
    }
}
