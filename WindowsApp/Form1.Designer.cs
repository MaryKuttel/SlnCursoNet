namespace WindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnProducto = new System.Windows.Forms.Button();
            this.bttnVendedor = new System.Windows.Forms.Button();
            this.bttnEmpresa = new System.Windows.Forms.Button();
            this.bttnFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnProducto
            // 
            this.bttnProducto.BackColor = System.Drawing.Color.DarkOrchid;
            this.bttnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnProducto.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnProducto.Location = new System.Drawing.Point(410, 12);
            this.bttnProducto.Name = "bttnProducto";
            this.bttnProducto.Size = new System.Drawing.Size(262, 111);
            this.bttnProducto.TabIndex = 0;
            this.bttnProducto.Text = " Ver Producto";
            this.bttnProducto.UseVisualStyleBackColor = false;
            this.bttnProducto.Click += new System.EventHandler(this.bttnProducto_Click);
            // 
            // bttnVendedor
            // 
            this.bttnVendedor.BackColor = System.Drawing.Color.DarkOrchid;
            this.bttnVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnVendedor.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVendedor.Location = new System.Drawing.Point(12, 12);
            this.bttnVendedor.Name = "bttnVendedor";
            this.bttnVendedor.Size = new System.Drawing.Size(262, 111);
            this.bttnVendedor.TabIndex = 1;
            this.bttnVendedor.Text = "Ver Vendedor";
            this.bttnVendedor.UseVisualStyleBackColor = false;
            this.bttnVendedor.Click += new System.EventHandler(this.bttnVendedor_Click);
            // 
            // bttnEmpresa
            // 
            this.bttnEmpresa.BackColor = System.Drawing.Color.DarkOrchid;
            this.bttnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bttnEmpresa.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEmpresa.Location = new System.Drawing.Point(12, 208);
            this.bttnEmpresa.Name = "bttnEmpresa";
            this.bttnEmpresa.Size = new System.Drawing.Size(262, 111);
            this.bttnEmpresa.TabIndex = 2;
            this.bttnEmpresa.Text = "Ver Empresa";
            this.bttnEmpresa.UseVisualStyleBackColor = false;
            this.bttnEmpresa.Click += new System.EventHandler(this.bttnEmpresa_Click);
            // 
            // bttnFactura
            // 
            this.bttnFactura.BackColor = System.Drawing.Color.DarkOrchid;
            this.bttnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFactura.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFactura.Location = new System.Drawing.Point(410, 208);
            this.bttnFactura.Name = "bttnFactura";
            this.bttnFactura.Size = new System.Drawing.Size(262, 111);
            this.bttnFactura.TabIndex = 3;
            this.bttnFactura.Text = "Ver Factura";
            this.bttnFactura.UseVisualStyleBackColor = false;
            this.bttnFactura.Click += new System.EventHandler(this.bttnFactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.bttnFactura);
            this.Controls.Add(this.bttnEmpresa);
            this.Controls.Add(this.bttnVendedor);
            this.Controls.Add(this.bttnProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnProducto;
        private System.Windows.Forms.Button bttnVendedor;
        private System.Windows.Forms.Button bttnEmpresa;
        private System.Windows.Forms.Button bttnFactura;
    }
}

