namespace CWorkShop.Vistas
{
    partial class frmRepuestos
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
            this.spcCont = new System.Windows.Forms.SplitContainer();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbDescipcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spcCont)).BeginInit();
            this.spcCont.Panel1.SuspendLayout();
            this.spcCont.Panel2.SuspendLayout();
            this.spcCont.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // spcCont
            // 
            this.spcCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcCont.Location = new System.Drawing.Point(10, 10);
            this.spcCont.Margin = new System.Windows.Forms.Padding(0);
            this.spcCont.Name = "spcCont";
            // 
            // spcCont.Panel1
            // 
            this.spcCont.Panel1.Controls.Add(this.pnlBotonera);
            this.spcCont.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            // 
            // spcCont.Panel2
            // 
            this.spcCont.Panel2.Controls.Add(this.nudPrecioVenta);
            this.spcCont.Panel2.Controls.Add(this.nudPrecioCompra);
            this.spcCont.Panel2.Controls.Add(this.nudStock);
            this.spcCont.Panel2.Controls.Add(this.lblRepuesto);
            this.spcCont.Panel2.Controls.Add(this.btnLimpiar);
            this.spcCont.Panel2.Controls.Add(this.btnCancelar);
            this.spcCont.Panel2.Controls.Add(this.btnGuardar);
            this.spcCont.Panel2.Controls.Add(this.tbDescipcion);
            this.spcCont.Panel2.Controls.Add(this.lblDescripcion);
            this.spcCont.Panel2.Controls.Add(this.lblStock);
            this.spcCont.Panel2.Controls.Add(this.lblPrecioCompra);
            this.spcCont.Panel2.Controls.Add(this.lbPrecioVenta);
            this.spcCont.Panel2.Controls.Add(this.tbCodigo);
            this.spcCont.Panel2.Controls.Add(this.lblCodigo);
            this.spcCont.Size = new System.Drawing.Size(1159, 524);
            this.spcCont.SplitterDistance = 778;
            this.spcCont.TabIndex = 0;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnEliminarCliente);
            this.pnlBotonera.Controls.Add(this.btnEditar);
            this.pnlBotonera.Controls.Add(this.btnAgregar);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(10, 473);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(756, 39);
            this.pnlBotonera.TabIndex = 1;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.Location = new System.Drawing.Point(438, 7);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(92, 26);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(340, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 26);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(242, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 26);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudStock
            // 
            this.nudStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStock.Location = new System.Drawing.Point(135, 266);
            this.nudStock.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(216, 23);
            this.nudStock.TabIndex = 8;
            this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.ForeColor = System.Drawing.Color.White;
            this.lblRepuesto.Location = new System.Drawing.Point(139, 71);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(78, 18);
            this.lblRepuesto.TabIndex = 0;
            this.lblRepuesto.Text = "REPUESTO";
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
            this.btnLimpiar.Location = new System.Drawing.Point(142, 449);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 26);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(44, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 26);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(240, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 26);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbDescipcion
            // 
            this.tbDescipcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescipcion.Location = new System.Drawing.Point(135, 308);
            this.tbDescipcion.MaxLength = 1000;
            this.tbDescipcion.Multiline = true;
            this.tbDescipcion.Name = "tbDescipcion";
            this.tbDescipcion.Size = new System.Drawing.Size(214, 79);
            this.tbDescipcion.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescripcion.Location = new System.Drawing.Point(37, 311);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 17);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStock.Location = new System.Drawing.Point(70, 268);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioCompra.Location = new System.Drawing.Point(13, 184);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(107, 17);
            this.lblPrecioCompra.TabIndex = 3;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrecioVenta.Location = new System.Drawing.Point(29, 224);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(91, 17);
            this.lbPrecioVenta.TabIndex = 5;
            this.lbPrecioVenta.Text = "Precio Venta";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigo.Location = new System.Drawing.Point(135, 142);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(214, 23);
            this.tbCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(55, 145);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrecioCompra.DecimalPlaces = 2;
            this.nudPrecioCompra.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPrecioCompra.Location = new System.Drawing.Point(135, 182);
            this.nudPrecioCompra.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(216, 23);
            this.nudPrecioCompra.TabIndex = 4;
            this.nudPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrecioVenta.DecimalPlaces = 2;
            this.nudPrecioVenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPrecioVenta.Location = new System.Drawing.Point(133, 222);
            this.nudPrecioVenta.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(216, 23);
            this.nudPrecioVenta.TabIndex = 6;
            this.nudPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1179, 544);
            this.Controls.Add(this.spcCont);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepuestos";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMisDatos";
            this.spcCont.Panel1.ResumeLayout(false);
            this.spcCont.Panel2.ResumeLayout(false);
            this.spcCont.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCont)).EndInit();
            this.spcCont.ResumeLayout(false);
            this.pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcCont;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbDescipcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
    }
}