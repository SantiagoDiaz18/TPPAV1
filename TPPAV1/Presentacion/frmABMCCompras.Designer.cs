namespace TPPav1.Presentacion
{
    partial class frmABMCCompras
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
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AllowDrop = true;
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(65, 47);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(39, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Cliente";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de emisión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medio de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Detalle de compra";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(167, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(194, 20);
            this.txtCliente.TabIndex = 6;
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(167, 76);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(194, 21);
            this.cboTipoFactura.TabIndex = 7;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(167, 113);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(194, 20);
            this.txtNroFactura.TabIndex = 8;
            // 
            // dtpEmision
            // 
            this.dtpEmision.Location = new System.Drawing.Point(167, 153);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(194, 20);
            this.dtpEmision.TabIndex = 9;
            this.dtpEmision.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboPago
            // 
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(167, 189);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(194, 21);
            this.cboPago.TabIndex = 10;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(167, 232);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(194, 20);
            this.txtDetalle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "(Productos,Cantidad,Precio/u)";
            // 
            // frmABMCCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 311);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.cboPago);
            this.Controls.Add(this.dtpEmision);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Name = "frmABMCCompras";
            this.Text = "Administración de Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label6;
    }
}