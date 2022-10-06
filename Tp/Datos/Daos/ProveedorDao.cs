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
    class ProveedorDao : IProveedor
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Proveedores order by razonSocial DESC";
            //string consulta = "select c.razonSocial, c.telefono, c.nombre, c.apellido, b.nombreBarrio from Proveedores c join Barrios b on (c.idBarrio = b.idBarrio) order by razonSocial DESC";
            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public DataTable RecuperarPorId(int idProveedor)
        {
            string consulta = "SELECT * FROM Proveedores WHERE idProveedor = " + idProveedor;
            //string consulta = "select c.razonSocial, c.telefono, c.nombre, c.apellido, b.nombreBarrio from Proveedores c join Barrios b on (c.idBarrio = b.idBarrio) where razonSocial = " + idProveedor;

            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public int CrearP(Proveedor oProveedor)
        {
            string consulta = "insert into Proveedores (razonSocial, telefono, nombre, apellido, idBarrio) " +
                "values ('" +
                oProveedor.RazonSocial + "'," +
                oProveedor.Telefono + ",'" +
                oProveedor.Nombre + "','" +
                oProveedor.Apellido + "'," +
                oProveedor.IdBarrio.IdBarrio + ")";

            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }
        public int ActualizarP(Proveedor oProveedor)
        {
            string consulta = "update Proveedores set razonSocial='" + oProveedor.RazonSocial + "'," +
                "telefono=" + oProveedor.Telefono + "," +
                "nombre='" + oProveedor.Nombre + "'," +
                "apellido='" + oProveedor.Apellido + "'," +
                "idBarrio=" + oProveedor.IdBarrio.IdBarrio + " " +
                "where idProveedor=" + oProveedor.IdProveedor;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);


        }

        public int EliminarP(int id)
        {
            string consulta = "delete from Proveedores where idProveedor=" + id;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }
    }
}
