
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;

namespace TPPav1.Datos.Daos
{
    class UsuarioDao : IUsuario
    {
        public int ValidarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" + nombre + "' AND contraseña='" + clave + "'";

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 order by usuario";

            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public DataTable RecuperarPorId(int idUsuario)
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 AND idUsuario = " + idUsuario;

            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public int Crear(Usuario oUsuario)
        {
            
            string consulta1 = "SELECT * FROM Usuarios WHERE borrado = 0 AND usuario = '" + oUsuario.NombreUsuario + "'";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta1);
            if (tabla.Rows.Count == 0)
            {
                string consulta = "INSERT INTO Usuarios (usuario, contraseña, mail, borrado) " +
                                 "VALUES ('" +
                                 oUsuario.NombreUsuario + "','" +
                                 oUsuario.Password + "','" +
                                 oUsuario.Mail + "','" +
                                 oUsuario.Borrado + "')";
                return BDHelper.ObtenerInstancia().Actualizar(consulta);

            }
            else
                return 0;
        }

        public int Actualizar(Usuario oUsuario)
        {
            string consulta = "UPDATE Usuarios SET usuario='" + oUsuario.NombreUsuario + "'," +
                              "contraseña='" + oUsuario.Password + "'," +
                              "mail='" + oUsuario.Mail + "' " +
                              "WHERE idUsuario=" + oUsuario.Id_usuario;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public int Eliminar(int idUsuario)
        {
            string consulta = "DELETE FROM Usuarios WHERE idUsuario=" + idUsuario;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }
    }
}
