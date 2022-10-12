using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;
using TPPav1.Servicios.Interfaces;
using TPPav1.Datos.Interfaces;
using TPPav1.Datos.Daos;

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
    }
}
