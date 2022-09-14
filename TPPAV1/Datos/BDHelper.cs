using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TPPav1.Datos
{
    class BDHelper
    {
        private static BDHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;

        private BDHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = @"Data Source=DESKTOP-2GI3TRM\SQLEXPRESS;Initial Catalog=BDPav1TP;Integrated Security=True";

        }

        public static BDHelper ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new BDHelper();
            }
            return instancia;
        }

        public DataTable Consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;

        }
        public int Actualizar(string consultaSQL)
        {
            int filasAfectadas = 0;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
        }

    }
}
