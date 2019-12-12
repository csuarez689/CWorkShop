using CWorkShop.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CWorkShop.Vistas
{
    public partial class frmListaRepuestos : Form
    {
        Form padre;

        public frmListaRepuestos(Form padre, bool fullView=false)
        {
            InitializeComponent();
            this.padre = padre;
            if (fullView)
            {
                this.Padding = new Padding(10);
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            pnlBotonera.Visible = fullView;
            pnlTitulo.Visible = fullView;
            pnlCantidad.Visible = fullView;
            dgvRepuestos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRepuestoConfig();
        }

        public void dgvRepuestoConfig()
        {
            List<clsRepuesto> lista = clsRepuesto.Listar();
            dgvRepuestos.Rows.Clear();
            string busqueda;
            foreach (clsRepuesto repuesto in lista)
            {
                busqueda = (repuesto.Codigo + repuesto.Descripcion + repuesto.PrecioCompra.ToString() + repuesto.PrecioVenta.ToString() + repuesto.Stock.ToString()).ToUpper().Trim();
                dgvRepuestos.Rows.Add(repuesto.Id, repuesto.Codigo, repuesto.Descripcion, repuesto.PrecioCompra, repuesto.PrecioVenta, repuesto.Stock, busqueda);
            }
            tbBuscar.Clear();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = tbBuscar.Text.ToUpper().Trim();
            foreach (DataGridViewRow fila in dgvRepuestos.Rows)
            {
                fila.Visible = (fila.Cells["Busqueda"].Value.ToString().ToUpper().Trim().Contains(texto));
            }

            dgvRepuestos.ClearSelection();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvRepuestos.CurrentRow;
            if (fila!=null)
            {
                ((frmOrdenes)padre).GuardarRepuesto(fila, Convert.ToInt32(nudCantidad.Value));
                this.Close();
            }
            else
                MessageBox.Show("Debe seleccionar algun repuesto del inventario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvRepuestos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvRepuestos.CurrentRow;
            if(fila!=null && fila.Selected)
            {
                if (int.Parse(fila.Cells["Stock"].Value.ToString()) == 0)
                {
                    btnAceptar.Enabled = false;
                    nudCantidad.Enabled = false;
                    lblSinStock.Show();
                }
                else
                {
                    btnAceptar.Enabled = true;
                    nudCantidad.Enabled = true;
                    nudCantidad.Maximum = int.Parse(fila.Cells["Stock"].Value.ToString());
                    lblSinStock.Hide();
                }
            }
        }
    }
}
