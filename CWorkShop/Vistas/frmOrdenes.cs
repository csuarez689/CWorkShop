using CWorkShop.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CWorkShop.Vistas
{
    public partial class frmOrdenes : Form
    {
        List<clsReparacion> reparaciones;
        int idEquipo;
        frmMain padre;
        public frmOrdenes(frmMain padre, int idEquipo = 0)
        {
            this.padre = padre;
            this.idEquipo = idEquipo;
            InitializeComponent();
            spcMain.Panel2Collapsed = true;
            spcDatos.Panel2Collapsed = true;
            dtpDesde.MaxDate = DateTime.Today;
            dtpHasta.MaxDate = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            cboBusquedaEstado.SelectedIndex = 0;
            cboTecnico.SelectedIndex = 0;
            dgvReparaciones.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReparaciones.Columns["Tecnico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRepuestos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CargarCombo();
            reparaciones = clsReparacion.Listar();
            dgvReparacionesConfig(reparaciones);
            if (idEquipo > 0) { AgregarNuevaOrden(); }
        }


        //Cargar grilla de reparaciones
        private void dgvReparacionesConfig(List<clsReparacion> lista)
        {
            string busqueda;
            dgvReparaciones.Rows.Clear();
            foreach (clsReparacion reparacion in lista)
            {
                if (reparacion.Anulada) { continue; }
                string cliente = reparacion.Cliente.Apellido + " " + reparacion.Cliente.Nombre;
                string modeloEquipo = reparacion.Equipo.Modelo;
                string tecnico = reparacion.Tecnico.Apellido + " " + reparacion.Tecnico.Nombre;
                busqueda = (cliente + modeloEquipo + tecnico + reparacion.Estado + reparacion.FechaIngreso + reparacion.FechaEntrega + reparacion.CostoTotal).ToUpper();
                dgvReparaciones.Rows.Add(reparacion.Id, cliente, modeloEquipo, tecnico, reparacion.Estado, reparacion.FechaIngreso, reparacion.FechaEntrega, reparacion.CostoTotal, reparacion.IdTecnico, reparacion.IdEquipo,busqueda);
            }
        }
        //Cargar grilla de repuestos utilizados
        private void dgvRepuestosConfig(int reparacionSeleccionada)
        {
            clsReparacion reparacion = clsReparacion.Buscar(reparacionSeleccionada);
            dgvRepuestos.Rows.Clear();
            if (reparacion != null)
            {
                foreach (clsRepuestoUtilizado repuestoUtilizado in reparacion.Repuestos)
                {
                    dgvRepuestos.Rows.Add(repuestoUtilizado.Id, repuestoUtilizado.Codigo, repuestoUtilizado.Descripcion, repuestoUtilizado.PrecioCompra, repuestoUtilizado.PrecioVenta);
                }
            }
        }
        //Agregar nueva orden
        private void AgregarNuevaOrden()
        {
            cboEstado.Enabled = false;
            dgvRepuestos.Rows.Clear();
            tbTecnico.Text = padre.UserLog.Apellido + " " + padre.UserLog.Nombre;
            clsEquipo equipoOrden = clsEquipo.Buscar(idEquipo);
            tbModeloEquipo.Text = equipoOrden.Modelo;
            tbCliente.Text = equipoOrden.Cliente.Apellido + " " + equipoOrden.Cliente.Nombre;
            cboEstado.SelectedIndex = 0;
            spcMain.Panel2Collapsed = false;
            spcDatos.Panel2Collapsed = false;
            btnLimpiar.Show();
            spcDatos.Panel1Collapsed = true;
        }




        //Botonera formulario reparacion ---------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            spcMain.Panel2Collapsed = true;
            spcDatos.Panel2Collapsed = true;
            btnLimpiar.Show();
            spcDatos.Panel2.Enabled = true;
            spcMain.Panel2.Enabled = true;
            spcDatos.Panel1Collapsed = false;
            frmMain.Limpiar(this.spcMain.Panel2);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(this.spcMain.Panel2);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = this.Validar();
            if (msg.Equals(string.Empty))
            {
                //Se esta guardando registro nuevo
                //se esta actualizando registro, por lo tanto no esta disponible btnLimpiar
                if (btnLimpiar.Visible)
                {
                    clsReparacion reparacion = new clsReparacion(rtbAccesorios.Text, rtbDiagnostico.Text, double.Parse(nudCostoManoObra.Value.ToString()), idEquipo, padre.UserLog.Id, cboEstado.SelectedItem.ToString(), DateTime.Today.ToShortDateString(), string.Empty);
                    msg = reparacion.Guardar();
                    if (msg.Length < 5)//si se guardo la reparacion procedo a guardar los imtems de repuestos
                    {
                        GuardarRepuestos(int.Parse(msg));
                        reparaciones = clsReparacion.Listar();
                        dgvReparacionesConfig(reparaciones);
                        btnCancelar.PerformClick();
                        btnLimpiarFiltros.PerformClick();
                    }
                    else
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataGridViewRow fila = dgvReparaciones.CurrentRow;
                    string fechaEntrega = string.Empty;
                    if (cboEstado.SelectedItem.Equals("ENTREGADO")) { fechaEntrega = DateTime.Today.ToShortDateString(); }
                    clsReparacion reparacion = new clsReparacion(rtbAccesorios.Text, rtbDiagnostico.Text, double.Parse(nudCostoManoObra.Value.ToString()), int.Parse(fila.Cells["IdEq"].Value.ToString()), padre.UserLog.Id, cboEstado.SelectedItem.ToString(), fila.Cells["FechaIngreso"].Value.ToString(), fechaEntrega, false, int.Parse(fila.Cells["IdReparacion"].Value.ToString()));
                    msg=reparacion.Actualizar();
                    if (msg.Equals(string.Empty))
                    {
                        GuardarRepuestos(int.Parse(fila.Cells["IdReparacion"].Value.ToString()));
                        reparaciones = clsReparacion.Listar();
                        dgvReparacionesConfig(reparaciones);
                        btnCancelar.PerformClick();
                        btnLimpiarFiltros.PerformClick();
                    }
                    else
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(this.spcMain.Panel2);
            btnVolver.Visible = false;
            rtbAccesorios.ReadOnly = false;
            rtbDiagnostico.ReadOnly = false;
            cboEstado.Enabled = true;
            nudCostoManoObra.Enabled = true;
            btnGuardar.Show();
            btnLimpiar.Show();
            btnCancelar.Show();
            pnlBotoneraRepuestos.Show();
            spcMain.Panel2Collapsed = true;
            spcDatos.Panel2Collapsed = true;
            spcDatos.Panel1Collapsed = false;
        }

        private void nudCostoManoObra_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoTotal();
        }

        //------------------------------------




        //Botonera grilla reparaciones ---------
        private void CargarCombo()
        {
            Dictionary<int, string> source = new Dictionary<int, string>();
            source.Add(0, "TODOS");
            foreach (clsUsuario usuario in clsUsuario.Listar())
            {
                source.Add(usuario.Id, (usuario.Apellido + " " + usuario.Nombre).ToUpper());
            }
            cboTecnico.DataSource = new BindingSource(source, null);
            cboTecnico.DisplayMember = "Value";
            cboTecnico.ValueMember = "Key";
        }

        private void CargarInfoFormulario(DataGridViewRow fila)
        {
            clsReparacion reparacion = clsReparacion.Buscar(int.Parse(fila.Cells["IdReparacion"].Value.ToString()));
            tbCliente.Text = fila.Cells["Cliente"].Value.ToString();
            tbModeloEquipo.Text = fila.Cells["ModeloEquipo"].Value.ToString();
            tbTecnico.Text = fila.Cells["Tecnico"].Value.ToString();
            rtbDiagnostico.Text = reparacion.Diagnostico;
            rtbAccesorios.Text = reparacion.Accesorios;
            cboEstado.SelectedItem = reparacion.Estado;
            nudCostoManoObra.Value = decimal.Parse(reparacion.CostoManoObra.ToString());
            tbFechaIngreso.Text = reparacion.FechaIngreso.ToString();
            tbFechaEntrega.Text = reparacion.FechaEntrega.ToString();
            tbCostoTotal.Text = reparacion.CostoTotal.ToString();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            tbBuscar.Clear();
            cboTecnico.SelectedIndex = 0;
            cboBusquedaEstado.SelectedIndex = 0;
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpHasta.MaxDate;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvReparaciones.CurrentRow;
            string msg = (fila != null && fila.Selected) ? string.Empty : "Debe seleccionar una reparacion.";
            if (msg.Equals(string.Empty))
            {
                msg = (int.Parse(fila.Cells["IdTecnico"].Value.ToString()) == padre.UserLog.Id) ? string.Empty : "No puede editar una reparacion que no le pertenece.";
                msg = (fila.Cells["Estado"].Value.ToString().Equals("ENTREGADO")) ? "No se puede editar una reparacion concluida." : string.Empty;
                if (msg.Equals(string.Empty))
                {
                    CargarInfoFormulario(fila);
                    btnLimpiar.Hide();
                    spcMain.Panel2Collapsed = false;
                    spcDatos.Panel2Collapsed = false;
                    spcDatos.Panel1Collapsed = true;
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvReparaciones.CurrentRow;
            string msg = (fila != null && fila.Selected) ? string.Empty : "Debe seleccionar una reparacion.";
            if (msg.Equals(string.Empty))
            {
                CargarInfoFormulario(fila);
                btnVolver.Visible = true;
                rtbAccesorios.ReadOnly = true;
                rtbDiagnostico.ReadOnly = true;
                cboEstado.Enabled = false;
                nudCostoManoObra.Enabled = false;
                btnGuardar.Hide();
                btnLimpiar.Hide();
                btnCancelar.Hide();
                pnlBotoneraRepuestos.Hide();
                spcMain.Panel2Collapsed = false;
                spcDatos.Panel2Collapsed = false;
                spcDatos.Panel1Collapsed = true;
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvReparaciones.CurrentRow;
            string msg = (fila != null && fila.Selected) ? string.Empty : "Debe seleccionar una reparacion.";
            if (msg.Equals(string.Empty))
            {
                msg = (int.Parse(fila.Cells["IdTecnico"].Value.ToString()) == padre.UserLog.Id) ? string.Empty : "No puede eliminar una reparacion que no le pertenece.";
                msg = (fila.Cells["Estado"].Value.ToString().Equals("ENTREGADO")) ? "No se puede eliminar una reparacion concluida." : string.Empty;
                if (msg.Equals(string.Empty))
                {
                    if (MessageBox.Show("Esta seguro que desea borrar el registro?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        msg = clsReparacion.Eliminar(int.Parse(fila.Cells["IdReparacion"].Value.ToString()));
                        if (msg.Equals(string.Empty))
                        {
                            reparaciones = clsReparacion.Listar();
                            dgvReparacionesConfig(reparaciones);
                        }
                        else
                            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (btnHistorico.Text == "Historico Equipo")
            {
                DataGridViewRow fila = dgvReparaciones.CurrentRow;
                string msg = (fila != null && fila.Selected) ? string.Empty : "Debe seleccionar una reparacion.";
                if (msg.Equals(string.Empty))
                {
                    btnHistorico.Text = "Mostrar Todas";
                    btnLimpiarFiltros.PerformClick();
                    pnlFiltroFecha.Hide();
                    pnlTop.Hide();
                    int idReparacion = int.Parse(fila.Cells["IdReparacion"].Value.ToString());
                    dgvReparacionesConfig(clsReparacion.Buscar(idReparacion).Equipo.Historico);
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pnlFiltroFecha.Show();
                pnlTop.Show();
                btnHistorico.Text = "Historico Equipo";
                dgvReparacionesConfig(reparaciones);
            }

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvReparaciones.Rows)
            {
                fila.Visible = (fila.Cells["Busqueda"].Value.ToString().ToUpper().Trim().Contains(tbBuscar.Text));
            }
        }
        private void cboTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void cboBusquedaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void dgvReparacion_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvReparaciones.CurrentRow;
            if (fila != null && fila.Selected)
            {
                int reparacionSeleccionada = int.Parse(fila.Cells["IdReparacion"].Value.ToString());
                dgvRepuestosConfig(reparacionSeleccionada);
            }
            else
                dgvRepuestos.Rows.Clear();
        }
        //------------------------------------





        //Botonera grilla repuestos ---------
        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            frmListaRepuestos hijo = new frmListaRepuestos(this, true);
            hijo.ShowDialog();
        }

        public void CargarRepuestos(DataGridViewSelectedRowCollection seleccionadas)
        {
            foreach (DataGridViewRow fila in seleccionadas)
            {
                dgvRepuestos.Rows.Add(fila.Cells["Id"].Value, fila.Cells["Codigo"].Value, fila.Cells["Descripcion"].Value, fila.Cells["PrecioCompra"].Value, fila.Cells["PrecioVenta"].Value,0);
            }
        }

        private void btnQuitarRepuesto_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvRepuestos.CurrentRow;
            string msg = (fila != null && fila.Selected) ? string.Empty : "Debe seleccionar un repuesto.";
            if (msg.Equals(string.Empty))
            {
                if (MessageBox.Show("Esta seguro que desea quitar el repuesto?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int id = int.Parse(fila.Cells["Id"].Value.ToString());
                    clsRepuestoUtilizado repuesto = clsRepuestoUtilizado.Buscar(id);
                    if (repuesto != null) { msg = clsRepuestoUtilizado.Eliminar(id); }
                    if (msg.Equals(string.Empty)) { dgvRepuestos.Rows.Remove(fila); }
                    else { MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    CalcularCostoTotal();
                }
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------


        //Calculo de costo total
        private double CalcularCostoTotal()
        {
            double costo = 0;
            costo += double.Parse(nudCostoManoObra.Value.ToString());
            foreach(DataGridViewRow fila in dgvRepuestos.Rows)
            {
                costo += double.Parse(fila.Cells["PrecioVenta"].Value.ToString());
            }
            tbCostoTotal.Text = string.Format("{0:C2}",costo);

            return costo;
        }

        //Filtrar
        private void Filtrar()
        {
            if (reparaciones != null) { 
                List<clsReparacion> filtrar = reparaciones;
                //filtrar = filtrar.FindAll(x => (Convert.ToDateTime(x.FechaIngreso) > dtpDesde.Value) && (Convert.ToDateTime(x.FechaEntrega) < dtpDesde.Value));
                if (Convert.ToInt32(cboTecnico.SelectedValue)!=0) { filtrar = filtrar.FindAll(x => x.IdTecnico == Convert.ToInt32(cboTecnico.SelectedValue)); } 
                if (cboBusquedaEstado.SelectedItem != null) { if (!cboBusquedaEstado.SelectedItem.Equals("TODOS")) { filtrar = filtrar.FindAll(x => x.Estado.Equals(cboBusquedaEstado.SelectedItem)); } }
                if (filtrar == null) { dgvReparacionesConfig(new List<clsReparacion>()); }
                else
                    dgvReparacionesConfig(filtrar);
                tbBuscar.Clear();
            }


        }

        //Guardar items repuestos
        private void GuardarRepuestos(int idReparacion)
        {
            clsRepuestoUtilizado aux;
            foreach(DataGridViewRow fila in dgvRepuestos.Rows)
            {
                if (fila != null) {
                    if (fila.Cells["IdRep"].Value != null) { continue; }//si no posee reparacion asignada es que aun no se ha guardado
                    aux = new clsRepuestoUtilizado(fila.Cells["Codigo"].Value.ToString(), fila.Cells["Descripcion"].Value.ToString(), double.Parse(fila.Cells["PrecioCompra"].Value.ToString()), double.Parse(fila.Cells["PrecioVenta"].Value.ToString()), idReparacion);
                    aux.Guardar();
                }
            }
        }
        //Validacion campos form reparacion
        private string Validar()
        {
            //Regex nameApellido = new Regex(@"^[a-zA-Z]+(([a-zA-Z ])?[a-zA-Z]*)*$");
            //Regex dni = new Regex(@"^\d{8}(?:[-\s]\d{4})?$");
            //Regex mail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
            //Regex telefono = new Regex(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$");
            //Regex contraseña = new Regex(@"^(?=\w*\d)(?=\w*[a-z])\S{5,16}$");
            //Regex direccion = new Regex(@"[a-zA-Z1-9À-ÖØ-öø-ÿ]+\.?(( |\-)[a-zA-Z1-9À-ÖØ-öø-ÿ]+\.?)* (((#|[nN][oO]\.?) ?)?\d{1,4}(( ?[a-zA-Z0-9\-]+)+)?)");
            //if (!dni.IsMatch(tbCliente.Text)) { return "Campo dni incorrecto. Ingrese solo numeros."; }
            //if (!nameApellido.IsMatch(tbModeloEquipo.Text)) { return "Campo nombre incorrecto."; }
            //if (!nameApellido.IsMatch(tbTecnico.Text)) { return "Campo apellido incorrecto."; }
            //if (!mail.IsMatch(tbCorreo.Text)) { return "Campo correo incorrecto."; }
            //if (!telefono.IsMatch(tbTelefono.Text)) { return "Campo telefono incorrecto."; }
            //if (!direccion.IsMatch(tbDireccion.Text)) { return "Campo direccion incorrecto."; }

            return string.Empty;
        }

        private void dgvRepuestos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularCostoTotal();
        }


    }
}
