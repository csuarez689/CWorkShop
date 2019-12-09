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
    public partial class frmRepuestos : Form
    {
        frmListaRepuestos hijo;
        public frmRepuestos()
        {
            InitializeComponent();
            spcCont.Panel2Collapsed = true;
            CargaFrmListaRepuestos();
        }

        //Botonera grilla repuestos ---------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnLimpiar.Show();
            spcCont.Panel2Collapsed = false;
            spcCont.Panel1.Enabled = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow fila = ((DataGridView)hijo.Controls["dgvRepuestos"]).CurrentRow;
            if (fila != null)
            {
                bool sel = fila.Selected;
                string msg = (sel) ? string.Empty : "Debe seleccionar un repuesto.";
                if (msg.Equals(string.Empty))
                {
                    tbCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                    tbDescipcion.Text = fila.Cells["Descripcion"].Value.ToString();
                    nudPrecioCompra.Value = decimal.Parse(fila.Cells["PrecioCompra"].Value.ToString());
                    nudPrecioVenta.Value = decimal.Parse(fila.Cells["PrecioVenta"].Value.ToString());
                    nudStock.Value = int.Parse(fila.Cells["Stock"].Value.ToString());
                    btnLimpiar.Hide();
                    spcCont.Panel2Collapsed = false;
                    spcCont.Panel1.Enabled = false;
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No existe registros para editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = ((DataGridView)hijo.Controls["dgvRepuestos"]).CurrentRow;
            if (fila.Selected)
            {
                if (MessageBox.Show("¿Esta seguro que desea borrar el repuesto?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string msg = clsRepuesto.Eliminar(int.Parse(fila.Cells["Id"].Value.ToString()));
                    if (msg.Equals(string.Empty))
                        hijo.dgvRepuestoConfig();
                    else
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("Debe seleccionar un cliente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------

        //Botonera formulario repuestos ---------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcCont.Panel2);
            spcCont.Panel2Collapsed = true;
            spcCont.Panel1.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            frmMain.Limpiar(spcCont.Panel2);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msg = this.Validar();
            if (msg.Equals(string.Empty))
            {
                clsRepuesto repuesto = new clsRepuesto(tbCodigo.Text, tbDescipcion.Text, double.Parse(nudPrecioCompra.Value.ToString()), double.Parse(nudPrecioVenta.Value.ToString()), int.Parse(nudStock.Value.ToString()));
                //Se esta guardando registro nuevo
                //se esta actualizando registro, por lo tanto no esta disponible btnLimpiar
                if (btnLimpiar.Visible)
                    msg = repuesto.Guardar();
                else
                {
                    repuesto.Id = int.Parse(((DataGridView)hijo.Controls["dgvRepuestos"]).CurrentRow.Cells["Id"].Value.ToString());
                    repuesto.Actualizar();
                    btnCancelar.PerformClick();
                }
                if (msg.Equals(string.Empty))
                {
                    hijo.dgvRepuestoConfig();
                    btnCancelar.PerformClick();
                }
                else
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------


        //Carga de grilla de repuestos
        private void CargaFrmListaRepuestos()
        {
            hijo= new frmListaRepuestos(false);
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.spcCont.Panel1.Controls.Add(hijo);
            this.spcCont.Panel1.Tag = hijo;
            hijo.Show();
        }

        private string Validar()
        {
            Regex codigo = new Regex(@"^[A-Z0-9]([A-Z0-9]){4,20}$");
            if (!codigo.IsMatch(tbCodigo.Text)) { return "Campo codigo de producto incorrecto. (Min 4, Max 20)."; }
            if (tbDescipcion.Text.Equals(string.Empty)) { return "La descripcion no puede estar vacia."; }
            return string.Empty;
        }
    }
}
