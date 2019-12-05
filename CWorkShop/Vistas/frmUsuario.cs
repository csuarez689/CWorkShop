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
    public partial class frmUsuario : Form
    {
        List<clsUsuario> lista;
        clsUsuario userLog;
        public frmUsuario(clsUsuario userLog)
        {
            InitializeComponent();
            this.userLog = userLog;
            spcUsuario.Panel2Collapsed = true;
            dgvConfig();
            dgvUsuarios.Columns["Correo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcUsuario.Panel2);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            spcUsuario.Panel2Collapsed = false;
            btnLimpiar.Show();
            spcUsuario.Panel1.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcUsuario.Panel2);
            spcUsuario.Panel2Collapsed = true;
            dgvUsuarios.ClearSelection();
            spcUsuario.Panel1.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                clsUsuario newUser = new clsUsuario(tbDni.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbTelefono.Text, cboRol.SelectedItem.ToString(), false, tbDni.Text);
                string msg = newUser.Guardar();
                if ( msg.Equals(String.Empty)) {
                    dgvConfig();
                    btnCancelar.PerformClick();
                }
                else {
                    btnCancelar.PerformClick();
                    MessageBox.Show(msg,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
        }

        private void dgvConfig()
        {
            lista = clsUsuario.Listar();
            dgvUsuarios.Rows.Clear();
            foreach(clsUsuario usuario in lista)
            {
                if (userLog.Dni.Equals(usuario.Dni))
                    continue;
                string des = (usuario.Borrado) ? "Deshabilitado" : "Habilitado";
                dgvUsuarios.Rows.Add(usuario.Id, usuario.Dni, usuario.Nombre, usuario.Apellido, usuario.Mail, usuario.Telefono, usuario.Rol, des);
            }
            dgvUsuarios.ClearSelection();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvUsuarios.CurrentRow;
            string opc = (fila.Cells["Estado"].Value.ToString() == "Habilitado") ? "deshabilitar" : "habilitar";
            if (MessageBox.Show("Esta seguro de "+opc+" el usuario.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
                
                string res= clsUsuario.SaveState(fila.Cells["DNI"].Value.ToString());
                if (res.Equals(string.Empty)) { dgvConfig(); }
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btnDeshabilitar.Text=(dgvUsuarios.CurrentRow.Cells["Estado"].Value.Equals("SI")) ? "Habilitar" : "Deshabilitar";
        }
    }
}
