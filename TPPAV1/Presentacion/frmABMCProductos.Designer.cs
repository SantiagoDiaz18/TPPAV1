namespace TPPav1.Presentacion
{
    partial class frmABMCProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMCProductos));
            this.label4 = new System.Windows.Forms.Label();
            this.cbMostrarTodosProductos = new System.Windows.Forms.CheckBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnSalirPr = new System.Windows.Forms.Button();
            this.btnCancelarPr = new System.Windows.Forms.Button();
            this.btnGuardarPr = new System.Windows.Forms.Button();
            this.btnEliminarPr = new System.Windows.Forms.Button();
            this.btnEditarPr = new System.Windows.Forms.Button();
            this.btnAgregarPr = new System.Windows.Forms.Button();
            this.gdrProductos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpGarantia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gdrProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Proveedor (*):";
            // 
            // cbMostrarTodosProductos
            // 
            this.cbMostrarTodosProductos.AutoSize = true;
            this.cbMostrarTodosProductos.Location = new System.Drawing.Point(115, 362);
            this.cbMostrarTodosProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMostrarTodosProductos.Name = "cbMostrarTodosProductos";
            this.cbMostrarTodosProductos.Size = new System.Drawing.Size(111, 20);
            this.cbMostrarTodosProductos.TabIndex = 28;
            this.cbMostrarTodosProductos.Text = "Mostrar todos";
            this.cbMostrarTodosProductos.UseVisualStyleBackColor = true;
            this.cbMostrarTodosProductos.CheckedChanged += new System.EventHandler(this.cbMostrarTodosProductos_CheckedChanged);
            this.cbMostrarTodosProductos.CheckStateChanged += new System.EventHandler(this.cbMostrarTodosProductos_CheckStateChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(572, 340);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(179, 43);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnSalirPr
            // 
            this.btnSalirPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalirPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPr.Location = new System.Drawing.Point(700, 604);
            this.btnSalirPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalirPr.Name = "btnSalirPr";
            this.btnSalirPr.Size = new System.Drawing.Size(100, 28);
            this.btnSalirPr.TabIndex = 34;
            this.btnSalirPr.Text = "Salir";
            this.btnSalirPr.UseVisualStyleBackColor = false;
            this.btnSalirPr.Click += new System.EventHandler(this.btnSalirPr_Click);
            // 
            // btnCancelarPr
            // 
            this.btnCancelarPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPr.Location = new System.Drawing.Point(572, 604);
            this.btnCancelarPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarPr.Name = "btnCancelarPr";
            this.btnCancelarPr.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarPr.TabIndex = 33;
            this.btnCancelarPr.Text = "Cancelar";
            this.btnCancelarPr.UseVisualStyleBackColor = false;
            this.btnCancelarPr.Click += new System.EventHandler(this.btnCancelarPr_Click);
            // 
            // btnGuardarPr
            // 
            this.btnGuardarPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPr.Location = new System.Drawing.Point(464, 604);
            this.btnGuardarPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarPr.Name = "btnGuardarPr";
            this.btnGuardarPr.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarPr.TabIndex = 32;
            this.btnGuardarPr.Text = "Guardar";
            this.btnGuardarPr.UseVisualStyleBackColor = false;
            this.btnGuardarPr.Click += new System.EventHandler(this.btnGuardarPr_Click);
            // 
            // btnEliminarPr
            // 
            this.btnEliminarPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPr.Location = new System.Drawing.Point(304, 604);
            this.btnEliminarPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarPr.Name = "btnEliminarPr";
            this.btnEliminarPr.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarPr.TabIndex = 31;
            this.btnEliminarPr.Text = "Eliminar";
            this.btnEliminarPr.UseVisualStyleBackColor = false;
            this.btnEliminarPr.Click += new System.EventHandler(this.btnEliminarPr_Click);
            // 
            // btnEditarPr
            // 
            this.btnEditarPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPr.Location = new System.Drawing.Point(192, 604);
            this.btnEditarPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarPr.Name = "btnEditarPr";
            this.btnEditarPr.Size = new System.Drawing.Size(100, 28);
            this.btnEditarPr.TabIndex = 30;
            this.btnEditarPr.Text = "Editar";
            this.btnEditarPr.UseVisualStyleBackColor = false;
            this.btnEditarPr.Click += new System.EventHandler(this.btnEditarPr_Click);
            // 
            // btnAgregarPr
            // 
            this.btnAgregarPr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPr.Location = new System.Drawing.Point(84, 604);
            this.btnAgregarPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarPr.Name = "btnAgregarPr";
            this.btnAgregarPr.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarPr.TabIndex = 29;
            this.btnAgregarPr.Text = "Agregar";
            this.btnAgregarPr.UseVisualStyleBackColor = false;
            this.btnAgregarPr.Click += new System.EventHandler(this.btnAgregarPr_Click);
            // 
            // gdrProductos
            // 
            this.gdrProductos.AllowUserToAddRows = false;
            this.gdrProductos.AllowUserToDeleteRows = false;
            this.gdrProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTipo,
            this.colColor,
            this.colMaterial,
            this.colPrecio,
            this.colCosto,
            this.colPeso,
            this.colLargo,
            this.colAncho,
            this.colAlto,
            this.colStock,
            this.colPeriodo,
            this.colProveedor});
            this.gdrProductos.Location = new System.Drawing.Point(39, 390);
            this.gdrProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gdrProductos.Name = "gdrProductos";
            this.gdrProductos.ReadOnly = true;
            this.gdrProductos.RowHeadersWidth = 51;
            this.gdrProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdrProductos.Size = new System.Drawing.Size(800, 185);
            this.gdrProductos.TabIndex = 35;
            this.gdrProductos.SelectionChanged += new System.EventHandler(this.gdrProductos_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id Producto";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 60;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 125;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Width = 125;
            // 
            // colMaterial
            // 
            this.colMaterial.HeaderText = "Material";
            this.colMaterial.MinimumWidth = 6;
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.ReadOnly = true;
            this.colMaterial.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 125;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.MinimumWidth = 6;
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            this.colCosto.Width = 125;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.MinimumWidth = 6;
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            this.colPeso.Width = 125;
            // 
            // colLargo
            // 
            this.colLargo.HeaderText = "Largo";
            this.colLargo.MinimumWidth = 6;
            this.colLargo.Name = "colLargo";
            this.colLargo.ReadOnly = true;
            this.colLargo.Width = 125;
            // 
            // colAncho
            // 
            this.colAncho.HeaderText = "Ancho";
            this.colAncho.MinimumWidth = 6;
            this.colAncho.Name = "colAncho";
            this.colAncho.ReadOnly = true;
            this.colAncho.Width = 125;
            // 
            // colAlto
            // 
            this.colAlto.HeaderText = "Alto";
            this.colAlto.MinimumWidth = 6;
            this.colAlto.Name = "colAlto";
            this.colAlto.ReadOnly = true;
            this.colAlto.Width = 125;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 125;
            // 
            // colPeriodo
            // 
            this.colPeriodo.HeaderText = "Garantia";
            this.colPeriodo.MinimumWidth = 6;
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.ReadOnly = true;
            this.colPeriodo.Width = 125;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 6;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            this.colProveedor.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 18);
            this.label11.TabIndex = 79;
            this.label11.Text = "Periodo de Garantia (*):";
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(572, 151);
            this.txtAlto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(243, 22);
            this.txtAlto.TabIndex = 74;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(572, 194);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(243, 22);
            this.txtCantidad.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "Alto (*):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 18);
            this.label10.TabIndex = 76;
            this.label10.Text = "Cantidad en Stock (*):";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(572, 71);
            this.txtLargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(243, 22);
            this.txtLargo.TabIndex = 70;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(572, 108);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(243, 22);
            this.txtAncho.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Largo (*):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 72;
            this.label8.Text = "Ancho (*):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 69;
            this.label5.Text = "Id Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Tipo (*): ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(127, 194);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 22);
            this.txtPrecio.TabIndex = 63;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Material (*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Precio (*):";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(572, 33);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(243, 22);
            this.txtPeso.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Color (*):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(492, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 60;
            this.label12.Text = "Peso (*):";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(127, 110);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(195, 24);
            this.cmbColor.TabIndex = 80;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(127, 151);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(195, 24);
            this.cmbMaterial.TabIndex = 81;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(127, 69);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(195, 24);
            this.cmbTipo.TabIndex = 82;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(127, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(107, 22);
            this.txtId.TabIndex = 83;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(127, 236);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(111, 22);
            this.txtCosto.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 236);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 85;
            this.label13.Text = "Costo (*):";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(572, 282);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(107, 22);
            this.txtProveedor.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 24);
            this.label14.TabIndex = 87;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(247, 239);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 24);
            this.label15.TabIndex = 88;
            this.label15.Text = "$";
            // 
            // dtpGarantia
            // 
            this.dtpGarantia.Location = new System.Drawing.Point(572, 236);
            this.dtpGarantia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGarantia.Name = "dtpGarantia";
            this.dtpGarantia.Size = new System.Drawing.Size(265, 22);
            this.dtpGarantia.TabIndex = 89;
            // 
            // frmABMCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 658);
            this.Controls.Add(this.dtpGarantia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMostrarTodosProductos);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnSalirPr);
            this.Controls.Add(this.btnCancelarPr);
            this.Controls.Add(this.btnGuardarPr);
            this.Controls.Add(this.btnEliminarPr);
            this.Controls.Add(this.btnEditarPr);
            this.Controls.Add(this.btnAgregarPr);
            this.Controls.Add(this.gdrProductos);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmABMCProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABMCProductos";
            this.Load += new System.EventHandler(this.frmABMCProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbMostrarTodosProductos;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnSalirPr;
        private System.Windows.Forms.Button btnCancelarPr;
        private System.Windows.Forms.Button btnGuardarPr;
        private System.Windows.Forms.Button btnEliminarPr;
        private System.Windows.Forms.Button btnEditarPr;
        private System.Windows.Forms.Button btnAgregarPr;
        private System.Windows.Forms.DataGridView gdrProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpGarantia;
    }
}