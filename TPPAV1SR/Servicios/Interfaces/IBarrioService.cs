using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Servicios.Interfaces
{
    internal interface IBarrioService
    {
        List<Barrio> traerTodosB();

        List<Barrio> traerPorId(int id);

        int eliminarBarrio(int id);

        int actualizarBarrio(Barrio oBarrio);

        int insertarBarrio(Barrio oBarrio);
    }
}
