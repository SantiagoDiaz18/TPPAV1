using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Entidades;

namespace TPPav1.Datos.Interfaces
{
    interface IPColor
    {
        List<ProductoColor> RecuperarTodosPrC();
    }
}
