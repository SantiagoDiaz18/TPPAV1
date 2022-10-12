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
    public partial class frmABMCLocalidades : Form
    {
        public frmABMCLocalidades()
        {
            InitializeComponent();
        }

        enum Acciones
        {
            Alta,
            Modificacion,
            Baja,
        }

        Acciones Accion;


        LocalidadService oLocalidad = new LocalidadService();

        private void ModoEdicion(bool b)
        {
            btnEliminar.Enabled = !b;
            btnCancelar.Enabled = b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
            btnSalir.Enabled = !b;
            btnBuscar.Enabled = !b;
            dgvLocalidad.Enabled = !b;
            txtId.Enabled = !b;
            txtNombre.Enabled = b;
            

        }

        private void ModoConsulta(bool b)
        {
            btnEliminar.Enabled = !b;
            btnBuscar.Enabled = b;
            btnCancelar.Enabled = !b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = !b;
            btnNuevo.Enabled = b;
            btnSalir.Enabled = b;
            dgvLocalidad.Enabled = b;
            txtId.Enabled = b;
            txtNombre.Enabled = !b;
          

        }

        private void LimpiarCampos()
        {
            txtId.Text = String.Empty;
            txtNombre.Text = String.Empty;
           

        }

        private void LimpiarGrilla()
        {
            dgvLocalidad.DataSource = null;
            dgvLocalidad.Rows.Clear();
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar nombre de la localidad...");
                txtNombre.Focus();
                return false;
            }

            return true; ;
        }
        private void frmABMCLocalidades_Load(object sender, EventArgs e)
        {
            Accion = Acciones.Modificacion;
            ModoConsulta(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Accion = Acciones.Alta;
            ModoEdicion(true);
            LimpiarGrilla();
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Accion = Acciones.Modificacion;
            ModoEdicion(true);
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar esta localidad?"
                              , "ELIMINANDO"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Warning
                              , MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                //Delete 
                if (oLocalidad.eliminarLocalidad((int)dgvLocalidad.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("La localidad se eliminó con éxito!!!");
                    CargarGrilla(dgvLocalidad, oLocalidad.traerTodos());

                    //LimpiarGrilla();
                    //LimpiarCampos();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //Crear y Cargar objeto
                Localidad l = new Localidad();
                l.NombreLocalidad = txtNombre.Text;



                if (Accion == Acciones.Alta)
                {
                    //insert

                    l.Borrado = false;
                    if (oLocalidad.insertarLocalidad(l) > 0)
                        MessageBox.Show("La localidad se creó con éxito!!!");
                    else
                        MessageBox.Show("Ese nombre de localidad ya existe.");
                }
                else
                {
                    //update
                    l.IdLocalidad = int.Parse(txtId.Text);
                    if (oLocalidad.actualizarLocalidad(l) > 0)
                        MessageBox.Show("la localidad se actualizó con éxito!!!");
                }
                LimpiarCampos();

            }


            ModoConsulta(true);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
            if (txtId.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Id");
                txtId.Focus();
            }
            else
                CargarGrilla(dgvLocalidad, oLocalidad.traerPorId(Convert.ToInt32(txtId.Text)));
        }

        private void CargarGrilla(DataGridView grilla, List<Localidad> lista)
        {
            grilla.AutoGenerateColumns = true;
            grilla.DataSource = lista;
            grilla.Focus();
        }

        private void CargarCampos(int idLocalidad)
        {


            List<Localidad> lista = oLocalidad.traerPorId(idLocalidad);


            foreach (Localidad localidad in lista)
            {
                txtId.Text = localidad.IdLocalidad.ToString();
                txtNombre.Text = localidad.NombreLocalidad;
            }

        }

        
        private void dgvLocalidad_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)dgvLocalidad.CurrentRow.Cells[0].Value);
        }

        private void cbMostrarTodos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbMostrarTodos.Checked)
            {
                ModoEdicion(false);
                CargarGrilla(dgvLocalidad, oLocalidad.traerTodos());
            }
            else
            {
                ModoConsulta(true);
                LimpiarGrilla();
                LimpiarCampos();
            }
        }
    }
}
