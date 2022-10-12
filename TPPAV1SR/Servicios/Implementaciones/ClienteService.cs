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
    class ClienteService :IClienteService
    {
        private ICliente dao;

        public ClienteService()
        {
            dao = new ClienteDao();
        }

        public List<Cliente> traerTodosC()
        {
            return dao.RecuperarTodosC();
        }

        public List<Cliente> traerPorIdC(int nroDoc)
        {
            return dao.RecuperarPorIdC(nroDoc);
        }

        public int insertarCliente(Cliente oCliente)
        {
            return dao.CrearC(oCliente);
        }

        public int actualizarCliente(Cliente oCliente)
        {
            return dao.ActualizarC(oCliente);
        }

        public int eliminarCliente(int nroDoc)
        {
            return dao.EliminarC(nroDoc);
        }



    }


}
