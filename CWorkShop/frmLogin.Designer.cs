﻿namespace CWorkShop.Vistas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(12, 30);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(150, 150);
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(502, 240);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape2";
            this.lineShape3.X1 = 201;
            this.lineShape3.X2 = 467;
            this.lineShape3.Y1 = 126;
            this.lineShape3.Y2 = 126;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 201;
            this.lineShape1.X2 = 467;
            this.lineShape1.Y1 = 75;
            this.lineShape1.Y2 = 75;
            // 
            // tbDni
            // 
            this.tbDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbDni.Location = new System.Drawing.Point(203, 55);
            this.tbDni.MaxLength = 8;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(265, 19);
            this.tbDni.TabIndex = 2;
            this.tbDni.Text = "DNI";
            this.tbDni.Enter += new System.EventHandler(this.tbDNI_Enter);
            this.tbDni.Leave += new System.EventHandler(this.tbDNI_Leave);
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbContraseña.Location = new System.Drawing.Point(203, 107);
            this.tbContraseña.MaxLength = 16;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(265, 19);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.Text = "CONTRASEÑA";
            this.tbContraseña.Enter += new System.EventHandler(this.tbContraseña_Enter);
            this.tbContraseña.Leave += new System.EventHandler(this.tbContraseña_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntrar.Location = new System.Drawing.Point(177, 188);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(127, 40);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarse.Location = new System.Drawing.Point(341, 188);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(127, 40);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogin.Location = new System.Drawing.Point(282, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(88, 28);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::CWorkShop.Properties.Resources.close16x16;
            this.pbCerrar.Location = new System.Drawing.Point(483, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(19, 20);
            this.pbCerrar.TabIndex = 13;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(502, 240);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbCerrar;
    }
}