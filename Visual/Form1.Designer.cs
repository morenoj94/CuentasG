namespace Visual
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnCuentasTotales = new System.Windows.Forms.Button();
            this.btnCuentasCliente = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblPorCobrar = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCuentasTotales
            // 
            this.btnCuentasTotales.Location = new System.Drawing.Point(72, 47);
            this.btnCuentasTotales.Name = "btnCuentasTotales";
            this.btnCuentasTotales.Size = new System.Drawing.Size(122, 42);
            this.btnCuentasTotales.TabIndex = 0;
            this.btnCuentasTotales.Text = "Cuentas Totales";
            this.btnCuentasTotales.UseVisualStyleBackColor = true;
            // 
            // btnCuentasCliente
            // 
            this.btnCuentasCliente.Location = new System.Drawing.Point(72, 144);
            this.btnCuentasCliente.Name = "btnCuentasCliente";
            this.btnCuentasCliente.Size = new System.Drawing.Size(122, 42);
            this.btnCuentasCliente.TabIndex = 1;
            this.btnCuentasCliente.Text = "Cuentas por cliente";
            this.btnCuentasCliente.UseVisualStyleBackColor = true;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(72, 244);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(122, 42);
            this.btnArticulos.TabIndex = 2;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(72, 343);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(122, 42);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // lblPorCobrar
            // 
            this.lblPorCobrar.AutoSize = true;
            this.lblPorCobrar.Location = new System.Drawing.Point(42, 29);
            this.lblPorCobrar.Name = "lblPorCobrar";
            this.lblPorCobrar.Size = new System.Drawing.Size(121, 16);
            this.lblPorCobrar.TabIndex = 4;
            this.lblPorCobrar.Text = "Cuentas por cobrar";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(82, 66);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPorCobrar);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Location = new System.Drawing.Point(424, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnCuentasCliente);
            this.Controls.Add(this.btnCuentasTotales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuentasG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCuentasTotales;
        private System.Windows.Forms.Button btnCuentasCliente;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblPorCobrar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

