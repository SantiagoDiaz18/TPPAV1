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
    class FormaPagoDao : IFormaPago
    {
        public List<FormaPago> RecuperarTodos()
        {
            List<FormaPago> list = new List<FormaPago>();
            string consulta = "select * from FormasPago order by 2";

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                FormaPago oFP = new FormaPago();
                oFP.IdFormaPago = (int)fila["idFormaPago"];
                oFP.Descripcion = fila["descripcion"].ToString();

                list.Add(oFP);
            }

            return list;
        }
    }
}
