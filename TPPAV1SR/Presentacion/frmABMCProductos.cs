using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPav1.Entidades;
using TPPav1.Servicios.Implementaciones;

namespace TPPav1.Presentacion
{
    public partial class frmABMCProductos : Form
    {
        public frmABMCProductos()
        {
            InitializeComponent();
        }


        enum Acciones
        {
            Alta, 
            Modificacion,
            Baja,
        }

        Acciones MiAccion;
        ProductoService oProducto = new ProductoService();
        ProductoColorService oColor = new ProductoColorService();
        ProductoMaterialService oMaterial = new ProductoMaterialService();
        TipoPService oTipo = new TipoPService();

        private void frmABMCProductos_Load(object sender, EventArgs e)
        {
            CargarComboTP(cmbTipo, oTipo.traerTodosTP());
            CargarComboColor(cmbColor, oColor.traerTodosPrC());
            CargarComboMaterial(cmbMaterial, oMaterial.traerTodosPrM());
            //CargarGrillaP(gdrProductos, oProducto.traerTodosP());
            //ModoEdicion(false);
            ModoConsulta(true);
            MiAccion = Acciones.Modificacion;
        }

        private void ModoEdicion(bool b)
        {
            btnEliminarPr.Enabled = !b;
            btnCancelarPr.Enabled = b;
            btnEditarPr.Enabled = !b;
            btnGuardarPr.Enabled = b;
            btnAgregarPr.Enabled = !b;
            btnSalirPr.Enabled = !b;
            btnBuscarProducto.Enabled = !b;
            gdrProductos.Enabled = !b;
            txtId.Enabled = !b;
            cmbTipo.Enabled = b;
            cmbColor.Enabled = b;
            cmbMaterial.Enabled = b;
            txtCosto.Enabled = b;
            txtPrecio.Enabled = b;
            txtPeso.Enabled = b;
            txtLargo.Enabled = b;
            txtAncho.Enabled = b;
            txtAlto.Enabled = b;
            txtCantidad.Enabled = b;
            dtpGarantia.Enabled = b;
            txtProveedor.Enabled = b;

        }

        private void ModoConsulta(bool b)
        {
            btnEliminarPr.Enabled = !b;
            btnCancelarPr.Enabled = !b;
            btnEditarPr.Enabled = !b;
            btnGuardarPr.Enabled = !b;
            btnAgregarPr.Enabled = b;
            btnSalirPr.Enabled = b;
            btnBuscarProducto.Enabled = b;
            gdrProductos.Enabled = b;
            txtId.Enabled = b;
            cmbTipo.Enabled = !b;
            cmbColor.Enabled = !b;
            cmbMaterial.Enabled = !b;
            txtCosto.Enabled = !b;
            txtPrecio.Enabled = !b;
            txtPeso.Enabled = !b;
            txtLargo.Enabled = !b;
            txtAncho.Enabled = !b;
            txtAlto.Enabled = !b;
            txtCantidad.Enabled = !b;
            dtpGarantia.Enabled = !b;
            txtProveedor.Enabled = !b;
        }

        private void LimpiarCampos()
        {
            txtId.Text = String.Empty;
            cmbTipo.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            cmbMaterial.SelectedIndex = -1;
            txtPrecio.Text = String.Empty;
            txtCosto.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtLargo.Text = String.Empty;
            txtAncho.Text = String.Empty;
            txtAlto.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            dtpGarantia.Value = DateTime.Now;
            txtProveedor.Text = String.Empty;

        }
        private void CargarComboTP(ComboBox combo, List<TipoProducto> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdTipo";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboColor(ComboBox combo, List<ProductoColor> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "IdColor";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboMaterial(ComboBox combo, List<ProductoMaterial> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "IdMaterial";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrillaP(DataGridView grilla, List<Producto> lista)
        {
            grilla.Rows.Clear();
            foreach (Producto fila in lista)
            {
                grilla.Rows.Add(fila.IdProducto, fila.IdTipo.Nombre, fila.IdColor.Descripcion, fila.IdMaterial.Descripcion
                    , fila.Precio, fila.Costo, fila.Peso, fila.Largo, fila.Ancho, fila.Alto, fila.Stock, fila.PeriodoGarantia, fila.IdProveedor);
            }
            grilla.Focus();
         
            
            
        }

        private void LimpiarGrilla()
        {
            gdrProductos.Rows.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPr_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            ModoEdicion(true);
            LimpiarCampos();
            cmbTipo.Focus();
        }

        private void btnEliminarPr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este Producto?"
                               , "ELIMINANDO"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Warning
                               , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Delete 
                if (oProducto.eliminarProducto((int)gdrProductos.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El usuario se eliminó con éxito!!!");
                    CargarGrillaP(gdrProductos, oProducto.traerTodosP());
                }
            }
        }

        private void btnEditarPr_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            ModoEdicion(true);
            cmbTipo.Focus();
        }

        private void btnGuardarPr_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //Crear y Cargar objeto
                Producto u = new Producto();
                //u.IdProducto = int.Parse(txtId.Text);
                u.IdTipo = (TipoProducto)cmbTipo.SelectedItem;
                u.IdColor = (ProductoColor)cmbColor.SelectedItem;
                u.IdMaterial = (ProductoMaterial)cmbMaterial.SelectedItem;
                u.Precio = int.Parse(txtPrecio.Text);
                u.Costo  = int.Parse(txtCosto.Text);
                u.Peso = int.Parse(txtPeso.Text);
                u.Largo = int.Parse(txtLargo.Text);
                u.Ancho = int.Parse(txtAncho.Text);
                u.Alto = int.Parse(txtAlto.Text);
                u.Stock = int.Parse(txtCantidad.Text);
                u.PeriodoGarantia = dtpGarantia.Value;
                u.IdProveedor = int.Parse(txtProveedor.Text);

                if (MiAccion == Acciones.Alta)
                {
                    //insert

                    if (oProducto.insertarProducto(u) > 0)
                        MessageBox.Show("El producto se agrego con éxito!!!");
                    //else
                    //    MessageBox.Show("Ese nombre de usuario ya existe.");
                }
                else
                {
                    //update
                    u.IdProducto = int.Parse(txtId.Text);
                    if (oProducto.actualizarProducto(u) > 0)
                        MessageBox.Show("El producto se actualizó con éxito!!!");
                }
                LimpiarCampos();

            }


            ModoConsulta(true);
        }

        private bool ValidarDatos()
        {
            if (cmbTipo.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar tipo ...");
                cmbTipo.Focus();
                return false;
            }
            if (cmbColor.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar color ...");
                cmbColor.Focus();
                return false;
            }
            if (cmbMaterial.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar material ...");
                cmbMaterial.Focus();
                return false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar precio ...");
                txtPrecio.Focus();
                return false;

            }
            if (txtCosto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar costo ...");
                txtCosto.Focus();
                return false;
            }
            if (txtPeso.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar peso ...");
                txtPeso.Focus();
                return false;
            }
            if (txtLargo.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar largo ...");
                txtLargo.Focus();
                return false;
            }

            if (txtAncho.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar ancho ...");
                txtAncho.Focus();
                return false;
            }
            if (txtAlto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar alto ...");
                txtLargo.Focus();
                return false;
            }
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar cantidad de stock ...");
                txtCantidad.Focus();
                return false;
            }
            if (dtpGarantia.Value < DateTime.Now)
            {
                MessageBox.Show("Debe ingresar periodo posterior a la fecha actual...");
                dtpGarantia.Focus();
                return false;
            }
            if (txtProveedor.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar proveedor ...");
                txtProveedor.Focus();
                return false;
            }

            return true; ;
        }

        private void btnCancelarPr_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            LimpiarCampos();
            MiAccion = Acciones.Modificacion;
        }

        private void btnSalirPr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos(int id)
        {

            List < Producto > lista = oProducto.traerPorIdP(id);
            foreach (Producto producto in lista)
            {
                txtId.Text = producto.IdProducto.ToString();
                cmbTipo.SelectedValue = producto.IdTipo.IdTipo;
                cmbColor.SelectedValue = producto.IdColor.IdColor;
                cmbMaterial.SelectedValue = producto.IdMaterial.IdMaterial;
                txtPrecio.Text = producto.Precio.ToString();
                txtCosto.Text = producto.Costo.ToString();
                txtPeso.Text = producto.Peso.ToString();
                txtLargo.Text = producto.Largo.ToString();
                txtAncho.Text = producto.Ancho.ToString();
                txtAlto.Text = producto.Alto.ToString();
                txtCantidad.Text = producto.Stock.ToString();
                dtpGarantia.Value = producto.PeriodoGarantia;
                txtProveedor.Text = producto.IdProveedor.ToString();
            }
        }

        private void gdrProductos_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)gdrProductos.CurrentRow.Cells[0].Value);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            if (txtId.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Numero");
                txtId.Focus();
                ModoConsulta(true);
            }
            else
                CargarGrillaP(gdrProductos, oProducto.traerPorIdP(Convert.ToInt32(txtId.Text)));
        }

        private void cbMostrarTodosProductos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbMostrarTodosProductos.Checked)
            {
                ModoEdicion(false);
                CargarGrillaP(gdrProductos, oProducto.traerTodosP());
            }
            else
            {
                ModoConsulta(true);
                LimpiarGrilla();
                LimpiarCampos();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
