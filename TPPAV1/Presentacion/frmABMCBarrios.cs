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
    public partial class frmABMCBarrios : Form
    {
        public frmABMCBarrios()
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


        BarrioService oBarrio = new BarrioService();
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
            dgvBarrio.Enabled = !b;
            txtId.Enabled = !b;
            txtNombre.Enabled = b;
            cboLocalidad.Enabled = b;

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
            dgvBarrio.Enabled = b;
            txtId.Enabled = b;
            txtNombre.Enabled = !b;
            cboLocalidad.Enabled = !b;

        }

        private void LimpiarCampos()
        {
            txtId.Text = String.Empty;
            txtNombre.Text = String.Empty;
            cboLocalidad.SelectedIndex = -1;

        }

        private void LimpiarGrilla()
        {
            dgvBarrio.DataSource = null;
            dgvBarrio.Rows.Clear();
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar nombre del barrio...");
                txtNombre.Focus();
                return false;
            }
            if (cboLocalidad.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la localidad...");
                cboLocalidad.Focus();
                return false;
            }

            return true; ;
        }

        private void frmABMCBarrios_Load(object sender, EventArgs e)
        {
            Accion = Acciones.Modificacion;
            ModoConsulta(true);
            CargarComboLocalidad(cboLocalidad, oLocalidad.traerTodos());
            
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
            if (MessageBox.Show("Está seguro de eliminar este barrio?"
                               , "ELIMINANDO"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Warning
                               , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Delete 
                if (oBarrio.eliminarBarrio((int)dgvBarrio.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El barrio se eliminó con éxito!!!");
                    CargarGrilla(dgvBarrio, oBarrio.traerTodosB());
                    
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
                Barrio b = new Barrio();
                b.NombreBarrio = txtNombre.Text;
                b.Localidad = (Localidad)cboLocalidad.SelectedItem;
                

                if (Accion == Acciones.Alta)
                {
                    //insert

                  //  b.Borrado = false;
                    if (oBarrio.insertarBarrio(b) > 0)
                        MessageBox.Show("El barrio se creó con éxito!!!");
                    else
                        MessageBox.Show("Ese nombre de barrio ya existe.");
                }
                else
                {
                    //update
                    b.IdBarrio = int.Parse(txtId.Text);
                    if (oBarrio.actualizarBarrio(b) > 0)
                        MessageBox.Show("El barrio se actualizó con éxito!!!");
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

        private void CargarComboLocalidad(ComboBox combo, List<Localidad> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "IdLocalidad";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrilla(DataGridView grilla, List<Barrio> lista)
        {
            //grilla.AutoGenerateColumns = true;
            //grilla.DataSource = lista;
            //grilla.Focus();

            grilla.Rows.Clear();
            foreach (Barrio fila in lista)
            {
                grilla.Rows.Add(fila.IdBarrio, fila.NombreBarrio, fila.Localidad.NombreLocalidad);
            }
            grilla.Focus();
        }

        private void CargarCampos(int idBarrio)
        {

            
            List<Barrio> lista= oBarrio.traerPorId(idBarrio);
            

                foreach (Barrio barrio in lista)
                {
                    txtId.Text = barrio.IdBarrio.ToString();
                    txtNombre.Text = barrio.NombreBarrio;
                    cboLocalidad.SelectedValue = barrio.Localidad.IdLocalidad;

                }

        }

        private void dgvBarrio_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)dgvBarrio.CurrentRow.Cells[0].Value);
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
                CargarGrilla(dgvBarrio, oBarrio.traerPorId(Convert.ToInt32(txtId.Text)));
        }

        private void cbMostrarTodos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbMostrarTodos.Checked)
            {
                ModoEdicion(false);
                CargarGrilla(dgvBarrio, oBarrio.traerTodosB());
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
