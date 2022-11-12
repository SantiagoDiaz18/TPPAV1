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
    public partial class frmABMCClientes : Form
    {
        enum Acciones
        {
            Alta,
            Baja,
            Modificacion
        }

        Acciones MiAccion;
        SexoService oSexo = new SexoService();
        TipoDService oTipo = new TipoDService();
        ClienteService oCliente = new ClienteService();
        BarrioService oBarrio = new BarrioService();
        public frmABMCClientes()
        {
            InitializeComponent();
        }

        private void ModoEdicion(bool b)
        {
            btnEliminarC.Enabled = !b;
            btnCancelarC.Enabled = b;
            btnEditarC.Enabled = !b;
            btnGuardarC.Enabled = b;
            btnAgregarC.Enabled = !b;
            btnSalirC.Enabled = !b;
            btnBuscar.Enabled = !b;
            gdrClientes.Enabled = !b;
            txtNumero.Enabled = b;
            cboTipo.Enabled = b;
            txtApellido.Enabled = b;
            txtNombreC.Enabled = b;
            dtpFecha.Enabled = b;
            cboSexo.Enabled = b;
            cboBarrio.Enabled = b;
            txtTelefono.Enabled = b;

        }

        private void ModoConsulta(bool b)
        {
            btnEliminarC.Enabled = !b;
            btnCancelarC.Enabled = !b;
            btnEditarC.Enabled = !b;
            btnGuardarC.Enabled = !b;
            btnAgregarC.Enabled = b;
            btnSalirC.Enabled = b;
            btnBuscar.Enabled = b;
            gdrClientes.Enabled = b;
            txtNumero.Enabled = b;
            cboTipo.Enabled = !b;
            txtApellido.Enabled = !b;
            txtNombreC.Enabled = !b;
            dtpFecha.Enabled = !b;
            cboSexo.Enabled = !b;
            cboBarrio.Enabled = !b;
            txtTelefono.Enabled = !b;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            ModoEdicion(true);
            LimpiarCampos();
            txtNumero.Focus();
           
        }

        private void LimpiarCampos()
        {
            txtNumero.Text = String.Empty;
            cboTipo.SelectedIndex = -1;
            txtApellido.Text = String.Empty;
            txtNombreC.Text = String.Empty;
            dtpFecha.Text = String.Empty;
            cboSexo.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
            txtTelefono.Text = String.Empty;
            
        }

        private void LimpiarGrilla()
        {
            gdrClientes.Rows.Clear();
        }

        private void frmABMCClientes_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            CargarComboSexo(cboSexo, oSexo.traerTodosS());
            CargarComboTipoD(cboTipo, oTipo.traerTodosD());
            CargarComboBarrio(cboBarrio, oBarrio.traerTodosB());
            
            ModoConsulta(true);
            
            MiAccion = Acciones.Modificacion;


        }

        private void CargarComboSexo(ComboBox combo, List<TipoSexo> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "DescripcionS";
            combo.ValueMember = "IdSexo";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboTipoD(ComboBox combo, List<TipoDocumento> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "IdTipoD";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboBarrio(ComboBox combo, List<Barrio> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreBarrio";
            combo.ValueMember = "IdBarrio";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrilla(DataGridView grilla, List<Cliente> lista)
        //{
        //    grilla.Rows.Clear();
        //    for (int i = 0; i < tabla.Rows.Count; i++)
        //    {
        //        grilla.Rows.Add(tabla.Rows[i]["nroDoc"],
        //            tabla.Rows[i]["tipoDoc"],
        //            tabla.Rows[i]["apellido"],
        //            tabla.Rows[i]["nombre"],
        //            tabla.Rows[i]["fechaNacimiento"],
        //            tabla.Rows[i]["idSexo"],
        //            tabla.Rows[i]["idBarrio"],
        //            //tabla.Rows[i]["descripcionS"],
        //            //tabla.Rows[i]["nombreBarrio"],
        //            tabla.Rows[i]["telefono"]);
        //    }

        //    grilla.Focus();
        //}
        {
            //grilla.AutoGenerateColumns = true;
            //grilla.DataSource = lista;
            grilla.Rows.Clear();
            foreach (Cliente fila in lista)
            {
                grilla.Rows.Add(fila.NroDoc,fila.TipoDoc.Descripcion,fila.Apellido,fila.Nombre,fila.FechaNacimiento
                    ,fila.IdSexo.DescripcionS,fila.IdBarrio.NombreBarrio,fila.Telefono);
            }
            grilla.Focus();
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este cliente?"
                               , "ELIMINANDO"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Warning
                               , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Delete 
                if (oCliente.eliminarCliente((int)gdrClientes.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El usuario se eliminó con éxito!!!");
                    CargarGrilla(gdrClientes, oCliente.traerTodosC());
                }
            }
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            ModoEdicion(true);
            this.txtNumero.Enabled = false;
            
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //Crear y Cargar objeto
                Cliente u = new Cliente();
                u.NroDoc = int.Parse(txtNumero.Text);
                u.TipoDoc = (TipoDocumento)cboTipo.SelectedItem;
                u.Apellido = txtApellido.Text;
                u.Nombre = txtNombreC.Text;
                u.FechaNacimiento = dtpFecha.Value;
                u.IdSexo = (TipoSexo)cboSexo.SelectedItem;
                u.IdBarrio = (Barrio)cboBarrio.SelectedItem;
                u.Telefono = int.Parse(txtTelefono.Text);

                if (MiAccion == Acciones.Alta)
                {
                    //insert

                    
                    if (oCliente.insertarCliente(u) > 0)
                        MessageBox.Show("El cliente se creó con éxito!!!");

                    //else
                    //    MessageBox.Show("Ese nombre de cliente ya existe.");
                }
                else
                {
                    //update
                    //u.NroDoc = int.Parse(txtNumero.Text);
                    if (oCliente.actualizarCliente(u) > 0)
                        MessageBox.Show("El usuario se actualizó con éxito!!!");
            
                }
                LimpiarCampos();
                LimpiarGrilla();
                

            }

            //CargarGrilla(gdrClientes, oCliente.traerTodosC());
            ModoConsulta(true);
        }

        private bool ValidarDatos()
        {
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar tipo de documento...");
                cboTipo.Focus();
                return false;
            }
            if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Numero de Documento...");
                txtNumero.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Apellido...");
                txtApellido.Focus();
                return false;
            }

            if (txtNombreC.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Nombre...");
                txtNombreC.Focus();
                
                return false;
            }
            //if (mkdFechaN.Text == string.Empty)
            //{
            //    MessageBox.Show("Debe ingresar Apellido...");
            //    mkdFechaN.Focus();
            //    return false;
            //}

            if (cboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar Tipo de sexo...");
                cboSexo.Focus();
                return false;
            }

            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar Barrio...");
                cboBarrio.Focus();
                return false;
            }

            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Apellido...");
                txtTelefono.Focus();
                return false;
            }

            return true; ;
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            LimpiarCampos();
            MiAccion = Acciones.Modificacion;
        }

        private void btnSalirC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos(int idCliente)
        {


            //DataTable tabla = oCliente.traerPorIdC(idUsuario);
            //if (tabla.Rows.Count > 0)
            //{

            //    txtNumero.Text = tabla.Rows[0]["nroDoc"].ToString();
            //    cboTipo.SelectedValue = tabla.Rows[0]["tipoDoc"];
            //    txtApellido.Text = tabla.Rows[0]["apellido"].ToString();
            //    txtNombreC.Text = tabla.Rows[0]["nombre"].ToString();
            //    dtpFecha.Text = tabla.Rows[0]["fechaNacimiento"].ToString();
            //    cboSexo.SelectedValue = tabla.Rows[0]["idSexo"];
            //    cboBarrio.SelectedValue = tabla.Rows[0]["idBarrio"];
            //    txtTelefono.Text = tabla.Rows[0]["telefono"].ToString();
            //}
            List<Cliente> lista = oCliente.traerPorIdC(idCliente);


            foreach (Cliente cliente in lista)
            {
                txtNumero.Text = cliente.NroDoc.ToString();
                cboTipo.SelectedValue = cliente.TipoDoc.IdTipoD;
                txtNombreC.Text = cliente.Nombre.ToString();
                txtApellido.Text = cliente.Apellido;
                txtTelefono.Text = cliente.Telefono.ToString();
                dtpFecha.Text = cliente.FechaNacimiento.ToString();
                cboBarrio.SelectedValue = cliente.IdBarrio.IdBarrio;
                cboSexo.SelectedValue = cliente.IdSexo.IdSexo;
                

            }
        }

        private void gdrClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdrClientes_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)gdrClientes.CurrentRow.Cells[0].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            if (txtNumero.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Numero");
                txtNumero.Focus();
                ModoConsulta(true);
            }
            else
                CargarGrilla(gdrClientes, oCliente.traerPorIdC(Convert.ToInt32(txtNumero.Text)));
        }

        private void cbMostrarTodos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbMostrarTodos.Checked)
            {
                ModoEdicion(false);
                CargarGrilla(gdrClientes, oCliente.traerTodosC());
            }
            else
            {
                ModoConsulta(true);
                LimpiarGrilla();
                LimpiarCampos();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
