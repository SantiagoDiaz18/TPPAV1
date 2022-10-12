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
    class ClienteDao : ICliente
    {
        //public DataTable RecuperarTodosC()
        //{
        //    string consulta = "select * from Clientes";
        //    //string consulta = "select c.nroDoc,c.tipoDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento,
        //    ,c.idSexo,s.descripcionS,c.idbarrio ,b.nombreBarrio, c.telefono from Clientes c join
        //    TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo)
        //    join Barrios b on (c.idBarrio = b.idBarrio) order by apellido";
        //    return BDHelper.ObtenerInstancia().Consultar(consulta);
        //}

        // public DataTable RecuperarPorIdC(int nroDoc)
        //{
        //string consulta = "select * from Clientes where nroDoc=" + nroDoc;
        //string consulta = "select c.nroDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, s.descripcionS, b.nombreBarrio, c.telefono from Clientes c join TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo) join Barrios b on (c.idBarrio = b.idBarrio) where nroDoc = " + nroDoc;
        //return BDHelper.ObtenerInstancia().Consultar(consulta);
        //        }

        //public DataTable RecuperarTodosCGrila()
        //{
        //    //string consulta = "select * from Clientes";
        //    string consulta = "select c.nroDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, s.descripcionS, b.nombreBarrio, c.telefono from Clientes c join TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo) join Barrios b on (c.idBarrio = b.idBarrio) order by apellido";
        //    return BDHelper.ObtenerInstancia().Consultar(consulta);
        //}

        //public DataTable RecuperarPorIdCGrilla(int nroDoc)
        //{
        //    //string consulta = "select * from Clientes where nroDoc=" + nroDoc;
        //    string consulta = "select c.nroDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, s.descripcionS, b.nombreBarrio, c.telefono from Clientes c join TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo) join Barrios b on (c.idBarrio = b.idBarrio) where nroDoc = " + nroDoc;
        //    return BDHelper.ObtenerInstancia().Consultar(consulta);
        //}
        public List<Cliente> RecuperarPorIdC(int id)
        {
            Cliente oCliente = new Cliente();
            List<Cliente> lista = new List<Cliente>();
            string consulta = "select c.nroDoc,c.tipoDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento," +
                "c.idSexo,s.descripcionS,c.idbarrio ,b.nombreBarrio, c.telefono from Clientes c join " +
            "TipoDocumento t on(c.tipoDoc= t.idTipo) join TipoSexo s on(c.idSexo = s.idSexo) " +
            "join Barrios b on(c.idBarrio = b.idBarrio) " +
                "WHERE nroDoc=" + id.ToString();
            //string consulta = "Select * from Barrios WHERE borrado=0 AND idBarrio=" + id.ToString();
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                    oCliente.NroDoc = (int)tabla.Rows[0]["nroDoc"];
                    oCliente.TipoDoc.IdTipoD = (int)tabla.Rows[0]["tipoDoc"];
                    oCliente.TipoDoc.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                    oCliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                    oCliente.Apellido = tabla.Rows[0]["apellido"].ToString();
                    oCliente.Telefono = (int)tabla.Rows[0]["telefono"];
                    oCliente.IdSexo.IdSexo = (int)tabla.Rows[0]["idSexo"];
                    oCliente.IdSexo.DescripcionS = tabla.Rows[0]["DescripcionS"].ToString();
                    oCliente.FechaNacimiento = (DateTime)tabla.Rows[0]["fechaNacimiento"];
                    oCliente.IdBarrio.IdBarrio = (int)tabla.Rows[0]["idBarrio"];
                    oCliente.IdBarrio.NombreBarrio = tabla.Rows[0]["nombreBarrio"].ToString();
                    lista.Add(oCliente); ;
            }
            return lista;

        }

        public List<Cliente> RecuperarTodosC()
        {
            List<Cliente> list = new List<Cliente>();
            string consulta = "select c.nroDoc,c.tipoDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, c.apellido + ', ' + c.nombre as 'nombreCompleto'," +
                "c.idSexo,s.descripcionS,c.idbarrio ,b.nombreBarrio, c.telefono from Clientes c join " +
            "TipoDocumento t on(c.tipoDoc= t.idTipo) join TipoSexo s on(c.idSexo = s.idSexo) " +
            "join Barrios b on(c.idBarrio = b.idBarrio) order by apellido";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Cliente oCliente = new Cliente();

                oCliente.NroDoc = (int)fila["nroDoc"];
                oCliente.TipoDoc.IdTipoD =(int)fila["tipoDoc"];
                oCliente.TipoDoc.Descripcion = fila["descripcion"].ToString();
                oCliente.Nombre = fila["nombre"].ToString();
                oCliente.Apellido = fila["apellido"].ToString();
                oCliente.Telefono = (int)fila["telefono"];
                oCliente.IdSexo.IdSexo = (int)fila["idSexo"];
                oCliente.IdSexo.DescripcionS = fila["DescripcionS"].ToString();
                oCliente.FechaNacimiento = (DateTime)fila["fechaNacimiento"];
                oCliente.IdBarrio.IdBarrio = (int)fila["idBarrio"];
                oCliente.IdBarrio.NombreBarrio = fila["nombreBarrio"].ToString();
                list.Add(oCliente);
            }

            return list;
        }
        public int CrearC(Cliente oCliente)
        {
            string consulta = "insert into Clientes (nroDoc, tipoDoc, apellido, nombre, fechaNacimiento, idSexo, idBarrio, telefono) " +
                "values (" +
                oCliente.NroDoc + "," +
                oCliente.TipoDoc.IdTipoD + ",'" +
                oCliente.Apellido + "','" +
                oCliente.Nombre + "','" +
                oCliente.FechaNacimiento.ToString("yyyy/MM/dd") + "'," +
                oCliente.IdSexo.IdSexo + "," +
                oCliente.IdBarrio.IdBarrio + "," +
                oCliente.Telefono + ")";

            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }

        public int ActualizarC(Cliente oCliente)
        {
            string consulta = "update Clientes set nombre='" + oCliente.Nombre + "'," +
                "tipoDoc=" + oCliente.TipoDoc.IdTipoD + "," +
                "apellido='" + oCliente.Apellido + "'," +
                //"nombre='" + oCliente.Nombre + "'," +
                "fechaNacimiento='" + oCliente.FechaNacimiento + "'," +
                "idSexo=" + oCliente.IdSexo.IdSexo + "," +
                "idBarrio=" + oCliente.IdBarrio.IdBarrio + "," +
                "telefono=" + oCliente.Telefono + " " +
                "where nroDoc=" + oCliente.NroDoc;
                //"and tipoDoc=" + oCliente.TipoDoc.IdTipoD;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        
                 
        }

        public int EliminarC(int nroDoc)
        {
            string consulta = "delete from Clientes where nroDoc=" + nroDoc;
            return BDHelper.ObtenerInstancia().Actualizar(consulta);
        }
    }
}
