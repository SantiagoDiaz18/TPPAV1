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
            txtPeriodo.Enabled = b;
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
            txtPeriodo.Enabled = !b;
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
            txtPeriodo.Text = String.Empty;
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

        private void CargarGrillaP(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idProducto"],
                                tabla.Rows[i]["idTipo"],
                                tabla.Rows[i]["idColor"],
                                tabla.Rows[i]["idMaterial"],
                                tabla.Rows[i]["precio"],
                                tabla.Rows[i]["costo"],
                                tabla.Rows[i]["peso"],
                                tabla.Rows[i]["largo"],
                                tabla.Rows[i]["ancho"],
                                tabla.Rows[i]["alto"],
                                tabla.Rows[i]["stock"],
                                tabla.Rows[i]["periodoGarantia"],
                                tabla.Rows[i]["idProveedor"]);
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
                u.PeriodoGarantia = int.Parse(txtPeriodo.Text);
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
            if (txtPeriodo.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar periodo ...");
                txtPeriodo.Focus();
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

            DataTable tabla = oProducto.traerPorIdP(id);
            if (tabla.Rows.Count > 0)
            {
                txtId.Text = tabla.Rows[0]["idProducto"].ToString();
                cmbTipo.SelectedValue = tabla.Rows[0]["idTipo"];
                cmbColor.SelectedValue = tabla.Rows[0]["idColor"];
                cmbMaterial.SelectedValue = tabla.Rows[0]["idMaterial"];
                txtPrecio.Text = tabla.Rows[0]["precio"].ToString();
                txtCosto.Text = tabla.Rows[0]["costo"].ToString();
                txtPeso.Text = tabla.Rows[0]["peso"].ToString();
                txtLargo.Text = tabla.Rows[0]["largo"].ToString();
                txtAncho.Text = tabla.Rows[0]["ancho"].ToString();
                txtAlto.Text = tabla.Rows[0]["alto"].ToString();
                txtCantidad.Text = tabla.Rows[0]["stock"].ToString();
                txtPeriodo.Text = tabla.Rows[0]["periodoGarantia"].ToString();
                txtProveedor.Text = tabla.Rows[0]["idProveedor"].ToString();
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
