using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;

namespace TPPav1.Datos.Daos
{
    class PColorDao : IPColor
    {
        public List<ProductoColor> RecuperarTodosPrC()
        {
            List<ProductoColor> lista = new List<ProductoColor>();
            string consulta = "SELECT * FROM ProductoColor order by 2";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                ProductoColor oColor = new ProductoColor();
                oColor.IdColor = (int)fila["idColor"];
                oColor.Descripcion = fila["descripcion"].ToString();
                
                lista.Add(oColor);
            }

            return lista;
        }
    }
}
