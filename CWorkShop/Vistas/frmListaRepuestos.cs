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
    public partial class frmListaRepuestos : Form
    {
        Form padre;

        public frmListaRepuestos(Form padre, bool fullView=false)
        {
            InitializeComponent();
            this.padre = padre;
            if (fullView)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            }
            pnlBotonera.Visible = fullView;
            pnlTitulo.Visible = fullView;
            dgvRepuestos.MultiSelect = fullView;
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
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection seleccionadas = dgvRepuestos.SelectedRows;
            if (seleccionadas != null)
            {
                ((frmOrdenes)padre).CargarRepuestos(seleccionadas);
                this.Dispose();
            }
            else
                MessageBox.Show("Debe seleccionar algun repuesto del inventario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
