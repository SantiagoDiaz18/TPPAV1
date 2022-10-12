using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Datos.Interfaces
{
    interface IBarrio
    {
        List<Barrio> RecuperarTodos();

        List<Barrio> RecuperarPorId(int id);
        int Actualizar(Barrio oBarrio);
        int Eliminar(int id);
        int Crear(Barrio oBarrio);
    }
}
