using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Servicios.Interfaces
{
    internal interface IProductoService
    {
        List<Producto> traerTodosP();
        List<Producto> traerPorIdP(int id);

        int insertarProducto(Producto oProducto);

        int actualizarProducto(Producto oProducto);

        int eliminarProducto(int id);
    }
}
