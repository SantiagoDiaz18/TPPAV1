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
    internal class LocalidadDao : ILocalidad
    {
        public int Actualizar(Localidad oLocalidad)
        {
            string consulta = "UPDATE Localidades SET nombreLocalidad='" + oLocalidad.NombreLocalidad + "'" +                            
                              "WHERE idLocalidad='" + oLocalidad.IdLocalidad.ToString() + "'";
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public int Crear(Localidad oLocalidad)
        {
            string consulta1 = "SELECT * FROM Localidades WHERE borrado = 0 AND nombreLocalidad = '" + oLocalidad.NombreLocalidad + "'";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta1);
            if (tabla.Rows.Count == 0)
            {
                string consulta = "INSERT INTO Localidades (nombreLocalidad, borrado) " +
                                 "VALUES ('" +
                                 oLocalidad.NombreLocalidad + "','" +
                                 oLocalidad.Borrado + "')";
                return BDHelper.ObtenerInstancia().Actualizar(consulta);

            }
            else
                return 0;
        }

        public int Eliminar(int id)
        {
            string consulta = "UPDATE Localidades SET borrado=1 WHERE idLocalidad=" + id.ToString();
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public List<Localidad> RecuperarPorId(int id)
        {
            Localidad oLocalidad = new Localidad();
            List<Localidad> lista = new List<Localidad>();
            string consulta = "Select * from Localidades WHERE borrado=0 AND idLocalidad=" + id.ToString();
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {

                oLocalidad.IdLocalidad = (int)tabla.Rows[0]["idLocalidad"];
                oLocalidad.NombreLocalidad = tabla.Rows[0]["nombreLocalidad"].ToString();
                lista.Add(oLocalidad);
            }
            return lista;

        }

        public List<Localidad> RecuperarTodos()
        {
            List<Localidad> list = new List<Localidad>();
            string consulta = "Select * from Localidades WHERE borrado = 0";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Localidad oLocalidad = new Localidad();

                oLocalidad.IdLocalidad = (int)fila["idLocalidad"];
                oLocalidad.NombreLocalidad = fila["nombreLocalidad"].ToString();

                list.Add(oLocalidad);
            }

            return list;
        }
    }
}
