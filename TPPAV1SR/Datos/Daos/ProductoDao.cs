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
                oProducto.PeriodoGarantia + "'," +
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
                "periodoGarantia='" + oProducto.PeriodoGarantia + "'," +
                "idProveedor=" + oProducto.IdProveedor + " " +
                "where idProducto=" + oProducto.IdProducto;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);

        }

        public int EliminarP(int id)
        {
            string consulta = "delete from Productos where idProducto=" + id;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }


    }
}
