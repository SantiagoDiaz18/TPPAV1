using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Servicios.Interfaces
{
    internal interface ILocalidadService
    {
        List<Localidad> traerTodos();

        List<Localidad> traerPorId(int id);

        int eliminarLocalidad(int id);

        int actualizarLocalidad(Localidad oLocalidad);

        int insertarLocalidad(Localidad oLocalidad);
    }
}
