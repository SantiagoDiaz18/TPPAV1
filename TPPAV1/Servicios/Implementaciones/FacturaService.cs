using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;
using TPPav1.Servicios.Interfaces;
using TPPav1.Datos.Interfaces;
using TPPav1.Datos.Daos;
using System.Data;

namespace TPPav1.Servicios.Implementaciones
{
    internal class FacturaService : IFacturaService
    {
        private IFactura dao;
        public FacturaService()
        {
            dao = new FacturaDao();
        }
        public bool CrearFacturaConDetalle(Factura oFactura)
        {
            return dao.CrearFacturaConDetalles(oFactura);
        }
        public DataTable RecuperarPorFecha(string desde, string hasta)
        {
            return dao.RecuperarPorFecha(desde, hasta);
        }

        public DataTable RecuperarPorFechaYProducto(string desde, string hasta, string idProducto)
        {
            return dao.RecuperarPorFechaYProducto(desde, hasta, idProducto);
        }
    }
}
