namespace CWorkShop.Vistas
{
    partial class frmMain
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.pMarcador = new System.Windows.Forms.Panel();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnDatos = new System.Windows.Forms.Button();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pMenu.Controls.Add(this.pMarcador);
            this.pMenu.Controls.Add(this.btnRepuestos);
            this.pMenu.Controls.Add(this.btnOrdenes);
            this.pMenu.Controls.Add(this.btnClientes);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pMenu.Size = new System.Drawing.Size(121, 700);
            this.pMenu.TabIndex = 0;
            this.pMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // pMarcador
            // 
            this.pMarcador.BackColor = System.Drawing.Color.RoyalBlue;
            this.pMarcador.Location = new System.Drawing.Point(114, 30);
            this.pMarcador.Name = "pMarcador";
            this.pMarcador.Size = new System.Drawing.Size(7, 80);
            this.pMarcador.TabIndex = 0;
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepuestos.FlatAppearance.BorderSize = 0;
            this.btnRepuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepuestos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepuestos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRepuestos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepuestos.ImageKey = "(ninguno)";
            this.btnRepuestos.Location = new System.Drawing.Point(0, 190);
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(121, 80);
            this.btnRepuestos.TabIndex = 3;
            this.btnRepuestos.TabStop = false;
            this.btnRepuestos.Text = "REPUESTOS";
            this.btnRepuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRepuestos.UseVisualStyleBackColor = true;
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenes.ImageKey = "(ninguno)";
            this.btnOrdenes.Location = new System.Drawing.Point(0, 110);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(121, 80);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.TabStop = false;
            this.btnOrdenes.Text = "ORDENES";
            this.btnOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.ImageKey = "(ninguno)";
            this.btnClientes.Location = new System.Drawing.Point(0, 30);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(121, 80);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.TabStop = false;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pHeader.Controls.Add(this.btnDatos);
            this.pHeader.Controls.Add(this.pbMinimizar);
            this.pHeader.Controls.Add(this.pbCerrar);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(121, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.pHeader.Size = new System.Drawing.Size(1079, 30);
            this.pHeader.TabIndex = 0;
            this.pHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btnDatos
            // 
            this.btnDatos.AutoSize = true;
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDatos.Location = new System.Drawing.Point(806, 0);
            this.btnDatos.Margin = new System.Windows.Forms.Padding(0);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(150, 30);
            this.btnDatos.TabIndex = 0;
            this.btnDatos.TabStop = false;
            this.btnDatos.Text = "btnDatos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMinimizar.Image = global::CWorkShop.Properties.Resources.min16x16;
            this.pbMinimizar.Location = new System.Drawing.Point(1022, 5);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(100, 3, 30, 3);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(32, 15);
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = global::CWorkShop.Properties.Resources.close16x16;
            this.pbCerrar.Location = new System.Drawing.Point(1054, 5);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 15);
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContenedor.Location = new System.Drawing.Point(127, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1073, 670);
            this.pnlContenedor.TabIndex = 1;
            this.pnlContenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CWorkShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pMenu.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnRepuestos;
        private System.Windows.Forms.Panel pMarcador;
    }
}