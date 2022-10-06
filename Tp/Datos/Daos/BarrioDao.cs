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
    class BarrioDao : IBarrio
    {

        public int Actualizar(Barrio oBarrio)
        {
            string consulta = "UPDATE Barrios SET nombreBarrio='" + oBarrio.NombreBarrio + "'," +
                              "idLocalidad='" + oBarrio.IdLocalidad.ToString() + "' " +
                              "WHERE idBarrio='" + oBarrio.IdBarrio.ToString() + "'";
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public int Crear(Barrio oBarrio)
        {
            string consulta1 = "SELECT * FROM Barrios WHERE borrado = 0 AND nombreBarrio = '" + oBarrio.NombreBarrio + "'";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta1);
            if (tabla.Rows.Count == 0)
            {
                string consulta = "INSERT INTO Barrios (nombreBarrio, idLocalidad, borrado) " +
                                 "VALUES ('" +
                                 oBarrio.NombreBarrio + "','" +
                                 oBarrio.IdLocalidad + "', 0)";
                                   
                               
                return BDHelper.ObtenerInstancia().Actualizar(consulta);

            }
            else
                return 0;
        }

        public int Eliminar(int id)
        {
            string consulta = "UPDATE Barrios SET borrado=1 WHERE idBarrio=" + id.ToString();
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public List<Barrio> RecuperarPorId(int id)
        {
            Barrio oBarrio = new Barrio();
            List<Barrio> lista = new List<Barrio>();
            string consulta = "Select idBarrio, nombreBarrio, idLocalidad from Barrios WHERE borrado = 0 and idBarrio=" + id.ToString();
            //string consulta = "Select * from Barrios WHERE borrado=0 AND idBarrio=" + id.ToString();
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {

                oBarrio.IdBarrio = (int)tabla.Rows[0]["idBarrio"];
                oBarrio.NombreBarrio = tabla.Rows[0]["nombreBarrio"].ToString();
                oBarrio.IdLocalidad = (int)tabla.Rows[0]["idLocalidad"];
                lista.Add(oBarrio);
            }
            return lista;

        }

        public List<Barrio> RecuperarTodos()
        {
            List<Barrio> list = new List<Barrio>();
            string consulta = "Select idBarrio, nombreBarrio, idLocalidad from Barrios WHERE borrado = 0";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Barrio oBarrio = new Barrio();

                oBarrio.IdBarrio = (int)fila["idBarrio"];
                oBarrio.NombreBarrio = fila["nombreBarrio"].ToString();
                oBarrio.IdLocalidad = (int)fila["idLocalidad"];

                list.Add(oBarrio);
            }

            return list;
        }
        //public List<Barrio> RecuperarTodosB()
        //{
        //    List<Barrio> list = new List<Barrio>();
        //    string consulta = "Select * from Barrios";
        //    DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

        //    foreach (DataRow fila in tabla.Rows)
        //    {
        //        Barrio oBarrio = new Barrio();

        //        oBarrio.IdBarrio = (int)fila["idBarrio"];
        //        oBarrio.NombreBarrio = fila["nombreBarrio"].ToString();
        //        oBarrio.IdLocalidad = (int)fila["idLocalidad"];

        //        list.Add(oBarrio);
        //    }

        //    return list;
        //}

    }
}
