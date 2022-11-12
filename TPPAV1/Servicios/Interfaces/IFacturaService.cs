using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Servicios.Interfaces
{
    internal interface IFacturaService
    {
        bool CrearFacturaConDetalle(Factura oFactura);

        DataTable RecuperarPorFecha(string desde, string hasta);
        DataTable RecuperarPorFechaYProducto(string desde, string hasta, string idProducto);
    }
}
