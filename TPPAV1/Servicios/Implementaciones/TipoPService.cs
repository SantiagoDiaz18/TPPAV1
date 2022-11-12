using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Daos;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Servicios.Implementaciones
{
    class TipoPService : ITipoPService
    {
        private ITipoP dao;

        public TipoPService()
        {
            dao = new TipoPDao();
        }

        public List<TipoProducto> traerTodosTP()
        {
            return dao.RecuperarTodosTP();
        }
    }
}
