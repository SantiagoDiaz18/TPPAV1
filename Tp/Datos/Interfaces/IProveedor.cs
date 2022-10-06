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
        DataTable RecuperarTodos();
        DataTable RecuperarPorId(int idProveedor);

        int CrearP(Proveedor idProveedor);
        int ActualizarP(Proveedor idProveedor);
        int EliminarP(int idProveedor);
    }
}
