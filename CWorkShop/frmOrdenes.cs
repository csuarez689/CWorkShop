using CWorkShop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CWorkShop.Vistas
{
    public partial class frmOrdenes : Form
    {
        List<clsReparacion> reparaciones;
        int idReparacionTemp; //para trabajar sobre los repuestos
        int idEquipo;
        frmMain padre;
        public frmOrdenes(frmMain padre, int idEquipo = 0)
        {
            this.idReparacionTemp = 0;
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
            reparaciones = clsReparacion.Listar();
            dgvReparacionesConfig(reparaciones);
            if (idEquipo > 0) { AgregarNuevaOrden(); }
            CargarComboTecnicos();
        }


        //Cargar grilla de reparaciones
        private void dgvReparacionesConfig(List<clsReparacion> lista)
        {
            string busqueda;
            dgvReparaciones.Rows.Clear();
            lista = lista.OrderByDescending(x => x.FechaIngreso).ThenBy(x => x.Estado).ToList();
            foreach (clsReparacion reparacion in lista)
            {
                if (reparacion.Anulada) { continue; }
                string cliente = reparacion.Cliente.Apellido + " " + reparacion.Cliente.Nombre;
                string modeloEquipo = reparacion.Equipo.Modelo;
                string tecnico = reparacion.Tecnico.Apellido + " " + reparacion.Tecnico.Nombre;
                busqueda = (cliente + modeloEquipo + tecnico + reparacion.Estado + reparacion.FechaIngreso + reparacion.FechaEntrega + reparacion.CostoTotal).ToUpper();
                dgvReparaciones.Rows.Add(reparacion.Id, cliente, modeloEquipo, tecnico, reparacion.Estado, reparacion.FechaIngreso, reparacion.FechaEntrega, reparacion.CostoTotal, reparacion.IdTecnico, reparacion.IdEquipo, busqueda);
            }
        }
        //Cargar grilla de repuestos utilizados
        private void dgvRepuestosConfig(int reparacionSeleccionada)
        {
           dgvRepuestos.Rows.Clear();
            List<clsRepuestoUtilizado> lista = clsRepuestoUtilizado.BuscarTodos(reparacionSeleccionada);
            lista = lista.OrderByDescending(x => x.Cantidad).ThenByDescending(x => PrecioVenta).ToList();
                foreach (clsRepuestoUtilizado repuestoUtilizado in lista)
                {
                    dgvRepuestos.Rows.Add(repuestoUtilizado.Id, repuestoUtilizado.Codigo, repuestoUtilizado.Descripcion, repuestoUtilizado.PrecioCompra, repuestoUtilizado.PrecioVenta,repuestoUtilizado.Cantidad,repuestoUtilizado.IdReparacion);
                }
        }
        //Agregar nueva orden
        private void AgregarNuevaOrden()
        {
            //obtengo el id de la siguente orden para poder referenciar los repuestos
            this.idReparacionTemp=clsReparacion.ObtenerId();
            cboEstado.SelectedIndex = 0;
            lblCostoTotalRes.Text = string.Format("{0:C2}", 0);
            lblFechaIngresoRes.Text = DateTime.Today.ToShortDateString();
            dgvRepuestos.Rows.Clear();
            tbTecnico.Text = padre.UserLog.Apellido + " " + padre.UserLog.Nombre;
            clsEquipo equipoOrden = clsEquipo.Buscar(idEquipo);
            tbModeloEquipo.Text = equipoOrden.Modelo;
            tbCliente.Text = equipoOrden.Cliente.Apellido + " " + equipoOrden.Cliente.Nombre;
            spcMain.Panel2Collapsed = false;
            spcDatos.Panel2Collapsed = false;
            btnLimpiar.Show();
            spcDatos.Panel1Collapsed = true;
        }
        //Carga de ComboBox Tecnicos
        private void CargarComboTecnicos()
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




        //Botonera formulario reparacion ---------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnLimpiar.Visible) { RollBackRepuestos(); }//Si se estaba trabajando con una nueva orden y se cancelo, 
                                                            //hago rollback de los repuestos para mantener consistencia de stock.
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
                //si se esta actualizando registro, por lo tanto no esta disponible btnLimpiar
                if (btnLimpiar.Visible)
                {
                    clsReparacion reparacion = new clsReparacion(rtbAccesorios.Text, rtbDiagnostico.Text, double.Parse(nudCostoManoObra.Value.ToString()), idEquipo, padre.UserLog.Id, cboEstado.SelectedItem.ToString(), lblFechaIngresoRes.Text, lblFechaEntregaRes.Text);
                    msg = reparacion.Guardar();
                    if (msg.Equals(string.Empty))
                    {
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
                    clsReparacion reparacion = new clsReparacion(rtbAccesorios.Text, rtbDiagnostico.Text, Convert.ToDouble(nudCostoManoObra.Value), Convert.ToInt32(fila.Cells["IdEq"].Value), padre.UserLog.Id, cboEstado.SelectedItem.ToString(), lblFechaIngresoRes.Text, lblFechaEntregaRes.Text, this.idReparacionTemp);
                    msg = reparacion.Actualizar();
                    if (msg.Equals(string.Empty))
                    {
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
            tbCliente.Enabled = true;
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

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFechaEntregaRes.Text = (cboEstado.SelectedIndex == 2) ? DateTime.Today.ToShortDateString() : string.Empty;
        }
        //------------------------------------




        //Botonera grilla reparaciones --------
        private void CargarInfoFormulario(DataGridViewRow fila)
        {
            clsReparacion reparacion = clsReparacion.Buscar(int.Parse(fila.Cells["IdReparacion"].Value.ToString()));
            tbCliente.Text = reparacion.Cliente.Apellido+" "+reparacion.Cliente.Nombre;
            tbModeloEquipo.Text = reparacion.Equipo.Modelo;
            tbTecnico.Text = reparacion.Tecnico.Apellido +" "+reparacion.Tecnico.Nombre;
            rtbDiagnostico.Text = reparacion.Diagnostico;
            rtbAccesorios.Text = reparacion.Accesorios;
            cboEstado.SelectedItem = reparacion.Estado;
            nudCostoManoObra.Value = Convert.ToDecimal(reparacion.CostoManoObra);
            lblFechaIngresoRes.Text = reparacion.FechaIngreso;
            lblFechaEntregaRes.Text = reparacion.FechaEntrega;
            lblCostoTotalRes.Text = string.Format("{0:C2}",reparacion.CostoTotal);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            tbBuscar.Clear();
            rbFechaIngreso.Checked = true;
            cboTecnico.SelectedIndex = 0;
            cboBusquedaEstado.SelectedIndex = 0;
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpHasta.MaxDate;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvReparaciones.CurrentRow;
            if(fila != null && fila.Selected) {
                int idTecnicoFila = Convert.ToInt32(fila.Cells["IdTecnico"].Value);
                string msg = (idTecnicoFila == padre.UserLog.Id) ? string.Empty : "No puede editar una reparacion que no le pertenece.";
                if (msg.Equals(string.Empty)) { msg = (fila.Cells["Estado"].Value.ToString().Equals("ENTREGADO")) ? "No se puede editar una reparacion concluida." : string.Empty; }
                if (msg.Equals(string.Empty))
                {
                    //obtengo el id de la orden para referenciar los repuestos
                    this.idReparacionTemp = Convert.ToInt32(fila.Cells["IdReparacion"].Value);
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
                MessageBox.Show("Debe seleccionar una reparacion.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                tbCliente.Enabled = false;
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
            if (fila != null && fila.Selected)
            {
                int idTecnicoFila = Convert.ToInt32(fila.Cells["IdTecnico"].Value);
                string msg = (idTecnicoFila == padre.UserLog.Id) ? string.Empty : "No puede eliminar una reparacion que no le pertenece.";
                if (msg.Equals(string.Empty)) { msg = (fila.Cells["Estado"].Value.ToString().Equals("ENTREGADO")) ? "No se puede eliminar una reparacion concluida." : string.Empty; }
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
            else
                MessageBox.Show("Debe seleccionar una reparacion.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvReparacion_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvReparaciones.CurrentRow;
            if (fila != null && fila.Selected)
            {
                int reparacionSeleccionada = Convert.ToInt32(fila.Cells["IdReparacion"].Value);
                dgvRepuestosConfig(reparacionSeleccionada);
            }
            else
                dgvRepuestos.Rows.Clear();
        }

        private void RollBackRepuestos()
        {
            foreach (DataGridViewRow fila in dgvRepuestos.Rows)
            {
                clsRepuestoUtilizado.Eliminar(Convert.ToInt32(fila.Cells["Id"].Value));
            }
        }
        //------------------------------------





        //Botonera grilla repuestos ---------------------------------------------------------------------------------
        private void dgvRepuestos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularCostoTotal();
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            frmListaRepuestos hijo = new frmListaRepuestos(this, true);
            hijo.ShowDialog();
        }

        public void GuardarRepuesto(DataGridViewRow fila, int cantidad)
        {
            //guardo el repuesto
            clsRepuestoUtilizado repuesto = new clsRepuestoUtilizado(fila.Cells["Codigo"].Value.ToString(), fila.Cells["Descripcion"].Value.ToString(), Convert.ToDouble(fila.Cells["PrecioCompra"].Value), Convert.ToDouble(fila.Cells["PrecioVenta"].Value), cantidad, this.idReparacionTemp);
            string msg = repuesto.Guardar();       
            if (!msg.Equals(string.Empty)) { MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //actualizo lo la grilla
            dgvRepuestosConfig(this.idReparacionTemp);
        }

        private void btnQuitarRepuesto_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvRepuestos.CurrentRow;
            if (fila != null && fila.Selected)
            {
                if (MessageBox.Show("Esta seguro que desea quitar el repuesto?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int id = int.Parse(fila.Cells["Id"].Value.ToString());
                    clsRepuestoUtilizado repuesto = clsRepuestoUtilizado.Buscar(id);
                    string msg = clsRepuestoUtilizado.Eliminar(id);
                    if (!msg.Equals(string.Empty)) { MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    dgvRepuestosConfig(this.idReparacionTemp);
                    CalcularCostoTotal();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un repuesto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------------------------------------------------------------------------------




        //Filtrar grilla de reparaciones ----------------------------------------------------------------------------------------
        private void Filtrar()
        {
            if (reparaciones != null)
            {
                List<clsReparacion> filtrar = reparaciones;
                //filtro de tecnicos
                if (Convert.ToInt32(cboTecnico.SelectedValue) != 0) { filtrar = filtrar.FindAll(x => x.IdTecnico == Convert.ToInt32(cboTecnico.SelectedValue)); }
                //filtro de estados de reparacion
                if (!cboBusquedaEstado.SelectedItem.Equals("TODOS")) { filtrar = filtrar.FindAll(x => x.Estado.Equals(cboBusquedaEstado.SelectedItem)); }
                //filtro de fechas
                if (rbFechaEntrega.Checked) {
                    //Elimino aquellas entradas que no estan entregadas
                    filtrar = filtrar.FindAll(x => x.FechaEntrega != "");
                    filtrar = filtrar.FindAll(x => Convert.ToDateTime(x.FechaEntrega) >= dtpDesde.Value && Convert.ToDateTime(x.FechaEntrega) <= dtpHasta.Value);
                }
                else
                    filtrar = filtrar.FindAll(x => Convert.ToDateTime(x.FechaIngreso) >= dtpDesde.Value && Convert.ToDateTime(x.FechaIngreso) <= dtpHasta.Value); 
                //actualizo la grilla de reparaciones
                dgvReparacionesConfig(filtrar);
                tbBuscar.Clear();
            }            
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvReparaciones.Rows)
            {
                fila.Visible = (fila.Cells["Busqueda"].Value.ToString().Contains(tbBuscar.Text.ToUpper().Trim()));
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
            if (dtpDesde.Value > dtpHasta.Value) { MessageBox.Show("La fecha de inicio no puede ser superior que la fecha de fin", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
                Filtrar();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.Value > dtpHasta.Value) { MessageBox.Show("La fecha de fin no puede ser inferior que la fecha de inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
                Filtrar();
        }

        private void rbFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        //--------------------------------------------------------------------------------------------------------------------



        //Calculo de costo total
        private double CalcularCostoTotal()
        {
            double costo = Convert.ToDouble(nudCostoManoObra.Value);
            foreach (DataGridViewRow fila in dgvRepuestos.Rows)
            {
                costo += (Convert.ToDouble(fila.Cells["PrecioVenta"].Value) * Convert.ToInt32(fila.Cells["Cantidad"].Value));
            }
            lblCostoTotalRes.Text = string.Format("{0:C2}", costo);
            return costo;
        }

        //Validacion campos form reparacion
        private string Validar()
        {
            if (rtbDiagnostico.Text.Equals(string.Empty)) { return "Debe incluir un diagnostico de la reparación."; }
            return string.Empty;
        }
    }
}
