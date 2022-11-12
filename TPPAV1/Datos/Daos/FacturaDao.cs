using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;

namespace TPPav1.Datos.Daos
{
    internal class FacturaDao : IFactura
    {
        public bool CrearFacturaConDetalles(Factura oFactura)
        {
           
            
                bool aux = false;
            //Insertar Bug
            string consultaFactura = "Insert into Facturas (tipoFactura, fechaEmision" +
                                ",idFormaPago, total, tipoDocCl, nroDocCl) "
                            + "Values (" + oFactura.TipoFactura.Id + ",'"
                                       + oFactura.FechaEmision.ToString("yyyy/MM/dd") + "',"
                                       + oFactura.FormaPago.IdFormaPago + ","
                                       + oFactura.Total + ","
                                       + oFactura.Cliente.TipoDoc.IdTipoD + ","
                                       + oFactura.Cliente.NroDoc + ")";
                                           
                BDHelper.ObtenerInstancia().ConectarConTransaccion();
                BDHelper.ObtenerInstancia().EjecutarSQLConTransaccion(consultaFactura);

                //Recuperar id nuevo
                var nuevoId = BDHelper.ObtenerInstancia().ConsultaSQLScalar("SELECT Max(nroFactura) from Facturas");
                oFactura.NroFactura = Convert.ToInt32(nuevoId);

            //Insertar Historial con nuevo id

            foreach (DetalleFactura detalle in oFactura.Detalles)
            {
                string consultaDetalle = "Insert into DetalleFactura (tipoFactura, nroFactura" +
                                           ",idProducto, precioUnitario, cantidad) "
                                           + "Values (" + oFactura.TipoFactura.Id + "," +
                                           + oFactura.NroFactura + ","
                                           + detalle.IdProducto.IdProducto + ","
                                           + detalle.PrecioUnitario + ","
                                           + detalle.Cantidad + ")";
                BDHelper.ObtenerInstancia().EjecutarSQLConTransaccion(consultaDetalle);

                string consultaStock = "Update Productos " +
                                       "set stock = stock - " +  detalle.Cantidad +
                                       "where idProducto = " + detalle.IdProducto.IdProducto;
                BDHelper.ObtenerInstancia().EjecutarSQLConTransaccion(consultaStock);
            }

            

        aux = BDHelper.ObtenerInstancia().Desconectar();
        return aux;
            
        }

        public DataTable RecuperarPorFecha(string desde, string hasta)
        {
            string consultaSQL = "SELECT c.nroDoc, c.tipoDoc, c.nombre, c.apellido, p.idProducto, sum(d.precioUnitario * d.cantidad) as total " +
                                "FROM Facturas f join Clientes c on (f.tipoDocCl = c.tipoDoc and f.nroDocCl = c.nroDoc) join DetalleFactura d " +
                                "on (f.tipoFactura = d.tipoFactura) join Productos p on (d.idProducto = p.idProducto)" +
                                "WHERE f.fechaEmision >= cast('" + desde + "' as date) and f.fechaEmision <= cast('" + hasta + "' as date) " +
                                " GROUP BY c.nombre, c.nroDoc, c.tipoDoc, c.apellido, p.idProducto";

            return BDHelper.ObtenerInstancia().Consultar(consultaSQL);
        }

        public DataTable RecuperarPorFechaYProducto(string desde, string hasta, string idProducto)
        {
            string consultaSQL = "SELECT c.nroDoc, c.tipoDoc, c.nombre, c.apellido, p.idProducto, sum(d.precioUnitario * d.cantidad) as total " +
                                "FROM Facturas f join Clientes c on (f.tipoDocCl = c.tipoDoc and f.nroDocCl = c.nroDoc) join DetalleFactura d " +
                                "on (f.tipoFactura = d.tipoFactura) join Productos p on (d.idProducto = p.idProducto)" +
                                "WHERE f.fechaEmision >= cast('" + desde + "' as date) and f.fechaEmision <= cast('" + hasta + "' as date) " +
                                "and p.idProducto = " + idProducto + 
                                " GROUP BY c.nombre, c.nroDoc, c.tipoDoc, c.apellido, p.idProducto";


            return BDHelper.ObtenerInstancia().Consultar(consultaSQL);
        }
    }
}
