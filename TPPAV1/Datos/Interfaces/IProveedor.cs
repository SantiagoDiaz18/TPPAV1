using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Datos.Interfaces
{
    interface IProveedor
    {
        List<Proveedor> RecuperarTodos();
        List<Proveedor> RecuperarPorId(int idProveedor);

        int CrearP(Proveedor idProveedor);
        int ActualizarP(Proveedor idProveedor);
        int EliminarP(int idProveedor);
        DataTable RecuperarFiltrados(string loc, string bar, int cant, int vig, string desde, string hasta);
    }
}
