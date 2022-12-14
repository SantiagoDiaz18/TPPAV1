using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Datos.Interfaces
{
    interface ICliente
    {
        List<Cliente> RecuperarTodosC();
        List<Cliente> RecuperarPorIdC(int nroDoc);

        int CrearC(Cliente oCliente);
        int ActualizarC(Cliente oCliente);

        int EliminarC(int nroDoc);
    }
}
