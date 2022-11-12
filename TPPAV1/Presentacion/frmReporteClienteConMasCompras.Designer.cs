namespace TPPav1.Presentacion
{
    partial class frmReporteClienteConMasCompras
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
            this.rpvClientesMasCompras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTodosProductos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rpvClientesMasCompras
            // 
            this.rpvClientesMasCompras.LocalReport.ReportEmbeddedResource = "TPPav1.Reportes.rptClientesConMasCompras.rdlc";
            this.rpvClientesMasCompras.Location = new System.Drawing.Point(3, 192);
            this.rpvClientesMasCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rpvClientesMasCompras.Name = "rpvClientesMasCompras";
            this.rpvClientesMasCompras.ServerReport.BearerToken = null;
            this.rpvClientesMasCompras.Size = new System.Drawing.Size(1137, 579);
            this.rpvClientesMasCompras.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(276, 31);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(245, 22);
            this.dtpDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(655, 31);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(247, 22);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(809, 128);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 38);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(276, 85);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(245, 24);
            this.cboProductos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Productos";
            // 
            // cbTodosProductos
            // 
            this.cbTodosProductos.AutoSize = true;
            this.cbTodosProductos.Location = new System.Drawing.Point(184, 138);
            this.cbTodosProductos.Name = "cbTodosProductos";
            this.cbTodosProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTodosProductos.Size = new System.Drawing.Size(153, 20);
            this.cbTodosProductos.TabIndex = 9;
            this.cbTodosProductos.Text = "Todos los productos";
            this.cbTodosProductos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbTodosProductos.UseVisualStyleBackColor = true;
            this.cbTodosProductos.CheckStateChanged += new System.EventHandler(this.cbTodosProductos_CheckStateChanged);
            // 
            // frmReporteClienteConMasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1188, 785);
            this.Controls.Add(this.cbTodosProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvClientesMasCompras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporteClienteConMasCompras";
            this.Text = "ReporteClienteConMasCompras";
            this.Load += new System.EventHandler(this.frmReporteClienteConMasCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvClientesMasCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbTodosProductos;
    }
}