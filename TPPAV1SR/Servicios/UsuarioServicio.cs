
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Daos;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;

namespace TPPav1.Servicios
{
    class UsuarioServicio
    {
        private IUsuario dao;

        public UsuarioServicio()
        {
            dao = new UsuarioDao();
        }
        public int encontrarUsuario(string nombre, string clave)
        {
            return dao.ValidarUsuario(nombre, clave);
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable traerPorId(int idUsuario)
        {
            return dao.RecuperarPorId(idUsuario);
        }

        public int insertarUsuario(Usuario oUsuario)
        {
            return dao.Crear(oUsuario);
        }

        public int actualizarUsuario(Usuario oUsuario)
        {
            return dao.Actualizar(oUsuario);
        }

        internal int eliminarUsuario(int idUsuario)
        {
            return dao.Eliminar(idUsuario);
        }
    }
}
