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
        List<int> idSeleccionados;

        public List<int> IdSeleccionados
        {
            get
            {
                return idSeleccionados;
            }
        }

        public frmListaRepuestos(bool fullView=false)
        {
            InitializeComponent();
            this.idSeleccionados = new List<int>();
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
                dgvRepuestos.Rows.Add(repuesto.Id, repuesto.Codigo, repuesto.Descripcion, repuesto.PrecioCompra, repuesto.PrecioVenta, repuesto.Stock,busqueda);
            }
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

        private List<int> btnAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection seleccionadas = dgvRepuestos.SelectedRows;
            if (seleccionadas != null)
            {
                foreach (DataGridViewRow fila in seleccionadas)
                {
                    idSeleccionados.Add(int.Parse(fila.Cells["Id"].Value.ToString()));
                }
            }
            else
                MessageBox.Show("Debe seleccionar algun repuesto del inventario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return idSeleccionados;
        }
    }
}
