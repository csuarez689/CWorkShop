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
            spcMain.Panel2Collapsed = true;
            spcDatos.Panel2Collapsed = true;
            spcForms.Panel1Collapsed = true;
            spcForms.Panel2Collapsed = true;
            dgvClienteConfig();
            dgvClientes.Columns["Correo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquipos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        //Cargar grilla de clientes
        private void dgvClienteConfig()
        {
            List<clsCliente> lista = clsCliente.Listar();
            dgvClientes.Rows.Clear();
            string busqueda;
            foreach(clsCliente usuario in lista)
            {
                busqueda = (usuario.Dni + usuario.Nombre + usuario.Apellido + usuario.Telefono + usuario.Mail + usuario.Direccion).ToUpper().Trim();
                dgvClientes.Rows.Add(usuario.Id, usuario.Dni, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Mail, usuario.Direccion, busqueda);
            }
        }
        //Cargar grilla de equipos
        private void dgvEquipoConfig(int clienteSeleccionado)
        {
            clsCliente cliente = clsCliente.Buscar(clienteSeleccionado);
            dgvEquipos.Rows.Clear();
            if (cliente != null) { 
                foreach (clsEquipo equipo in cliente.Equipos)
                {
                    dgvEquipos.Rows.Add(equipo.Id, equipo.NroSerie, equipo.Modelo, equipo.Marca, equipo.Tipo, equipo.Descripcion, equipo.IdCliente);
                }
            }
        }


        //Botonera grilla clientes ---------
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = tbBuscar.Text.ToUpper().Trim();
            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                fila.Visible = (fila.Cells["Busqueda"].Value.ToString().ToUpper().Trim().Contains(texto));
            }

            dgvClientes.ClearSelection();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            tbDni.Enabled = true;
            spcForms.Panel2Collapsed = true;
            spcForms.Panel1Collapsed = false;
            btnFormClienteLimpiar.Show();
            spcMain.Panel2Collapsed = false;
            spcMain.Panel1.Enabled = false;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            tbDni.Enabled = false;
            DataGridViewRow fila = dgvClientes.CurrentRow;
            bool sel = fila.Selected;
            string msg = (sel) ? string.Empty : "Debe seleccionar un cliente.";
            if (msg.Equals(string.Empty))
            {
                tbDni.Text = fila.Cells["Dni"].Value.ToString();
                tbApellido.Text = fila.Cells["Apellido"].Value.ToString();
                tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
                tbCorreo.Text = fila.Cells["Correo"].Value.ToString();
                tbDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                tbTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                btnFormClienteLimpiar.Hide();
                spcForms.Panel2Collapsed = true;
                spcForms.Panel1Collapsed = false;
                spcMain.Panel2Collapsed = false;
                spcMain.Panel1.Enabled = false;
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            if (fila.Selected)
            {
                if(MessageBox.Show("¿Esta seguro que desea borrar el cliente?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string msg = clsCliente.Eliminar(fila.Cells["Dni"].Value.ToString());
                    if (msg.Equals(string.Empty))
                        dgvClienteConfig();
                    else
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
            else
                MessageBox.Show("Debe seleccionar un cliente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            spcDatos.Panel2Collapsed = !spcDatos.Panel2Collapsed;
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            if (fila != null)
            {
                int clienteSelecionado = int.Parse(fila.Cells["IdCliente"].Value.ToString());
                dgvEquipoConfig(clienteSelecionado);
            }
            else
                dgvEquipos.Rows.Clear();
        }
        //------------------------------------



        //Botonera formulario clientes ---------
        private void btnFormClienteCancelar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcForms.Panel1);
            spcForms.Panel1Collapsed = true;
            spcMain.Panel2Collapsed = true;
            spcMain.Panel1.Enabled = true;
            btnFormClienteLimpiar.Show();
        }

        private void btnFormClienteLimpiar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcForms.Panel1);
        }

        private void btnFormClienteGuardar_Click(object sender, EventArgs e)
        {
            string msg = this.ValidarCliente();
            if (msg.Equals(string.Empty))
            {
                clsCliente cliente = new clsCliente(tbDni.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text);
                //Se esta guardando registro nuevo
                //se esta actualizando registro, por lo tanto no esta disponible btnLimpiar
                msg = (btnFormClienteLimpiar.Visible) ? cliente.Guardar() : cliente.Actualizar();
                if (msg.Equals(string.Empty))
                {
                    dgvClienteConfig();
                    btnFormClienteCancelar.PerformClick();
                    tbBuscar.Clear();
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------



        //Botonera grilla equipos ---------
        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            spcForms.Panel1Collapsed = true;
            spcForms.Panel2Collapsed = false;
            btnFormEquipoLimpiar.Show();
            spcMain.Panel2Collapsed = false;
            spcMain.Panel1.Enabled = false;
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvEquipos.CurrentRow;
            if (fila != null)
            {
                tbNroSerie.Text = fila.Cells["NumeroDeSerie"].Value.ToString();
                tbModelo.Text = fila.Cells["Modelo"].Value.ToString();
                tbDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                tbMarca.Text = fila.Cells["Marca"].Value.ToString();
                tbTipoEquipo.Text = fila.Cells["TipoDeEquipo"].Value.ToString();
                btnFormEquipoLimpiar.Hide();
                spcForms.Panel1Collapsed = true;
                spcForms.Panel2Collapsed = false;
                spcMain.Panel2Collapsed = false;
                spcMain.Panel1.Enabled = false;
            }
            else
                MessageBox.Show("El cliente no posee equipos registrados para editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvEquipos.CurrentRow;
            if (fila != null && fila.Selected)
            {
                if (MessageBox.Show("¿Esta seguro que desea borrar el equipo?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string msg = clsEquipo.Eliminar(int.Parse(fila.Cells["IdEquipo"].Value.ToString()));
                    if (msg.Equals(string.Empty))
                        dgvEquipoConfig(int.Parse(dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString()));
                    else
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("El cliente no posee equipos registrados para eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea agregar una orden de trabajo sobre este equipo?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ((Button)((Panel)this.ParentForm.Controls["pMenu"]).Controls["btnOrdenes"]).PerformClick();
                this.Dispose();
            }
        }
        //------------------------------------



        //Botonera formulario equipos ---------
        private void btnFormEquipoLimpiar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcForms.Panel2);
        }

        private void btnFormEquipoCancelar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcForms.Panel2);
            spcMain.Panel2Collapsed = true;
            spcForms.Panel2Collapsed = true;
            spcMain.Panel1.Enabled = true;
            btnFormEquipoLimpiar.Show();
        }

        private void btnFormEquipoGuardar_Click(object sender, EventArgs e)
        {

            string msg = this.ValidarEquipo();
            if (msg.Equals(string.Empty))
            {
                int clienteSeleccionado = int.Parse(dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString());
                //Se esta guardando registro nuevo
                //se esta actualizando registro, por lo tanto no esta disponible btnLimpiar
                string descripcion = (tbDescripcion.Text.Trim().Equals(string.Empty)) ? "Sin Descripcion" : tbDescripcion.Text.Trim();
                if (btnFormEquipoLimpiar.Visible == true)
                {//Guardar nueva entrada
                    clsEquipo equipo = new clsEquipo(tbMarca.Text, tbTipoEquipo.Text, tbNroSerie.Text, tbModelo.Text, tbDescripcion.Text, clienteSeleccionado);
                    msg = equipo.Guardar();
                }
                else
                {//Actualizar equipo
                    clsEquipo equipo = new clsEquipo(tbMarca.Text, tbTipoEquipo.Text, tbNroSerie.Text, tbModelo.Text, descripcion, clienteSeleccionado, int.Parse(dgvEquipos.CurrentRow.Cells["IdEquipo"].Value.ToString()));
                    msg = equipo.Actualizar();
                }
                if (msg.Equals(string.Empty))
                {
                    dgvEquipoConfig(clienteSeleccionado);
                    btnFormEquipoCancelar.PerformClick();
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------



        //Validacion campos form cliente
        private string ValidarCliente()
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

        //Validacion campos form equipo
        private string ValidarEquipo()
        {
            Regex nroSerie = new Regex(@"^[A-Z0-9]([A-Z0-9]){4,20}$");
            Regex modelo = new Regex(@"^[A-Z0-9]([A-Z0-9\-]){4,20}$");
            Regex marcaTipo= new Regex(@"^[A-Z]+[A-Z ]{1,19}$");
            if (!nroSerie.IsMatch(tbNroSerie.Text)) { return "Campo numero de serie incorrecto. (Min 4, Max 20)."; }
            if (!modelo.IsMatch(tbModelo.Text)) { return "Campo modelo incorrecto."; }
            if (!marcaTipo.IsMatch(tbMarca.Text)) { return "Campo marca incorrecto."; }
            if (!marcaTipo.IsMatch(tbTipoEquipo.Text)) { return "Campo tipo de equipo incorrecto."; }

            return string.Empty;
        }
    }
}
