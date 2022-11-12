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
    class ProveedorService : IProveedorService
    {
        private IProveedor dao;

        public ProveedorService()
        {
            dao = new ProveedorDao();
        }

        public List<Proveedor> traerTodosP()
        {
            return dao.RecuperarTodos();
        }

        public List<Proveedor> traerPorIdP(int idProveedor)
        {
            return dao.RecuperarPorId(idProveedor);
        }

        public int insertarProveedor(Proveedor oProveedor)
        {
            return dao.CrearP(oProveedor);
        }

        public int actualizarProveedor(Proveedor oProveedor)
        {
            return dao.ActualizarP(oProveedor);
        }

        public int eliminarProveedor(int idProveedor)
        {
            return dao.EliminarP(idProveedor);
        }

        public DataTable TraerFiltrados(string loc, string bar, int cant, int vig, string desde, string hasta)
        {
            return dao.RecuperarFiltrados(loc, bar, cant, vig, desde, hasta);
        }
    }
}
