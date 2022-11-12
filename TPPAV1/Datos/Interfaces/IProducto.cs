using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Datos.Interfaces
{
    interface IProducto
    {
        List<Producto> RecuperarTodosP();
        DataTable RecuperarParaReporteTodos();
        List<Producto> RecuperarPorIdP(int id);

        int CrearP(Producto oProducto);
        int ActualizarP(Producto oProducto);

        int EliminarP(int id);
        DataTable RecuperarVendidos(string v1, string v2, string v3, string v4);
    }
}
