using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;


namespace TPPav1.Servicios.Interfaces
{
    internal interface IProveedorService
    {
        List<Proveedor> traerTodosP();
        List<Proveedor> traerPorIdP(int nroDoc);

        int insertarProveedor(Proveedor oProveedor);

        int actualizarProveedor(Proveedor oProveedor);

        int eliminarProveedor(int idProveedor);
        DataTable TraerFiltrados(string loc, string bar, int cant, int vig, string desde, string hasta);
    }
}
