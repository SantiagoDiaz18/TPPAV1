using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPav1.Datos;
using TPPav1.Entidades;
using TPPav1.Servicios.Implementaciones;

namespace TPPav1.Presentacion
{
    public partial class frmAltaFactura : Form
    {
        ProductoService oProducto = new ProductoService();

        Factura oFactura = null;
        FacturaService oServicioFactura = new FacturaService();
        DetalleFactura oDetalle = null;
        FormaPagoService oFP = new FormaPagoService();
        TipoFService oF = new TipoFService();
        ClienteService oC = new ClienteService();
        TipoDService oTipoD = new TipoDService();
        //List<Producto> lista = new List<Producto>();

        public frmAltaFactura()
        {
            InitializeComponent();
        }

        private void frmAltaFactura_Load(object sender, EventArgs e)
        {
            CargarComboFormaPago(cboFormaPago, oFP.traerTodos());
            CargarComboTipoFactura(cboTipoFactura, oF.traerTodos());
            CargarComboCliente(cboCliente, oC.traerTodosC());
            CargarComboTipoDoc(cboTipoDoc, oTipoD.traerTodosD());
            ModoCargaFactura();
        }

        //private int RecuperarPorNroDoc(int nro)
        //{
        //    Cliente oCliente = new Cliente();
        //    List<Cliente> lista = new List<Cliente>();
        //    string consulta = "select c.nroDoc,c.tipoDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento," +
        //        "c.idSexo,s.descripcionS,c.idbarrio ,b.nombreBarrio, c.telefono from Clientes c join " +
        //    "TipoDocumento t on(c.tipoDoc= t.idTipo) join TipoSexo s on(c.idSexo = s.idSexo) " +
        //    "join Barrios b on(c.idBarrio = b.idBarrio) " +
        //        "WHERE nroDoc=" + nro.ToString();
        //    //string consulta = "Select * from Barrios WHERE borrado=0 AND idBarrio=" + id.ToString();
        //    DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
        //    if (tabla.Rows.Count > 0)
        //    {
        //        oCliente.NroDoc = (int)tabla.Rows[0]["nroDoc"];
        //        oCliente.TipoDoc.IdTipoD = (int)tabla.Rows[0]["tipoDoc"];
        //        oCliente.TipoDoc.Descripcion = tabla.Rows[0]["descripcion"].ToString();
        //        oCliente.Nombre = tabla.Rows[0]["nombre"].ToString();
        //        oCliente.Apellido = tabla.Rows[0]["apellido"].ToString();
        //        oCliente.Telefono = (int)tabla.Rows[0]["telefono"];
        //        oCliente.IdSexo.IdSexo = (int)tabla.Rows[0]["idSexo"];
        //        oCliente.IdSexo.DescripcionS = tabla.Rows[0]["DescripcionS"].ToString();
        //        oCliente.FechaNacimiento = (DateTime)tabla.Rows[0]["fechaNacimiento"];
        //        oCliente.IdBarrio.IdBarrio = (int)tabla.Rows[0]["idBarrio"];
        //        oCliente.IdBarrio.NombreBarrio = tabla.Rows[0]["nombreBarrio"].ToString();
        //        lista.Add(oCliente); ;
        //    }
        //    return oCliente.TipoDoc.IdTipoD;

        //}

        private void CargarComboTipoFactura(ComboBox combo, List<TipoFactura> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "id";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboFormaPago(ComboBox combo, List<FormaPago> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "idFormaPago";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboCliente(ComboBox combo, List<Cliente> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "nroDoc";
            combo.ValueMember = "nroDoc";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
      

        }

       

        private void CargarComboTipoDoc(ComboBox combo, List<TipoDocumento> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "IdTipoD";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
                     
        }

        private void CargarCamposCliente(int id)
        {
            
            List <Cliente> lista = oC.traerPorIdC(id);

            foreach (Cliente c in lista)
            {
                txtApellidoCliente.Text = c.Apellido;
                txtNombreCliente.Text = c.Nombre;
                cboTipoDoc.SelectedValue = c.TipoDoc.IdTipoD;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el id del producto...");
                txtIdProducto.Focus();
            }
            else
            {
                CargarCampos(Convert.ToInt32(txtIdProducto.Text));
            }
            if (txtCantidad.Text != string.Empty && txtPrecio.Text != string.Empty)
            {
                calcularTotalProducto();
            }
        }

        private bool ValidarDatos()
        {
            if (txtIdProducto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el id del producto...");
                txtIdProducto.Focus();
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Necesita la descripcion del producto...");
                return false;
            }
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la cantidad...");
                txtCantidad.Focus();
                return false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Necesita el precio del producto...");
                return false;
            }

            return true;
        }

        private void CargarCampos(int id)
        {


            List<Producto> lista = oProducto.traerPorIdP(id);


            foreach (Producto p in lista)
            {
                txtDescripcion.Text = p.IdTipo.Nombre;
                txtPrecio.Text = p.Precio.ToString();
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
           
            if (txtCantidad.Text != "" && txtPrecio.Text != "")
            {
               calcularTotalProducto();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool aux = false;
            if (validarCamposProducto())
            {
                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if (Convert.ToInt32(txtIdProducto.Text) == Convert.ToInt32(row.Cells[1].Value))
                    {
                        aux = true;
                        int cant;
                        cant = Convert.ToInt32(row.Cells[0].Value);
                        cant += Convert.ToInt32(txtCantidad.Text);
                        row.Cells[0].Value = cant;
                        int subt;
                        subt = Convert.ToInt32(row.Cells[4].Value) + Convert.ToInt32(txtTotalProducto.Text);
                        row.Cells[4].Value = subt;
                        txtTotalFactura.Text = calcularTotal().ToString();
                    }
                }
                if (!aux)
                {
                    dgvDetalle.Rows.Add(txtCantidad.Text, txtIdProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtTotalProducto.Text);
                    txtTotalFactura.Text = calcularTotal().ToString();
                    LimpiarCamposProducto();
                }
            }
            else
            {
                MessageBox.Show("Debe cargar todos los campos correctamente!!!!!");
            }
        }

        private double calcularTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvDetalle.Rows[i].Cells[4].Value);
            }
            return total;
        }

        private void LimpiarCamposProducto()
        {
            txtIdProducto.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtTotalProducto.Text = String.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            oFactura = new Factura();
            oFactura.TipoFactura.Id = (int)cboTipoFactura.SelectedValue;
            oFactura.TipoFactura.Descripcion = cboTipoFactura.SelectedItem.ToString();
            oFactura.Total = Convert.ToInt32(txtTotalFactura.Text);
            oFactura.FormaPago.IdFormaPago = (int)cboFormaPago.SelectedValue;
            oFactura.FormaPago.Descripcion = cboFormaPago.SelectedItem.ToString();
            oFactura.FechaEmision = dtpFechaEmision.Value;
            oFactura.Cliente.NroDoc = (int)cboCliente.SelectedValue;
            oFactura.Cliente.TipoDoc.IdTipoD = (int)cboTipoDoc.SelectedValue;

            foreach(DataGridViewRow fila in dgvDetalle.Rows)
            {
                oDetalle = new DetalleFactura();

                
                oDetalle.Cantidad = Convert.ToInt32(fila.Cells[0].Value);
                oDetalle.IdProducto.IdProducto = Convert.ToInt32(fila.Cells[1].Value);
                oDetalle.IdProducto.IdTipo.Nombre = fila.Cells[2].Value.ToString();
                oDetalle.PrecioUnitario = Convert.ToInt32(fila.Cells[3].Value);
                oFactura.AgregarDetalle(oDetalle);
            }
            if (oServicioFactura.CrearFacturaConDetalle(oFactura))
            {
                MessageBox.Show("Se creo la Factura numero " + oFactura.NroFactura);
            }
            else
                MessageBox.Show("Error al crear la factura.");
            this.Close();



        }

        private void LimpiarCampos()
        {
            txtIdProducto.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtTotalProducto.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtTotalFactura.Text = String.Empty;
            cboCliente.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            cboTipoFactura.SelectedIndex = -1;

        }

        private void LimpiarGrilla()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarGrilla();
            cboTipoFactura.Focus();
            ModoCargaFactura();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmABMCClientes fcb = new frmABMCClientes();
            fcb.ShowDialog();
            fcb.Dispose();
            CargarComboCliente(cboCliente, oC.traerTodosC());
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                //int doc = Convert.ToInt32(cboCliente.SelectedValue); 
                //CargarCamposCliente(doc);
            }
        }

        public void ModoCargaCliente()
        {
            gpbProducto.Enabled = false;
            gpbCliente.Enabled = true;
            gpbFactura.Enabled = false;
        }

        public void ModoCargaDetalles()
        {
            gpbProducto.Enabled = true;
            gpbCliente.Enabled = false;
            gpbFactura.Enabled = false;
        }

        public void ModoCargaFactura()
        {
            gpbProducto.Enabled = false;
            gpbCliente.Enabled = false;
            gpbFactura.Enabled = true;
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaPago.SelectedIndex != -1 && cboTipoFactura.SelectedIndex != -1)
            {
                ModoCargaCliente();
            }
        }

        private void btnFijarCliente_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                ModoCargaDetalles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente!!!!");
            }
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void calcularTotalProducto()
        {
            double x, y;
            int numero;
            if (Int32.TryParse(txtCantidad.Text, out numero))
            {
                x = Convert.ToDouble(txtCantidad.Text);
                y = Convert.ToDouble(txtPrecio.Text);
                txtTotalProducto.Text = Math.Round((x * y), 2).ToString();
            }
            else
                MessageBox.Show("Debe ingresar una cantidad numérica...");
        }
        private bool validarCamposProducto()
        {
            if(txtDescripcion.Text == string.Empty)
            {
                return false;
            }
            if (txtCantidad.Text == string.Empty) 
            { 
                return false; 
            }
            if (txtIdProducto.Text == string.Empty)
            {
                return false;
            }
            if (txtCantidad.Text == "0")
            {
                return false;
            }
                
            return true;
        }

        private void cboTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaPago.SelectedIndex != -1 && cboTipoFactura.SelectedIndex != -1)
            {
                ModoCargaCliente();
            }
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                //int doc = int.Parse(cboCliente.SelectedItem.ToString());
                int doc = int.Parse(cboCliente.GetItemText(cboCliente.SelectedItem));
                CargarCamposCliente(doc);
            }
        }
    }
}
