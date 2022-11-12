using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Daos;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Servicios.Implementaciones
{
    internal class LocalidadService : ILocalidadService
    {
        private ILocalidad dao;

        public LocalidadService()
        {
            dao = new LocalidadDao();
        }
        public int actualizarLocalidad(Localidad oLocalidad)
        {
            return dao.Actualizar(oLocalidad);
        }

        public int eliminarLocalidad(int id)
        {
            return dao.Eliminar(id);
        }

        public int insertarLocalidad(Localidad oLocalidad)
        {
            return dao.Crear(oLocalidad);
        }

        public List<Localidad> traerPorId(int id)
        {
            return dao.RecuperarPorId(id);
        }

        public List<Localidad> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
