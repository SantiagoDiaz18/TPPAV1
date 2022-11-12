using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Servicios.Interfaces
{
    internal interface IClienteService
    {
        List<Cliente> traerTodosC();
        List<Cliente> traerPorIdC(int nroDoc);

        int insertarCliente(Cliente oCliente);

        int actualizarCliente(Cliente oCliente);

        int eliminarCliente(int nroDoc);
    }
}
