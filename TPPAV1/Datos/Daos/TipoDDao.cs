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
    class TipoDDao : ITipoD
    {
        public List<TipoDocumento> RecuperarTodosD()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();

            string consulta = "Select * from TipoDocumento order by 2";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                TipoDocumento oTipoD = new TipoDocumento();

                oTipoD.IdTipoD = (int)fila["idTipo"];
                oTipoD.Descripcion = fila["descripcion"].ToString();

                lista.Add(oTipoD);

            }

            return lista;

        }
    }
}
