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
using TPPav1.Servicios;
using TPPav1.Presentacion;

namespace TPPav1
{
    public partial class frmLogin : Form
    {

        private UsuarioServicio miGestor = new UsuarioServicio();
        private Usuario miUsuario = new Usuario();

        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario...");
                this.txtUsuario.Focus();
                return;
            }

            if (this.txtClave.Text==string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña...");
                this.txtClave.Focus();
                return;
            }

            this.miUsuario.NombreUsuario = this.txtUsuario.Text;
            this.miUsuario.Password = this.txtClave.Text;

            this.miUsuario.Id_usuario = this.miGestor.encontrarUsuario(miUsuario.NombreUsuario, miUsuario.Password);

            if (miUsuario.Id_usuario!=0)
            {
                MessageBox.Show("Login OK", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = String.Empty;
                this.txtUsuario.Focus();
            }
        }
    
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
         
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                btnIngresar.PerformClick();

            }
        }
    }
}
