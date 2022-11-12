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
    class SexoDao : ISexo
    {
        public List<TipoSexo> RecuperarTodosS()
        {
            List<TipoSexo> list = new List<TipoSexo>();
            string consulta = "select * from TipoSexo order by 2";

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                TipoSexo oSexo = new TipoSexo();
                oSexo.IdSexo = (int)fila["idSexo"];
                oSexo.DescripcionS = fila["descripcionS"].ToString();

                list.Add(oSexo);
            }

            return list;
        }

    }
}
