using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Daos;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Servicios.Implementaciones
{
    class ProductoService : IProductoService
    {
        private IProducto dao;

        public ProductoService()
        {
            dao = new ProductoDao();
        }

        public List<Producto> traerTodosP()
        {
            return dao.RecuperarTodosP();
        }

        public DataTable traerTodosReporte()
        {
            return dao.RecuperarParaReporteTodos();
        }

        public List<Producto> traerPorIdP(int nroDoc)
        {
            return dao.RecuperarPorIdP(nroDoc);
        }

        public int insertarProducto(Producto oProducto)
        {
            return dao.CrearP(oProducto);
        }

        public int actualizarProducto(Producto oProducto)
        {
            return dao.ActualizarP(oProducto);
        }

        public int eliminarProducto(int id)
        {
            return dao.EliminarP(id);
        }

        public DataTable RecuperarVendidos(string v1, string v2, string v3, string v4)
        {
            return dao.RecuperarVendidos(v1, v2, v3, v4);
        }
    }
}
