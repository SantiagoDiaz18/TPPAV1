using TPPav1.Servicios;
using System;
using System.Data;
using System.Windows.Forms;
using TPPav1.Entidades;


namespace TPPav1.Presentacion
{
    public partial class frmABMCUsuarios : Form
    {
        enum Acciones
        {
            Alta,
            Baja,
            Modificacion
        }
        Acciones Accion;

        UsuarioServicio oUsuario = new UsuarioServicio();
        public frmABMCUsuarios()
        {
            InitializeComponent();
        }

        private void ModoEdicion(bool b)
        {
            btnBorrar.Enabled = !b;
            btnCancelar.Enabled = b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
            btnSalir.Enabled = !b;
            btnBuscar.Enabled = !b;
            dgvUsuario.Enabled = !b;
            txtId.Enabled = !b;
            txtUsuario.Enabled = b;
            txtPassword.Enabled = b;
            txtEmail.Enabled = b;

        }

        private void ModoConsulta(bool b)
        {
            btnBorrar.Enabled = !b;
            btnBuscar.Enabled = b;
            btnCancelar.Enabled = !b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = !b;
            btnNuevo.Enabled = b;
            btnSalir.Enabled = b;
            dgvUsuario.Enabled = b;
            txtId.Enabled = b;
            txtUsuario.Enabled = !b;
            txtPassword.Enabled = !b;
            txtEmail.Enabled = !b;
        }


        private void LimpiarCampos()
        {
            txtId.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;

        }

        private void LimpiarGrilla()
        {
            dgvUsuario.Rows.Clear();
        }
        private void frmABMCUsuarios_Load(object sender, EventArgs e)
        {
            Accion = Acciones.Modificacion;
            ModoConsulta(true);
            //CargarGrilla(dgvUsuario, oUsuario.traerTodos());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Accion = Acciones.Alta;
            ModoEdicion(true);
            LimpiarCampos();
            txtUsuario.Focus();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este usuario?"
                               , "ELIMINANDO"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Warning
                               , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Delete 
                if (oUsuario.eliminarUsuario((int)dgvUsuario.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El usuario se eliminó con éxito!!!");
                    CargarGrilla(dgvUsuario, oUsuario.traerTodos());
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Accion = Acciones.Modificacion;
            ModoEdicion(true);
            txtUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //Crear y Cargar objeto
                Usuario u = new Usuario();
                u.NombreUsuario = txtUsuario.Text;
                u.Password = txtPassword.Text;
                u.Mail = txtEmail.Text;

                if (Accion == Acciones.Alta)
                {
                    //insert

                    u.Borrado = false;
                    if (oUsuario.insertarUsuario(u) > 0)
                        MessageBox.Show("El usuario se creó con éxito!!!");
                    else
                        MessageBox.Show("Ese nombre de usuario ya existe.");
                }
                else
                {
                    //update
                    u.Id_usuario = int.Parse(txtId.Text);
                    if (oUsuario.actualizarUsuario(u) > 0)
                        MessageBox.Show("El usuario se actualizó con éxito!!!");
                }
                LimpiarCampos();

            }


            ModoConsulta(true);
        }



        private bool ValidarDatos()
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar nombre de usuario...");
                txtUsuario.Focus();
                return false;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar password...");
                txtPassword.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar E-mail...");
                txtEmail.Focus();
                return false;
            }

            return true; ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            LimpiarCampos();
            Accion = Acciones.Modificacion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idUsuario"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["mail"]);
            }
            grilla.Focus();
        }


        private void CargarCampos(int idUsuario)
        {


            DataTable tabla = oUsuario.traerPorId(idUsuario);
            if (tabla.Rows.Count > 0)
            {
                txtId.Text = tabla.Rows[0]["idUsuario"].ToString();
                txtUsuario.Text = tabla.Rows[0]["usuario"].ToString();
                txtPassword.Text = tabla.Rows[0]["contraseña"].ToString();
                txtEmail.Text = tabla.Rows[0]["mail"].ToString();
            }
        }

        private void dgvUsuario_SelectionChanged_1(object sender, EventArgs e)
        {
            CargarCampos((int)dgvUsuario.CurrentRow.Cells[0].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ModoEdicion(false);
            if (txtId.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Id");
                txtId.Focus();
            }
            else
                CargarGrilla(dgvUsuario, oUsuario.traerPorId(Convert.ToInt32(txtId.Text)));

        }

        private void cbMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbMostrarTodos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbMostrarTodos.Checked)
            {
                ModoEdicion(false);
                CargarGrilla(dgvUsuario, oUsuario.traerTodos());
            }
            else
            {
                ModoConsulta(true);
                LimpiarGrilla();
                LimpiarCampos();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
