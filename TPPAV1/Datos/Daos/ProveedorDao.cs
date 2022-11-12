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
        public List<Proveedor> RecuperarTodos()
        {
            List<Proveedor> lista = new List<Proveedor>();
            string consulta = "SELECT p.*, nombreBarrio FROM Proveedores p join barrios b on p.idbarrio = b.idbarrio order by razonSocial DESC";
            //string consulta = "select c.razonSocial, c.telefono, c.nombre, c.apellido, b.nombreBarrio from Proveedores c join Barrios b on (c.idBarrio = b.idBarrio) order by razonSocial DESC";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Proveedor oProveedor = new Proveedor();
                
                oProveedor.IdProveedor = (int)fila["idProveedor"];
                oProveedor.RazonSocial = fila["razonSocial"].ToString();
                oProveedor.Nombre = fila["nombre"].ToString();
                oProveedor.Apellido = fila["apellido"].ToString();
                oProveedor.Telefono = (int)fila["telefono"];
                oProveedor.IdBarrio.IdBarrio = (int)fila["idBarrio"];
                oProveedor.IdBarrio.NombreBarrio = fila["nombreBarrio"].ToString();
                lista.Add(oProveedor); ;
            }
            return lista;
        }

        public List<Proveedor> RecuperarPorId(int idProveedor)
        {
            
            List<Proveedor> lista = new List<Proveedor>();
            string consulta = "SELECT p.*, nombreBarrio FROM Proveedores p join barrios b on p.idbarrio = b.idbarrio WHERE idProveedor = " + idProveedor;
            //string consulta = "select c.razonSocial, c.telefono, c.nombre, c.apellido, b.nombreBarrio from Proveedores c join Barrios b on (c.idBarrio = b.idBarrio) where razonSocial = " + idProveedor;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                Proveedor oProveedor = new Proveedor();

                oProveedor.IdProveedor = (int)tabla.Rows[0]["idProveedor"];
                oProveedor.RazonSocial = tabla.Rows[0]["razonSocial"].ToString();
                oProveedor.Nombre = tabla.Rows[0]["nombre"].ToString();
                oProveedor.Apellido = tabla.Rows[0]["apellido"].ToString();
                oProveedor.Telefono = (int)tabla.Rows[0]["telefono"];
                oProveedor.IdBarrio.IdBarrio = (int)tabla.Rows[0]["idBarrio"];
                oProveedor.IdBarrio.NombreBarrio = tabla.Rows[0]["nombreBarrio"].ToString();
                lista.Add(oProveedor); ;
            }
            return lista;
        }

        public DataTable RecuperarFiltrados(string loc, string bar, int cant, int vig, string desde, string hasta)
        {
            string consultaSQL = "select l.nombreLocalidad as Localidad, b.nombreBarrio as Barrio, count(*) as Cantidad from Localidades l inner join Barrios b on (l.idLocalidad = b.idLocalidad) inner join Proveedores p on (p.idBarrio = b.idBarrio)";

            if (loc != string.Empty)
                consultaSQL += " where l.idLocalidad=" + loc;
            if (bar != string.Empty)
                consultaSQL += " and b.idBarrio=" + bar;

            if (vig != -1)
            {
                if (vig == 0)
                {
                    consultaSQL += " and p.vigencia=" + vig + " and p.fechaAlta > '" + desde +
                        "' and p.fechaBaja < '" + hasta + "'";
                }
                else
                {
                    consultaSQL += " and p.vigencia=" + vig + " and p.fechaAlta between '" + desde +
                        "' and '" + hasta + "'";
                }
            }
            else
            {
                consultaSQL += " and p.fechaAlta between '" + desde +
                        "' and '" + hasta + "'";
            }

            consultaSQL += " group by b.nombreBarrio, l.nombreLocalidad";

            if (cant != -1)
                if (cant == 0)
                {
                    consultaSQL += " order by count(*) asc";
                }
                else
                {
                    consultaSQL += " order by count(*) desc";
                }

            return BDHelper.ObtenerInstancia().Consultar(consultaSQL);
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
