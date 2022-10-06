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
    public partial class frmABMCProveedores : Form
    {
        enum Acciones
        {
            Alta,
            Baja,
            Modificacion
        }

        Acciones MiAccion;
        ProveedorService oProveedor = new ProveedorService();
        BarrioService oBarrio = new BarrioService();

        public frmABMCProveedores()
        {
            InitializeComponent();
        }

        private void ModoEdicion(bool b)
        {
            btnEliminarP.Enabled = !b;
            btnCancelarP.Enabled = b;
            btnEditarP.Enabled = !b;
            btnGuardarP.Enabled = b;
            btnAgregarP.Enabled = !b;
            btnSalirP.Enabled = !b;
            btnBuscar.Enabled = !b;
            gdrProveedores.Enabled = !b; 
            txtId.Enabled = !b;
            txtRazon.Enabled = b;
            txtContacto.Enabled = b;
            txtNombre.Enabled = b;
            txtApellido.Enabled = b;
            cboBarrio.Enabled = b;

        }

        private void ModoConsulta(bool b)
        {
            btnEliminarP.Enabled = !b;
            btnCancelarP.Enabled = !b;
            btnEditarP.Enabled = !b;
            btnGuardarP.Enabled = !b;
            btnAgregarP.Enabled = b;
            btnSalirP.Enabled = b;
            btnBuscar.Enabled = b;
            gdrProveedores.Enabled = b;
            txtId.Enabled = b;
            txtRazon.Enabled = !b;
            txtContacto.Enabled = !b;
            txtNombre.Enabled = !b;
            txtApellido.Enabled = !b;
            cboBarrio.Enabled = !b;
        }

        private void gdrProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            ModoEdicion(true);
            LimpiarCampos();
            txtRazon.Focus();
        }

        private void LimpiarCampos()
        {
            txtId.Text = String.Empty;
            txtRazon.Text = String.Empty;
            txtContacto.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            cboBarrio.SelectedIndex = -1;
        }

        private void LimpiarGrilla()
        {
            gdrProveedores.Rows.Clear();
        }
        
        private void frmABMCProveedores_Load(object sender, EventArgs e)
        {
            //LimpiarCampos();

            CargarComboBarrio(cboBarrio, oBarrio.traerTodosB());

            ModoConsulta(true);

            MiAccion = Acciones.Modificacion;

        }

        private void CargarComboBarrio(ComboBox combo, List<Barrio> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreBarrio";
            combo.ValueMember = "IdBarrio";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idProveedor"],
                    tabla.Rows[i]["razonSocial"],
                    tabla.Rows[i]["telefono"],
                    tabla.Rows[i]["nombre"],
                    tabla.Rows[i]["apellido"],
                    tabla.Rows[i]["idBarrio"]);
            }

            grilla.Focus();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este Proveedor?"
                               , "ELIMINANDO"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Warning
                               , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                if (oProveedor.eliminarProveedor((int)gdrProveedores.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El Proveedor se eliminó con éxito!!!");
                    CargarGrilla(gdrProveedores, oProveedor.traerTodosP());
                }
            }
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            ModoEdicion(true);
            this.txtRazon.Enabled = true;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Proveedor u = new Proveedor();
                u.RazonSocial = txtRazon.Text;
                u.Nombre = txtNombre.Text;
                u.Apellido = txtApellido.Text;
                u.Telefono = int.Parse(txtContacto.Text);
                u.IdBarrio = (Barrio)cboBarrio.SelectedItem;


                if (MiAccion == Acciones.Alta)
                {


                    if (oProveedor.insertarProveedor(u) > 0)
                        MessageBox.Show("El proveedor se creó con éxito!!!");

                    //else
                    //    MessageBox.Show("Ese nombre de cliente ya existe.");
                }
                else
                {
                    //update
                    u.IdProveedor = int.Parse(txtId.Text);
                    if (oProveedor.actualizarProveedor(u) > 0)
                        MessageBox.Show("El proveedor se actualizó con éxito!!!");

                }
                LimpiarCampos();
                //LimpiarGrilla();


            }

            ModoConsulta(true);
        }

        private bool ValidarDatos()
        {
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar Domicilio...");
                cboBarrio.Focus();
                return false;
            }
            if (txtRazon.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Razon Social...");
                txtRazon.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Apellido...");
                txtApellido.Focus();
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Nombre...");
                txtNombre.Focus();

                return false;
            }

            if (txtContacto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Telefono...");
                txtContacto.Focus();
                return false;
            }

            return true; ;
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            LimpiarCampos();
            MiAccion = Acciones.Modificacion;
        }

        private void btnSalirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos(int idProveedor)
        {


            DataTable tabla = oProveedor.traerPorIdP(idProveedor);
            if (tabla.Rows.Count > 0)
            {
                txtId.Text = tabla.Rows[0]["idProveedor"].ToString();
                txtRazon.Text = tabla.Rows[0]["razonSocial"].ToString();
                txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
                txtApellido.Text = tabla.Rows[0]["apellido"].ToString();
                txtContacto.Text = tabla.Rows[0]["telefono"].ToString();
                cboBarrio.SelectedValue = tabla.Rows[0]["idBarrio"];
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            if (txtId.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Numero");
                txtId.Focus();
                ModoConsulta(true);
            }
            else
                CargarGrilla(gdrProveedores, oProveedor.traerPorIdP(Convert.ToInt32(txtId.Text)));
        }

        private void cbMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarTodos.Checked)
            {
                ModoEdicion(false);
                CargarGrilla(gdrProveedores, oProveedor.traerTodosP());
            }
            else
            {
                ModoConsulta(true);
                LimpiarGrilla();
                LimpiarCampos();
            }
        }

        private void gdrProveedores_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)gdrProveedores.CurrentRow.Cells[0].Value);
        }
    }
}
