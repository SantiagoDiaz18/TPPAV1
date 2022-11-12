using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPav1.Presentacion
{
    public partial class frmABMCTipoProductos : Form
    {
        enum Acciones
        {
            Alta,
            Baja,
            Modificacion
        }
        Acciones Accion;
        public frmABMCTipoProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModoEdicion(bool b)
        {
            btnEliminarTP.Enabled = !b;
            btnCancelarTP.Enabled = b;
            btnEditarTP.Enabled = !b;
            btnGuardarTP.Enabled = b;
            btnAgregarTP.Enabled = !b;
            btnSalirTP.Enabled = !b;
            btnBuscarTP.Enabled = !b;
            gdrTipoP.Enabled = !b;
            txtIdTP.Enabled = !b;
            txtNombre.Enabled = b;
            txtColor.Enabled = b;
            txtMaterial.Enabled = b;
            txtCosto.Enabled = b;
            txtPeso.Enabled = b;
            txtLargo.Enabled = b;
            txtAncho.Enabled = b;
            txtAlto.Enabled = b;
            txtCantidad.Enabled = b;
            txtPeriodo.Enabled = b;

        }

        private void ModoConsulta(bool b)
        {
            btnEliminarTP.Enabled = !b;
            btnCancelarTP.Enabled = !b;
            btnEditarTP.Enabled = !b;
            btnGuardarTP.Enabled = !b;
            btnAgregarTP.Enabled = b;
            btnSalirTP.Enabled = b;
            btnBuscarTP.Enabled = b;
            gdrTipoP.Enabled = b;
            txtIdTP.Enabled = b;
            txtNombre.Enabled = !b;
            txtColor.Enabled = !b;
            txtMaterial.Enabled = !b;
            txtCosto.Enabled = !b;
            txtPeso.Enabled = !b;
            txtLargo.Enabled = !b;
            txtAncho.Enabled = !b;
            txtAlto.Enabled = !b;
            txtCantidad.Enabled = !b;
            txtPeriodo.Enabled = !b;
        }

        private void LimpiarCampos()
        {
            txtIdTP.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtColor.Text = String.Empty;
            txtMaterial.Text = String.Empty;
            txtCosto.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtLargo.Text = String.Empty;
            txtAncho.Text = String.Empty;
            txtAlto.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtPeriodo.Text = String.Empty;

        }

        private void frmABMCTipoProductos_Load(object sender, EventArgs e)
        {


        }
    }
}
