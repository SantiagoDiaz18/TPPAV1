namespace TPPav1.Presentacion
{
    partial class frmAltaFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarFactura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.gpbProducto = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnFijarCliente = new System.Windows.Forms.Button();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpbFactura = new System.Windows.Forms.GroupBox();
            this.gpbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gpbCliente.SuspendLayout();
            this.gpbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Emision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forma De Pago";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Location = new System.Drawing.Point(130, 59);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(389, 20);
            this.dtpFechaEmision.TabIndex = 3;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(130, 83);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(2);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(389, 21);
            this.cboFormaPago.TabIndex = 4;
            this.cboFormaPago.SelectedIndexChanged += new System.EventHandler(this.cboFormaPago_SelectedIndexChanged);
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(130, 27);
            this.cboTipoFactura.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(389, 21);
            this.cboTipoFactura.TabIndex = 5;
            this.cboTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cboTipoFactura_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(85, 17);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(243, 21);
            this.cboCliente.TabIndex = 7;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(110, 552);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.Location = new System.Drawing.Point(38, 552);
            this.btnAgregarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(56, 27);
            this.btnAgregarFactura.TabIndex = 9;
            this.btnAgregarFactura.Text = "Agregar";
            this.btnAgregarFactura.UseVisualStyleBackColor = true;
            this.btnAgregarFactura.Click += new System.EventHandler(this.btnAgregarFactura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(191, 552);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(66, 27);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(63, 21);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(39, 20);
            this.txtIdProducto.TabIndex = 13;
            // 
            // gpbProducto
            // 
            this.gpbProducto.Controls.Add(this.btnBuscarProducto);
            this.gpbProducto.Controls.Add(this.label9);
            this.gpbProducto.Controls.Add(this.txtTotalProducto);
            this.gpbProducto.Controls.Add(this.label8);
            this.gpbProducto.Controls.Add(this.btnAgregarProducto);
            this.gpbProducto.Controls.Add(this.txtPrecio);
            this.gpbProducto.Controls.Add(this.txtCantidad);
            this.gpbProducto.Controls.Add(this.label7);
            this.gpbProducto.Controls.Add(this.label5);
            this.gpbProducto.Controls.Add(this.txtDescripcion);
            this.gpbProducto.Controls.Add(this.label6);
            this.gpbProducto.Controls.Add(this.txtIdProducto);
            this.gpbProducto.Location = new System.Drawing.Point(7, 258);
            this.gpbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.gpbProducto.Name = "gpbProducto";
            this.gpbProducto.Padding = new System.Windows.Forms.Padding(2);
            this.gpbProducto.Size = new System.Drawing.Size(528, 112);
            this.gpbProducto.TabIndex = 14;
            this.gpbProducto.TabStop = false;
            this.gpbProducto.Text = "Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(114, 21);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(50, 20);
            this.btnBuscarProducto.TabIndex = 21;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total";
            // 
            // txtTotalProducto
            // 
            this.txtTotalProducto.Enabled = false;
            this.txtTotalProducto.Location = new System.Drawing.Point(347, 46);
            this.txtTotalProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalProducto.Name = "txtTotalProducto";
            this.txtTotalProducto.Size = new System.Drawing.Size(155, 20);
            this.txtTotalProducto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(369, 70);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(133, 33);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(171, 46);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(137, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(63, 46);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(39, 20);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(235, 21);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(267, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Id,
            this.Producto,
            this.Precio,
            this.Subtotal});
            this.dgvDetalle.Location = new System.Drawing.Point(13, 397);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(522, 124);
            this.dgvDetalle.TabIndex = 15;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(335, 554);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 20);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "TOTAL: $";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Location = new System.Drawing.Point(427, 556);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(99, 20);
            this.txtTotalFactura.TabIndex = 21;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(330, 76);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(82, 37);
            this.btnNuevoCliente.TabIndex = 22;
            this.btnNuevoCliente.Text = "Registrar Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnFijarCliente);
            this.gpbCliente.Controls.Add(this.cboTipoDoc);
            this.gpbCliente.Controls.Add(this.btnNuevoCliente);
            this.gpbCliente.Controls.Add(this.txtApellidoCliente);
            this.gpbCliente.Controls.Add(this.label12);
            this.gpbCliente.Controls.Add(this.txtNombreCliente);
            this.gpbCliente.Controls.Add(this.label11);
            this.gpbCliente.Controls.Add(this.label10);
            this.gpbCliente.Controls.Add(this.cboCliente);
            this.gpbCliente.Controls.Add(this.label4);
            this.gpbCliente.Location = new System.Drawing.Point(7, 140);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(528, 113);
            this.gpbCliente.TabIndex = 23;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // btnFijarCliente
            // 
            this.btnFijarCliente.Location = new System.Drawing.Point(435, 76);
            this.btnFijarCliente.Name = "btnFijarCliente";
            this.btnFijarCliente.Size = new System.Drawing.Size(82, 37);
            this.btnFijarCliente.TabIndex = 23;
            this.btnFijarCliente.Text = "Fijar Cliente Seleccionado";
            this.btnFijarCliente.UseVisualStyleBackColor = true;
            this.btnFijarCliente.Click += new System.EventHandler(this.btnFijarCliente_Click);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.Enabled = false;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(390, 17);
            this.cboTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(127, 21);
            this.cboTipoDoc.TabIndex = 14;
            this.cboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cboTipoDoc_SelectedIndexChanged);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Location = new System.Drawing.Point(332, 50);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(185, 20);
            this.txtApellidoCliente.TabIndex = 13;
            this.txtApellidoCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(85, 50);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(184, 20);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nombre";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tipo Doc";
            // 
            // gpbFactura
            // 
            this.gpbFactura.Controls.Add(this.cboTipoFactura);
            this.gpbFactura.Controls.Add(this.label1);
            this.gpbFactura.Controls.Add(this.label2);
            this.gpbFactura.Controls.Add(this.label3);
            this.gpbFactura.Controls.Add(this.dtpFechaEmision);
            this.gpbFactura.Controls.Add(this.cboFormaPago);
            this.gpbFactura.Location = new System.Drawing.Point(7, 12);
            this.gpbFactura.Name = "gpbFactura";
            this.gpbFactura.Size = new System.Drawing.Size(528, 112);
            this.gpbFactura.TabIndex = 23;
            this.gpbFactura.TabStop = false;
            this.gpbFactura.Text = "Factura";
            // 
            // frmAltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 597);
            this.Controls.Add(this.gpbFactura);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.gpbProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarFactura);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Factura";
            this.Load += new System.EventHandler(this.frmAltaFactura_Load);
            this.gpbProducto.ResumeLayout(false);
            this.gpbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbFactura.ResumeLayout(false);
            this.gpbFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarFactura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.GroupBox gpbProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.GroupBox gpbFactura;
        private System.Windows.Forms.Button btnFijarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}