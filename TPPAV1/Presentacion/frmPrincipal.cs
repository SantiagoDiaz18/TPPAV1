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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
        }

        private void administarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCUsuarios fcb = new frmABMCUsuarios();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCClientes fcb = new frmABMCClientes();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void administrarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCCompras fcb = new frmABMCCompras();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCProveedores fcb = new frmABMCProveedores();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void administrarBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmABMCBarrios fcb = new frmABMCBarrios();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCLocalidades fcb = new frmABMCLocalidades();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCProductos fcb = new frmABMCProductos();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void administrarBarriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void altaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaFactura fcb = new frmAltaFactura();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmReporteProductos fcb = new frmReporteProductos();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProveedoresPorBarrio fcb = new frmReporteProveedoresPorBarrio();
            fcb.ShowDialog();
            fcb.Dispose();
        }

        private void clientesConMasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClienteConMasCompras fcc = new frmReporteClienteConMasCompras();
            fcc.ShowDialog();
            fcc.Dispose();
        }

        private void productosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProductosVendidos fpv = new frmReporteProductosVendidos();
            fpv.ShowDialog();
            fpv?.Dispose();
        }
    }
}
