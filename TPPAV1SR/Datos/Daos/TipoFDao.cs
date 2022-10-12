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
    class TipoFDao : ITipoF
    {
        public List<TipoFactura> RecuperarTodos()
        {
            List<TipoFactura> lista = new List<TipoFactura>();

            string consulta = "Select * from TipoFactura order by 2";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                TipoFactura oTipoF = new TipoFactura();

                oTipoF.Id = (int)fila["id"];
                oTipoF.Descripcion = fila["descripcion"].ToString();

                lista.Add(oTipoF);

            }

            return lista;

        }
    }
}
