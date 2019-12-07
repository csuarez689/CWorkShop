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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            spcCliente.Panel2Collapsed = true;
            dgvConfig();
            dgvClientes.Columns["Correo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcCliente.Panel2);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbDni.Enabled = true;
            spcCliente.Panel2Collapsed = false;
            btnLimpiar.Show();
            spcCliente.Panel1.Enabled = false;
            dgvClientes.ClearSelection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcCliente.Panel2);
            spcCliente.Panel2Collapsed = true;
            dgvClientes.ClearSelection();
            spcCliente.Panel1.Enabled = true;
            btnLimpiar.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = this.Validar();
            if (msg.Equals(string.Empty))
            {
                clsCliente cliente = new clsCliente(tbDni.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text);
                //Se esta guardando registro nuevo
                //se esta actualizando registro, por lo tanto no esta disponible btnLimpiar
                msg = (btnLimpiar.Visible) ? cliente.Guardar() :  cliente.Actualizar();
                if (msg.Equals(string.Empty))
                {
                    dgvConfig();
                    btnCancelar.PerformClick();
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvConfig()
        {
            List<clsCliente> lista = clsCliente.Listar();
            dgvClientes.Rows.Clear();
            foreach(clsCliente usuario in lista)
            {
                dgvClientes.Rows.Add(usuario.Id, usuario.Dni, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Mail, usuario.Direccion);
            }
            dgvClientes.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbDni.Enabled = false;
            DataGridViewRow fila = dgvClientes.CurrentRow;
            bool sel = fila.Selected;
            string msg = (sel) ? string.Empty : "Debe seleccionar un registro.";
            if (msg.Equals(string.Empty))
            {
                tbDni.Text = fila.Cells["Dni"].Value.ToString();
                tbApellido.Text = fila.Cells["Apellido"].Value.ToString();
                tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
                tbCorreo.Text = fila.Cells["Correo"].Value.ToString();
                tbDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                tbTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                btnLimpiar.Hide();
                spcCliente.Panel2Collapsed = false;
                spcCliente.Panel1.Enabled = false;
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            bool sel = fila.Selected;
            string msg = (sel) ? "¿Esta seguro que desea borrar el registro?" : "Debe seleccionar un registro.";
            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            msg= clsCliente.Eliminar(fila.Cells["Dni"].Value.ToString());
            if (msg.Equals(string.Empty))
            {
                dgvConfig();
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string Validar()
        {
            Regex nameApellido = new Regex(@"^[a-zA-Z]+(([a-zA-Z ])?[a-zA-Z]*)*$");
            Regex dni = new Regex(@"^\d{8}(?:[-\s]\d{4})?$");
            Regex mail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
            Regex telefono = new Regex(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$");
            Regex contraseña = new Regex(@"^(?=\w*\d)(?=\w*[a-z])\S{5,16}$");
            Regex direccion = new Regex(@"[a-zA-Z1-9À-ÖØ-öø-ÿ]+\.?(( |\-)[a-zA-Z1-9À-ÖØ-öø-ÿ]+\.?)* (((#|[nN][oO]\.?) ?)?\d{1,4}(( ?[a-zA-Z0-9\-]+)+)?)");
            if (!dni.IsMatch(tbDni.Text)) { return "Campo dni incorrecto. Ingrese solo numeros."; }
            if (!nameApellido.IsMatch(tbNombre.Text)) { return "Campo nombre incorrecto."; }
            if (!nameApellido.IsMatch(tbApellido.Text)) { return "Campo apellido incorrecto."; }
            if (!mail.IsMatch(tbCorreo.Text)) { return "Campo correo incorrecto."; }
            if (!telefono.IsMatch(tbTelefono.Text)) { return "Campo telefono incorrecto."; }
            if (!direccion.IsMatch(tbDireccion.Text)) { return "Campo direccion incorrecto."; }
            
            return string.Empty;
        }
    }
}
