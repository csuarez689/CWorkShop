using CWorkShop.Clases;
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
    public partial class frmMisDatos : Form
    {
        clsUsuario userLog;
        frmMain padre;
        public frmMisDatos(frmMain padre, clsUsuario userLog)
        {

            InitializeComponent();
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
            string msg = (tbContraseña.Text.Equals(tbConfirmar.Text)) ? string.Empty : "Las contraseñas no coinciden.";
            if (msg.Equals(string.Empty)) { 
                userLog.Dni = tbDni.Text;
                userLog.Nombre = tbNombre.Text;
                userLog.Apellido = tbApellido.Text;
                userLog.Telefono = tbTelefono.Text;
                userLog.Mail = tbCorreo.Text;
                if(!tbContraseña.Text.Equals(string.Empty))
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
    }
}
