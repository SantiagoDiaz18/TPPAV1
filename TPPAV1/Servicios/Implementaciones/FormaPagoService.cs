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
    class FormaPagoService : IFormaPagoService
    {
        private IFormaPago dao;

        public FormaPagoService()
        {
            dao = new FormaPagoDao();
        }

        public List<FormaPago> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
