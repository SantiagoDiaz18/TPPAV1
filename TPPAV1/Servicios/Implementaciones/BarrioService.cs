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
    class BarrioService : IBarrioService
    {
        private IBarrio dao;

        public BarrioService()
        {
            dao = new BarrioDao();
        }

        public int actualizarBarrio(Barrio oBarrio)
        {
            return dao.Actualizar(oBarrio);
        }

        public int eliminarBarrio(int id)
        {
            return dao.Eliminar(id);
        }

        public int insertarBarrio(Barrio oBarrio)
        {
            return dao.Crear(oBarrio);
        }

        public List<Barrio> traerPorId(int id)
        {
            return dao.RecuperarPorId(id);
        }

        public List<Barrio> traerTodosB()
        {
            return dao.RecuperarTodos();
        }

    }
}

