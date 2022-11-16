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
    class ProductoDao : IProducto
    {
        public List<Producto> RecuperarTodosP()
        {
            List<Producto> lista = new List<Producto>();
            string consulta = @"select p.*, c.descripcion 'color', m.descripcion 'material', tp.nombre 'tipoProducto' 
                        from productos p join ProductoColor c on p.idColor = c.idColor
                        join ProductoMaterial m on p.idMaterial = m.idMaterial
                        join TipoProductos tp on p.idTipo = tp.idTipo";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = new Producto();

                oProducto.IdProducto = (int)fila["idProducto"];
                oProducto.Precio = (int)fila["precio"];
                oProducto.Costo = (int)fila["costo"];
                oProducto.IdColor.IdColor = (int)fila["idColor"];
                oProducto.IdColor.Descripcion = fila["color"].ToString();
                oProducto.IdMaterial.IdMaterial = (int)fila["idMaterial"];
                oProducto.IdMaterial.Descripcion = fila["material"].ToString();
                oProducto.Peso = (int)fila["peso"];
                oProducto.Largo = (int)fila["largo"];
                oProducto.Ancho = (int)fila["ancho"];
                oProducto.Alto = (int)fila["alto"];
                oProducto.Stock = (int)fila["stock"];
                oProducto.PeriodoGarantia = (DateTime)fila["periodoGarantia"];
                oProducto.IdTipo.IdTipo = (int)fila["idTipo"];
                oProducto.IdTipo.Nombre = fila["tipoProducto"].ToString();
                lista.Add(oProducto);
            }

            return lista;
        }

        public DataTable RecuperarParaReporteTodos()
        {
            //string consulta = @"select p.idProducto, p.precio, p.idColor, p.stock from Productos p";
            string consulta = @"select p.idProducto,tp.nombre ,p.precio, c.descripcion as color, p.stock, m.descripcion as material from Productos p inner join ProductoColor c on p.idColor = c.idColor inner join tipoProductos tp on (p.idTipo=tp.idTipo) inner join ProductoMaterial m on (p.idMaterial = m.idMaterial)";
            return BDHelper.ObtenerInstancia().Consultar(consulta);
            //List<Producto> lista = new List<Producto>();
            //string consulta = @"select p.idProducto, p.precio, p.idColor, p.stock from Productos p";
            //DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            //foreach (DataRow fila in tabla.Rows)
            //{
            //    Producto oProducto = new Producto();

            //    oProducto.IdProducto = (int)fila["idProducto"];
            //    oProducto.Precio = (int)fila["precio"];
            //    //oProducto.Costo = (int)fila["costo"];
            //    oProducto.IdColor.IdColor = (int)fila["idColor"];
            //    //oProducto.IdColor.Descripcion = fila["color"].ToString();
            //    //oProducto.IdMaterial.IdMaterial = (int)fila["idMaterial"];
            //    //oProducto.IdMaterial.Descripcion = fila["material"].ToString();
            //    //oProducto.Peso = (int)fila["peso"];
            //    //oProducto.Largo = (int)fila["largo"];
            //    //oProducto.Ancho = (int)fila["ancho"];
            //    //oProducto.Alto = (int)fila["alto"];
            //    oProducto.Stock = (int)fila["stock"];
            //    //oProducto.PeriodoGarantia = (DateTime)fila["periodoGarantia"];
            //    //oProducto.IdTipo.IdTipo = (int)fila["idTipo"];
            //    //oProducto.IdTipo.Nombre = fila["tipoProducto"].ToString();
            //    lista.Add(oProducto);
            //}

            //return lista;
        }

        public List<Producto> RecuperarPorIdP(int id)
        {
            List<Producto> lista = new List<Producto>();
            string consulta = @"select p.*, c.descripcion 'color', m.descripcion 'material', tp.nombre 'tipoProducto' 
                        from productos p join ProductoColor c on p.idColor = c.idColor
                        join ProductoMaterial m on p.idMaterial = m.idMaterial
                        join TipoProductos tp on p.idTipo = tp.idTipo " +
                        "where p.idProducto = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = new Producto();

                oProducto.IdProducto = (int)fila["idProducto"];
                oProducto.Precio = (int)fila["precio"];
                oProducto.Costo = (int)fila["costo"];
                oProducto.IdColor.IdColor = (int)fila["idColor"];
                oProducto.IdColor.Descripcion = fila["color"].ToString();
                oProducto.IdMaterial.IdMaterial = (int)fila["idMaterial"];
                oProducto.IdMaterial.Descripcion = fila["material"].ToString();
                oProducto.Peso = (int)fila["peso"];
                oProducto.Largo = (int)fila["largo"];
                oProducto.Ancho = (int)fila["ancho"];
                oProducto.Alto = (int)fila["alto"];
                oProducto.Stock = (int)fila["stock"];
                oProducto.PeriodoGarantia = (DateTime)fila["periodoGarantia"];
                oProducto.IdTipo.IdTipo = (int)fila["idTipo"];
                oProducto.IdTipo.Nombre = fila["tipoProducto"].ToString();
                lista.Add(oProducto);
            }

            return lista;
        }

        public int CrearP(Producto oProducto)
        {
            string consulta = "insert into Productos (precio, costo, idColor, idMaterial, peso, largo, ancho, alto, stock, periodoGarantia, idProveedor, idTipo) " +
                "values (" +
                //oProducto.IdProducto + "," +
                oProducto.Precio + "," +
                oProducto.Costo + "," +
                oProducto.IdColor.IdColor+ "," +
                oProducto.IdMaterial.IdMaterial + "," +
                oProducto.Peso + "," +
                oProducto.Largo + "," +
                oProducto.Ancho + "," +
                oProducto.Alto + "," +
                oProducto.Stock + ",'" +
                oProducto.PeriodoGarantia.ToString("yyyy/MM/dd") + "'," +
                oProducto.IdProveedor + "," +
                oProducto.IdTipo.IdTipo + ")";

            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public int ActualizarP(Producto oProducto)
        {
            string consulta = "update Productos set idTipo='" + oProducto.IdTipo.IdTipo + "'," +
                "precio=" + oProducto.Precio + "," +
                "costo=" + oProducto.Costo + "," +
                "idColor=" + oProducto.IdColor.IdColor + "," +
                "idMaterial=" + oProducto.IdMaterial.IdMaterial + "," +
                "peso=" + oProducto.Peso + "," +
                "largo=" + oProducto.Largo + "," +
                "ancho=" + oProducto.Ancho + "," +
                "alto=" + oProducto.Alto + "," +
                "stock=" + oProducto.Stock + "," +
                "periodoGarantia='" + oProducto.PeriodoGarantia.ToString("yyyy/MM/dd") + "'," +
                "idProveedor=" + oProducto.IdProveedor + " " +
                "where idProducto=" + oProducto.IdProducto;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);

        }

        public int EliminarP(int id)
        {
            string consulta = "delete from Productos where idProducto=" + id;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public DataTable RecuperarVendidos(string desde, string hasta, string cantidad, string total)
        {
            string consultaSQL = "SELECT DF.idProducto, TP.nombre, sum(df.cantidad) 'CantidadVendida', sum(df.cantidad * df.precioUnitario) 'TotalFacturado' " +
                "FROM Productos P join DetalleFactura DF on P.idProducto = DF.idProducto " +
                "                 join Facturas F on F.nroFactura = Df.nroFactura and F.tipoFactura = DF.tipoFactura " +
                "                 join TipoProductos TP on P.idTipo = TP.idTipo " +
                "WHERE F.fechaEmision Between cast('" + desde + "' as date) and cast('" + hasta + "' as date) " +
                "GROUP BY DF.idProducto, TP.nombre " +
                "HAVING sum(df.cantidad) >= cast(" + cantidad + " as int) and sum(df.cantidad * df.precioUnitario) >= cast(" + total + " as int) " +
                "ORDER BY 4 desc";

            return BDHelper.ObtenerInstancia().Consultar(consultaSQL);
        }
    }
}
