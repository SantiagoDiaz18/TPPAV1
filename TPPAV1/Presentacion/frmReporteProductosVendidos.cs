using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPav1.Servicios.Implementaciones;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Presentacion
{
    public partial class frmReporteProductosVendidos : Form
    {
        IProductoService oProducto;
        public frmReporteProductosVendidos()
        {
            InitializeComponent();
            oProducto = new ProductoService();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {

            this.rpvProductosVendidos.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha desde debe ser menor a la fecha hasta", "FECHA ERRONEA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rpvProductosVendidos.LocalReport.DataSources.Clear();
                rpvProductosVendidos.LocalReport.DataSources.Add(new ReportDataSource("DatosProductosVendidos", oProducto.RecuperarVendidos(dtpDesde.Value.ToString("dd/MM/yyyy"), dtpHasta.Value.ToString("dd/MM/yyyy"), nudCantidad.Value.ToString(), nudTotal.Value.ToString())));
                this.rpvProductosVendidos.RefreshReport();
            }
        }
    }
}
