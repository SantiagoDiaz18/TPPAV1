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
        public DataTable RecuperarTodosP()
        {
            string consulta = "select * from Productos";
            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public DataTable RecuperarPorIdP(int id)
        {
            string consulta = "select * from Productos where idProducto = " + id;
            return BDHelper.ObtenerInstancia().Consultar(consulta);
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
                oProducto.Stock + "," +
                oProducto.PeriodoGarantia + "," +
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
                "periodoGarantia=" + oProducto.PeriodoGarantia + "," +
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
