using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TPPav1.Datos;
using TPPav1.Entidades;
using TPPav1.Reportes;
using TPPav1.Servicios.Implementaciones;

namespace TPPav1.Presentacion
{
    public partial class frmReporteProductos : Form
    {
        ProductoService oProducto = new ProductoService();
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //List<Producto> list = new List<Producto>();
            //list = oProducto.traerTodosReporte();

            DataTable tabla = new DataTable();
            tabla = oProducto.traerTodosReporte();

            ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

            //string consulta = @"select p.idProducto ,p.precio, c.descripcion as color, p.stock from Productos p inner join ProductoColor c on p.idColor = c.idColor";

            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosProductos", BDHelper.ObtenerInstancia().Consultar(consulta)));
            //reportViewer1.RefreshReport();
        }
    }
}
