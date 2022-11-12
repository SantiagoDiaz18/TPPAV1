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
using TPPav1.Entidades;
using TPPav1.Servicios.Implementaciones;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Presentacion
{
    public partial class frmReporteClienteConMasCompras : Form
    {
        IFacturaService oFactura;
        IProductoService oProducto;
        bool auxTodos;
        public frmReporteClienteConMasCompras()
        {
            InitializeComponent();
            oFactura = new FacturaService();
            oProducto = new ProductoService();
            auxTodos = false;
            
        }

        private void frmReporteClienteConMasCompras_Load(object sender, EventArgs e)
        {
            cargarComboProducto(cboProductos, oProducto.traerTodosP());
            this.rpvClientesMasCompras.RefreshReport();
        }

        private void cargarComboProducto(ComboBox cbo, List<Producto> lista)
        {
            cbo.DataSource = lista;
            cbo.DisplayMember = "IdProducto";
            cbo.ValueMember = "IdProducto";
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                rpvClientesMasCompras.LocalReport.DataSources.Clear();

                if (auxTodos)
                {
                    rpvClientesMasCompras.LocalReport.DataSources.Add(new ReportDataSource("DatosClientesConMasCompras", oFactura.RecuperarPorFecha(dtpDesde.Value.ToString("dd/MM/yyyy"), dtpHasta.Value.ToString("dd/MM/yyyy"))));
                }
                else
                {
                    rpvClientesMasCompras.LocalReport.DataSources.Add(new ReportDataSource("DatosClientesConMasCompras", oFactura.RecuperarPorFechaYProducto(dtpDesde.Value.ToString("dd/MM/yyyy"), dtpHasta.Value.ToString("dd/MM/yyyy"), cboProductos.SelectedValue.ToString())));
                }
                this.rpvClientesMasCompras.RefreshReport();
            }
        }

        private bool ValidarCampos()
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha DESDE debe ser menor a la fecha HASTA", "FECHA ERRONEA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDesde.Focus();
                return false;
                
            }

            if( !cbTodosProductos.Checked && cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto o marcar todos para continuar", "No se seleccionó ningún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProductos.Focus();
                return false;
                
            }

            return true;
        }

        private void cbTodosProductos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbTodosProductos.Checked)
            {
                cboProductos.SelectedIndex = -1;
                cboProductos.Enabled = false;
                auxTodos = true;
            }
            else
            {
                cboProductos.Enabled = true;
                auxTodos = false;
            }
        }
    }
}
