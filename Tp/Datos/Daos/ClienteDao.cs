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
        public DataTable RecuperarTodosC()
        {
            string consulta = "select c.nroDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, s.descripcionS, b.nombreBarrio, c.telefono from Clientes c join TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo) join Barrios b on (c.idBarrio = b.idBarrio) order by apellido";
            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public DataTable RecuperarPorIdC(int nroDoc)
        {
            string consulta = "select c.nroDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, s.descripcionS, b.nombreBarrio, c.telefono from Clientes c join TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo) join Barrios b on (c.idBarrio = b.idBarrio) where nroDoc = " + nroDoc;
            return BDHelper.ObtenerInstancia().Consultar(consulta);
        }

        public int CrearC(Cliente oCliente)
        {
            string consulta = "insert into Clientes (nroDoc, tipoDoc, apellido, nombre, fechaNacimiento, idSexo, idBarrio, telefono) " +
                "values (" +
                oCliente.NroDoc + "," +
                oCliente.TipoDoc.IdTipoD + ",'" +
                oCliente.Apellido + "','" +
                oCliente.Nombre + "','" +
                oCliente.FechaNacimiento + "'," +
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
