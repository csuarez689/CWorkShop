namespace CWorkShop.Vistas
{
    partial class frmOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcDatos = new System.Windows.Forms.SplitContainer();
            this.dgvReparaciones = new System.Windows.Forms.DataGridView();
            this.IdReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Busqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltroFecha = new System.Windows.Forms.Panel();
            this.rbFechaEntrega = new System.Windows.Forms.RadioButton();
            this.rbFechaIngreso = new System.Windows.Forms.RadioButton();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTecnico = new System.Windows.Forms.Panel();
            this.cboTecnico = new System.Windows.Forms.ComboBox();
            this.lblTenico = new System.Windows.Forms.Label();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.cboBusquedaEstado = new System.Windows.Forms.ComboBox();
            this.lblBusquedaEstado = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotoneraRepuestos = new System.Windows.Forms.Panel();
            this.btnQuitarRepuesto = new System.Windows.Forms.Button();
            this.btnAgregarRepuesto = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblCostoTotalRes = new System.Windows.Forms.Label();
            this.lblFechaEntregaRes = new System.Windows.Forms.Label();
            this.lblFechaIngresoRes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.nudCostoManoObra = new System.Windows.Forms.NumericUpDown();
            this.lblManoObra = new System.Windows.Forms.Label();
            this.rtbAccesorios = new System.Windows.Forms.RichTextBox();
            this.rtbDiagnostico = new System.Windows.Forms.RichTextBox();
            this.lblAccesorios = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbModeloEquipo = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.tbTecnico = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcDatos)).BeginInit();
            this.spcDatos.Panel1.SuspendLayout();
            this.spcDatos.Panel2.SuspendLayout();
            this.spcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
            this.pnlFiltroFecha.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTecnico.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.pnlBotoneraRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoManoObra)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(10, 10);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcDatos);
            this.spcMain.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spcMain.Panel2.Controls.Add(this.cboEstado);
            this.spcMain.Panel2.Controls.Add(this.lblCostoTotalRes);
            this.spcMain.Panel2.Controls.Add(this.lblFechaEntregaRes);
            this.spcMain.Panel2.Controls.Add(this.lblFechaIngresoRes);
            this.spcMain.Panel2.Controls.Add(this.btnVolver);
            this.spcMain.Panel2.Controls.Add(this.lblCostoTotal);
            this.spcMain.Panel2.Controls.Add(this.lblFechaEntrega);
            this.spcMain.Panel2.Controls.Add(this.nudCostoManoObra);
            this.spcMain.Panel2.Controls.Add(this.lblManoObra);
            this.spcMain.Panel2.Controls.Add(this.rtbAccesorios);
            this.spcMain.Panel2.Controls.Add(this.rtbDiagnostico);
            this.spcMain.Panel2.Controls.Add(this.lblAccesorios);
            this.spcMain.Panel2.Controls.Add(this.lblOrden);
            this.spcMain.Panel2.Controls.Add(this.lbCliente);
            this.spcMain.Panel2.Controls.Add(this.btnLimpiar);
            this.spcMain.Panel2.Controls.Add(this.tbCliente);
            this.spcMain.Panel2.Controls.Add(this.btnCancelar);
            this.spcMain.Panel2.Controls.Add(this.lblModelo);
            this.spcMain.Panel2.Controls.Add(this.btnGuardar);
            this.spcMain.Panel2.Controls.Add(this.tbModeloEquipo);
            this.spcMain.Panel2.Controls.Add(this.lblFechaIngreso);
            this.spcMain.Panel2.Controls.Add(this.lblTecnico);
            this.spcMain.Panel2.Controls.Add(this.tbTecnico);
            this.spcMain.Panel2.Controls.Add(this.lblEstado);
            this.spcMain.Panel2.Controls.Add(this.lblDiagnostico);
            this.spcMain.Size = new System.Drawing.Size(1186, 611);
            this.spcMain.SplitterDistance = 793;
            this.spcMain.TabIndex = 0;
            this.spcMain.TabStop = false;
            // 
            // spcDatos
            // 
            this.spcDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcDatos.Location = new System.Drawing.Point(10, 0);
            this.spcDatos.Name = "spcDatos";
            this.spcDatos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcDatos.Panel1
            // 
            this.spcDatos.Panel1.Controls.Add(this.dgvReparaciones);
            this.spcDatos.Panel1.Controls.Add(this.pnlFiltroFecha);
            this.spcDatos.Panel1.Controls.Add(this.pnlTop);
            this.spcDatos.Panel1.Controls.Add(this.pnlBotonera);
            // 
            // spcDatos.Panel2
            // 
            this.spcDatos.Panel2.Controls.Add(this.dgvRepuestos);
            this.spcDatos.Panel2.Controls.Add(this.pnlBotoneraRepuestos);
            this.spcDatos.Size = new System.Drawing.Size(773, 611);
            this.spcDatos.SplitterDistance = 369;
            this.spcDatos.TabIndex = 2;
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.AllowUserToAddRows = false;
            this.dgvReparaciones.AllowUserToDeleteRows = false;
            this.dgvReparaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReparaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReparaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvReparaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReparaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvReparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReparaciones.ColumnHeadersHeight = 30;
            this.dgvReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReparacion,
            this.Cliente,
            this.ModeloEquipo,
            this.Tecnico,
            this.Estado,
            this.FechaIngreso,
            this.FechaEntrega,
            this.CostoTotal,
            this.IdTecnico,
            this.IdEq,
            this.Busqueda});
            this.dgvReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReparaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReparaciones.EnableHeadersVisualStyles = false;
            this.dgvReparaciones.Location = new System.Drawing.Point(0, 130);
            this.dgvReparaciones.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dgvReparaciones.MultiSelect = false;
            this.dgvReparaciones.Name = "dgvReparaciones";
            this.dgvReparaciones.ReadOnly = true;
            this.dgvReparaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReparaciones.RowHeadersVisible = false;
            this.dgvReparaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvReparaciones.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReparaciones.RowTemplate.Height = 24;
            this.dgvReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparaciones.Size = new System.Drawing.Size(771, 198);
            this.dgvReparaciones.TabIndex = 1;
            this.dgvReparaciones.TabStop = false;
            this.dgvReparaciones.SelectionChanged += new System.EventHandler(this.dgvReparacion_SelectionChanged);
            // 
            // IdReparacion
            // 
            this.IdReparacion.HeaderText = "IdReparacion";
            this.IdReparacion.Name = "IdReparacion";
            this.IdReparacion.ReadOnly = true;
            this.IdReparacion.Visible = false;
            this.IdReparacion.Width = 120;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 77;
            // 
            // ModeloEquipo
            // 
            this.ModeloEquipo.HeaderText = "Modelo Equipo";
            this.ModeloEquipo.Name = "ModeloEquipo";
            this.ModeloEquipo.ReadOnly = true;
            this.ModeloEquipo.Width = 129;
            // 
            // Tecnico
            // 
            this.Tecnico.HeaderText = "Tecnico";
            this.Tecnico.Name = "Tecnico";
            this.Tecnico.ReadOnly = true;
            this.Tecnico.Width = 80;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 75;
            // 
            // FechaIngreso
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaIngreso.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 120;
            // 
            // FechaEntrega
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaEntrega.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 124;
            // 
            // CostoTotal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            this.CostoTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            this.CostoTotal.Width = 105;
            // 
            // IdTecnico
            // 
            this.IdTecnico.HeaderText = "IdTecnico";
            this.IdTecnico.Name = "IdTecnico";
            this.IdTecnico.ReadOnly = true;
            this.IdTecnico.Visible = false;
            this.IdTecnico.Width = 94;
            // 
            // IdEq
            // 
            this.IdEq.HeaderText = "IdEq";
            this.IdEq.Name = "IdEq";
            this.IdEq.ReadOnly = true;
            this.IdEq.Visible = false;
            this.IdEq.Width = 61;
            // 
            // Busqueda
            // 
            this.Busqueda.HeaderText = "Busqueda";
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.ReadOnly = true;
            this.Busqueda.Visible = false;
            this.Busqueda.Width = 96;
            // 
            // pnlFiltroFecha
            // 
            this.pnlFiltroFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltroFecha.Controls.Add(this.rbFechaEntrega);
            this.pnlFiltroFecha.Controls.Add(this.rbFechaIngreso);
            this.pnlFiltroFecha.Controls.Add(this.btnLimpiarFiltros);
            this.pnlFiltroFecha.Controls.Add(this.dtpHasta);
            this.pnlFiltroFecha.Controls.Add(this.lblHasta);
            this.pnlFiltroFecha.Controls.Add(this.dtpDesde);
            this.pnlFiltroFecha.Controls.Add(this.lblDesde);
            this.pnlFiltroFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroFecha.Location = new System.Drawing.Point(0, 65);
            this.pnlFiltroFecha.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFiltroFecha.Name = "pnlFiltroFecha";
            this.pnlFiltroFecha.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFiltroFecha.Size = new System.Drawing.Size(771, 65);
            this.pnlFiltroFecha.TabIndex = 0;
            // 
            // rbFechaEntrega
            // 
            this.rbFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFechaEntrega.AutoSize = true;
            this.rbFechaEntrega.ForeColor = System.Drawing.Color.White;
            this.rbFechaEntrega.Location = new System.Drawing.Point(51, 33);
            this.rbFechaEntrega.Name = "rbFechaEntrega";
            this.rbFechaEntrega.Size = new System.Drawing.Size(119, 21);
            this.rbFechaEntrega.TabIndex = 1;
            this.rbFechaEntrega.Text = "Fecha Entrega";
            this.rbFechaEntrega.UseVisualStyleBackColor = true;
            // 
            // rbFechaIngreso
            // 
            this.rbFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFechaIngreso.AutoSize = true;
            this.rbFechaIngreso.Checked = true;
            this.rbFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.rbFechaIngreso.Location = new System.Drawing.Point(51, 8);
            this.rbFechaIngreso.Name = "rbFechaIngreso";
            this.rbFechaIngreso.Size = new System.Drawing.Size(115, 21);
            this.rbFechaIngreso.TabIndex = 0;
            this.rbFechaIngreso.TabStop = true;
            this.rbFechaIngreso.Text = "Fecha Ingreso";
            this.rbFechaIngreso.UseVisualStyleBackColor = true;
            this.rbFechaIngreso.CheckedChanged += new System.EventHandler(this.rbFechaIngreso_CheckedChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(653, 21);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(113, 26);
            this.btnLimpiarFiltros.TabIndex = 6;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(531, 21);
            this.dtpHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(116, 23);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(475, 23);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(50, 20);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(334, 21);
            this.dtpDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(116, 23);
            this.dtpDesde.TabIndex = 3;
            this.dtpDesde.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(272, 23);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlTecnico);
            this.pnlTop.Controls.Add(this.pnlOrden);
            this.pnlTop.Controls.Add(this.pnlBuscar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTop.Size = new System.Drawing.Size(771, 65);
            this.pnlTop.TabIndex = 6;
            // 
            // pnlTecnico
            // 
            this.pnlTecnico.Controls.Add(this.cboTecnico);
            this.pnlTecnico.Controls.Add(this.lblTenico);
            this.pnlTecnico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTecnico.Location = new System.Drawing.Point(319, 5);
            this.pnlTecnico.Name = "pnlTecnico";
            this.pnlTecnico.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTecnico.Size = new System.Drawing.Size(163, 53);
            this.pnlTecnico.TabIndex = 1;
            // 
            // cboTecnico
            // 
            this.cboTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnico.FormattingEnabled = true;
            this.cboTecnico.Items.AddRange(new object[] {
            "TODOS"});
            this.cboTecnico.Location = new System.Drawing.Point(103, 14);
            this.cboTecnico.Name = "cboTecnico";
            this.cboTecnico.Size = new System.Drawing.Size(36, 25);
            this.cboTecnico.TabIndex = 1;
            this.cboTecnico.SelectedIndexChanged += new System.EventHandler(this.cboTecnico_SelectedIndexChanged);
            // 
            // lblTenico
            // 
            this.lblTenico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenico.AutoSize = true;
            this.lblTenico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenico.ForeColor = System.Drawing.Color.White;
            this.lblTenico.Location = new System.Drawing.Point(31, 14);
            this.lblTenico.Name = "lblTenico";
            this.lblTenico.Size = new System.Drawing.Size(66, 20);
            this.lblTenico.TabIndex = 0;
            this.lblTenico.Text = "Técnico";
            // 
            // pnlOrden
            // 
            this.pnlOrden.Controls.Add(this.cboBusquedaEstado);
            this.pnlOrden.Controls.Add(this.lblBusquedaEstado);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrden.Location = new System.Drawing.Point(482, 5);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOrden.Size = new System.Drawing.Size(282, 53);
            this.pnlOrden.TabIndex = 0;
            // 
            // cboBusquedaEstado
            // 
            this.cboBusquedaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusquedaEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaEstado.FormattingEnabled = true;
            this.cboBusquedaEstado.Items.AddRange(new object[] {
            "TODOS",
            "EN TALLER",
            "TERMINADO",
            "ENTREGADO"});
            this.cboBusquedaEstado.Location = new System.Drawing.Point(91, 14);
            this.cboBusquedaEstado.Name = "cboBusquedaEstado";
            this.cboBusquedaEstado.Size = new System.Drawing.Size(168, 25);
            this.cboBusquedaEstado.TabIndex = 1;
            this.cboBusquedaEstado.SelectedIndexChanged += new System.EventHandler(this.cboBusquedaEstado_SelectedIndexChanged);
            // 
            // lblBusquedaEstado
            // 
            this.lblBusquedaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusquedaEstado.AutoSize = true;
            this.lblBusquedaEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaEstado.ForeColor = System.Drawing.Color.White;
            this.lblBusquedaEstado.Location = new System.Drawing.Point(27, 14);
            this.lblBusquedaEstado.Name = "lblBusquedaEstado";
            this.lblBusquedaEstado.Size = new System.Drawing.Size(58, 20);
            this.lblBusquedaEstado.TabIndex = 0;
            this.lblBusquedaEstado.Text = "Estado";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.label1);
            this.pnlBuscar.Controls.Add(this.tbBuscar);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBuscar.Location = new System.Drawing.Point(5, 5);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBuscar.Size = new System.Drawing.Size(314, 53);
            this.pnlBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscar.Location = new System.Drawing.Point(85, 14);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(211, 23);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnHistorico);
            this.pnlBotonera.Controls.Add(this.btnDetalle);
            this.pnlBotonera.Controls.Add(this.btnEliminar);
            this.pnlBotonera.Controls.Add(this.btnEditar);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 328);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(771, 39);
            this.pnlBotonera.TabIndex = 2;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(479, 6);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(138, 26);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Historico Equipo";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(381, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(92, 26);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(283, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 26);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(185, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 26);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.AllowUserToDeleteRows = false;
            this.dgvRepuestos.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvRepuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvRepuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRepuestos.ColumnHeadersHeight = 30;
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Descripcion,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.IdRep});
            this.dgvRepuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRepuestos.EnableHeadersVisualStyles = false;
            this.dgvRepuestos.Location = new System.Drawing.Point(0, 0);
            this.dgvRepuestos.MultiSelect = false;
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.ReadOnly = true;
            this.dgvRepuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRepuestos.RowHeadersVisible = false;
            this.dgvRepuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvRepuestos.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRepuestos.RowTemplate.Height = 24;
            this.dgvRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepuestos.Size = new System.Drawing.Size(771, 197);
            this.dgvRepuestos.TabIndex = 0;
            this.dgvRepuestos.TabStop = false;
            this.dgvRepuestos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRepuestos_RowsAdded);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 45;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 81;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 106;
            // 
            // PrecioCompra
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "0";
            this.PrecioCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 130;
            // 
            // PrecioVenta
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = "0";
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle11;
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 114;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "0 u.";
            dataGridViewCellStyle12.NullValue = "0";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 94;
            // 
            // IdRep
            // 
            this.IdRep.HeaderText = "IdRep";
            this.IdRep.Name = "IdRep";
            this.IdRep.ReadOnly = true;
            this.IdRep.Visible = false;
            this.IdRep.Width = 70;
            // 
            // pnlBotoneraRepuestos
            // 
            this.pnlBotoneraRepuestos.Controls.Add(this.btnQuitarRepuesto);
            this.pnlBotoneraRepuestos.Controls.Add(this.btnAgregarRepuesto);
            this.pnlBotoneraRepuestos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoneraRepuestos.Location = new System.Drawing.Point(0, 197);
            this.pnlBotoneraRepuestos.Name = "pnlBotoneraRepuestos";
            this.pnlBotoneraRepuestos.Size = new System.Drawing.Size(771, 39);
            this.pnlBotoneraRepuestos.TabIndex = 1;
            // 
            // btnQuitarRepuesto
            // 
            this.btnQuitarRepuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarRepuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnQuitarRepuesto.FlatAppearance.BorderSize = 0;
            this.btnQuitarRepuesto.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitarRepuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitarRepuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitarRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRepuesto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarRepuesto.Location = new System.Drawing.Point(416, 8);
            this.btnQuitarRepuesto.Name = "btnQuitarRepuesto";
            this.btnQuitarRepuesto.Size = new System.Drawing.Size(146, 26);
            this.btnQuitarRepuesto.TabIndex = 1;
            this.btnQuitarRepuesto.Text = "Quitar Repuesto";
            this.btnQuitarRepuesto.UseVisualStyleBackColor = false;
            this.btnQuitarRepuesto.Click += new System.EventHandler(this.btnQuitarRepuesto_Click);
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarRepuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarRepuesto.FlatAppearance.BorderSize = 0;
            this.btnAgregarRepuesto.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRepuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRepuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRepuesto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(219, 8);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(147, 26);
            this.btnAgregarRepuesto.TabIndex = 0;
            this.btnAgregarRepuesto.Text = "Agregar Repuesto";
            this.btnAgregarRepuesto.UseVisualStyleBackColor = false;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "EN TALLER",
            "TERMINADO",
            "ENTREGADO"});
            this.cboEstado.Location = new System.Drawing.Point(129, 393);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(231, 25);
            this.cboEstado.TabIndex = 33;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // lblCostoTotalRes
            // 
            this.lblCostoTotalRes.AutoSize = true;
            this.lblCostoTotalRes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCostoTotalRes.Location = new System.Drawing.Point(131, 513);
            this.lblCostoTotalRes.Name = "lblCostoTotalRes";
            this.lblCostoTotalRes.Size = new System.Drawing.Size(0, 17);
            this.lblCostoTotalRes.TabIndex = 32;
            // 
            // lblFechaEntregaRes
            // 
            this.lblFechaEntregaRes.AutoSize = true;
            this.lblFechaEntregaRes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaEntregaRes.Location = new System.Drawing.Point(131, 475);
            this.lblFechaEntregaRes.Name = "lblFechaEntregaRes";
            this.lblFechaEntregaRes.Size = new System.Drawing.Size(0, 17);
            this.lblFechaEntregaRes.TabIndex = 31;
            // 
            // lblFechaIngresoRes
            // 
            this.lblFechaIngresoRes.AutoSize = true;
            this.lblFechaIngresoRes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaIngresoRes.Location = new System.Drawing.Point(131, 436);
            this.lblFechaIngresoRes.Name = "lblFechaIngresoRes";
            this.lblFechaIngresoRes.Size = new System.Drawing.Size(0, 17);
            this.lblFechaIngresoRes.TabIndex = 30;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(25, 548);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 26);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCostoTotal.Location = new System.Drawing.Point(31, 513);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(86, 17);
            this.lblCostoTotal.TabIndex = 19;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaEntrega.Location = new System.Drawing.Point(14, 475);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(109, 17);
            this.lblFechaEntrega.TabIndex = 17;
            this.lblFechaEntrega.Text = "Fecha Entrega: ";
            // 
            // nudCostoManoObra
            // 
            this.nudCostoManoObra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCostoManoObra.DecimalPlaces = 2;
            this.nudCostoManoObra.Location = new System.Drawing.Point(128, 354);
            this.nudCostoManoObra.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudCostoManoObra.Name = "nudCostoManoObra";
            this.nudCostoManoObra.Size = new System.Drawing.Size(232, 23);
            this.nudCostoManoObra.TabIndex = 14;
            this.nudCostoManoObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCostoManoObra.ValueChanged += new System.EventHandler(this.nudCostoManoObra_ValueChanged);
            // 
            // lblManoObra
            // 
            this.lblManoObra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManoObra.AutoSize = true;
            this.lblManoObra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblManoObra.Location = new System.Drawing.Point(10, 356);
            this.lblManoObra.Name = "lblManoObra";
            this.lblManoObra.Size = new System.Drawing.Size(103, 17);
            this.lblManoObra.TabIndex = 13;
            this.lblManoObra.Text = "Mano de Obra";
            // 
            // rtbAccesorios
            // 
            this.rtbAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAccesorios.Location = new System.Drawing.Point(128, 284);
            this.rtbAccesorios.Name = "rtbAccesorios";
            this.rtbAccesorios.Size = new System.Drawing.Size(232, 52);
            this.rtbAccesorios.TabIndex = 10;
            this.rtbAccesorios.Text = "";
            // 
            // rtbDiagnostico
            // 
            this.rtbDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDiagnostico.Location = new System.Drawing.Point(128, 213);
            this.rtbDiagnostico.Name = "rtbDiagnostico";
            this.rtbDiagnostico.Size = new System.Drawing.Size(232, 52);
            this.rtbDiagnostico.TabIndex = 8;
            this.rtbDiagnostico.Text = "";
            // 
            // lblAccesorios
            // 
            this.lblAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccesorios.AutoSize = true;
            this.lblAccesorios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAccesorios.Location = new System.Drawing.Point(37, 287);
            this.lblAccesorios.Name = "lblAccesorios";
            this.lblAccesorios.Size = new System.Drawing.Size(76, 17);
            this.lblAccesorios.TabIndex = 9;
            this.lblAccesorios.Text = "Accesorios";
            // 
            // lblOrden
            // 
            this.lblOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.ForeColor = System.Drawing.Color.White;
            this.lblOrden.Location = new System.Drawing.Point(125, 27);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(153, 18);
            this.lblOrden.TabIndex = 0;
            this.lblOrden.Text = "ORDEN DE TRABAJO";
            // 
            // lbCliente
            // 
            this.lbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCliente.AutoSize = true;
            this.lbCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCliente.Location = new System.Drawing.Point(61, 99);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(54, 17);
            this.lbCliente.TabIndex = 1;
            this.lbCliente.Text = "Cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(129, 580);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 26);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliente.Enabled = false;
            this.tbCliente.Location = new System.Drawing.Point(128, 96);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(232, 23);
            this.tbCliente.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(31, 580);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 26);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModelo.Location = new System.Drawing.Point(56, 138);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(57, 17);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(227, 580);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 26);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbModeloEquipo
            // 
            this.tbModeloEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModeloEquipo.Enabled = false;
            this.tbModeloEquipo.Location = new System.Drawing.Point(128, 135);
            this.tbModeloEquipo.Name = "tbModeloEquipo";
            this.tbModeloEquipo.Size = new System.Drawing.Size(232, 23);
            this.tbModeloEquipo.TabIndex = 4;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaIngreso.Location = new System.Drawing.Point(16, 436);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(101, 17);
            this.lblFechaIngreso.TabIndex = 15;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblTecnico
            // 
            this.lblTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTecnico.Location = new System.Drawing.Point(56, 177);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(57, 17);
            this.lblTecnico.TabIndex = 5;
            this.lblTecnico.Text = "Tecnico";
            // 
            // tbTecnico
            // 
            this.tbTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTecnico.Enabled = false;
            this.tbTecnico.Location = new System.Drawing.Point(128, 174);
            this.tbTecnico.Name = "tbTecnico";
            this.tbTecnico.Size = new System.Drawing.Size(232, 23);
            this.tbTecnico.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstado.Location = new System.Drawing.Point(61, 396);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDiagnostico.Location = new System.Drawing.Point(27, 216);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(86, 17);
            this.lblDiagnostico.TabIndex = 7;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1206, 631);
            this.Controls.Add(this.spcMain);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOrdenes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "frmMain2";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcDatos.Panel1.ResumeLayout(false);
            this.spcDatos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcDatos)).EndInit();
            this.spcDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            this.pnlFiltroFecha.ResumeLayout(false);
            this.pnlFiltroFecha.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTecnico.ResumeLayout(false);
            this.pnlTecnico.PerformLayout();
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.pnlBotoneraRepuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoManoObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcDatos;
        private System.Windows.Forms.Panel pnlBotoneraRepuestos;
        private System.Windows.Forms.Button btnQuitarRepuesto;
        private System.Windows.Forms.Button btnAgregarRepuesto;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbModeloEquipo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.TextBox tbTecnico;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.DataGridView dgvReparaciones;
        private System.Windows.Forms.Panel pnlFiltroFecha;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTecnico;
        private System.Windows.Forms.ComboBox cboTecnico;
        private System.Windows.Forms.Label lblTenico;
        private System.Windows.Forms.Panel pnlOrden;
        private System.Windows.Forms.ComboBox cboBusquedaEstado;
        private System.Windows.Forms.Label lblBusquedaEstado;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label lblAccesorios;
        private System.Windows.Forms.RichTextBox rtbAccesorios;
        private System.Windows.Forms.RichTextBox rtbDiagnostico;
        private System.Windows.Forms.NumericUpDown nudCostoManoObra;
        private System.Windows.Forms.Label lblManoObra;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Busqueda;
        private System.Windows.Forms.RadioButton rbFechaEntrega;
        private System.Windows.Forms.RadioButton rbFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRep;
        private System.Windows.Forms.Label lblCostoTotalRes;
        private System.Windows.Forms.Label lblFechaEntregaRes;
        private System.Windows.Forms.Label lblFechaIngresoRes;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}