﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWorkShop.Clases;

namespace CWorkShop.Vistas
{
    public partial class frmMain : Form
    {
        frmLogin login;
        clsUsuario userLog;
        public int xClick = 0, yClick = 0;
        public frmMain(frmLogin login, string dniUsuario)
        {
            InitializeComponent();
            pMarcador.Hide();
            this.login = login;
            userLog = clsUsuario.Buscar(dniUsuario);
            btnDatos.Text = userLog.Nombre + " " + userLog.Apellido;
            btnClientes.Image = Properties.Resources.cliente32x32_blue;
            btnOrdenes.Image = Properties.Resources.ordenes32x32;
            btnEstadisticas.Image = Properties.Resources.estadisticas32x32;
            
            if (userLog == null)
            {
                MessageBox.Show("Ha ocurrido un error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK) { 
            this.Close();
            login.Show();
            }
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pMarcador.Height = btnClientes.Height;
            pMarcador.Top = btnClientes.Top;
            pMarcador.Show();
            openForm(new frmCliente());
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            pMarcador.Height = btnOrdenes.Height;
            pMarcador.Top = btnOrdenes.Top;
            pMarcador.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            pMarcador.Height = btnEstadisticas.Height;
            pMarcador.Top = btnEstadisticas.Top;
            pMarcador.Show();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            pMarcador.Hide();
            frmMisDatos misDatos = new frmMisDatos(this,userLog);
            openForm(misDatos);
        }

        internal void openForm(object frm)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                ((Form)this.pnlContenedor.Controls[0]).Dispose();
                //this.pnlContenedor.Controls.RemoveAt(0);
            Form opcion = frm as Form;
            opcion.TopLevel = false;
            opcion.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(opcion);
            this.pnlContenedor.Tag = opcion;
            opcion.Show();
        }

        //Limpiar controles
        public static void Limpiar(Control ctrl)
        {
            foreach(var x in ctrl.Controls)
            {
                if (x is TextBox)
                    ((TextBox)x).Clear();
                else if (x is ComboBox)
                    ((ComboBox)x).SelectedIndex = -1;
            }
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        //Actualizar datos button
        public void ActualizarBtnDatos(clsUsuario userLog)
        {
            this.userLog = userLog;
            btnDatos.Text = userLog.Nombre + " " + userLog.Apellido;
        }   
    }
}
