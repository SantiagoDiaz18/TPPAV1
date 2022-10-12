using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Datos.Interfaces
{
    internal interface ILocalidad
    {
        List<Localidad> RecuperarTodos();

        List<Localidad> RecuperarPorId(int id);
        int Actualizar(Localidad oLocalidad);
        int Eliminar(int id);
        int Crear(Localidad oLocalidad);
    }
}
