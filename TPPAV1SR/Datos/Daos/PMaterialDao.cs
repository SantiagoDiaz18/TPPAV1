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
    class PMaterialDao : IPMaterial
    {
        public List<ProductoMaterial> RecuperarTodosPrM()
        {
            List<ProductoMaterial> lista = new List<ProductoMaterial>();
            string consulta = "SELECT * FROM ProductoMaterial order by 2";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                ProductoMaterial oMaterial = new ProductoMaterial();
                oMaterial.IdMaterial = (int)fila["idMaterial"];
                oMaterial.Descripcion = fila["descripcion"].ToString();

                lista.Add(oMaterial);
            }

            return lista;
        }
    }
}
