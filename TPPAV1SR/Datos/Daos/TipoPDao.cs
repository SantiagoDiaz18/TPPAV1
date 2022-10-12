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
    class TipoPDao : ITipoP
    {

        public List<TipoProducto> RecuperarTodosTP()
        {
            List<TipoProducto> lista = new List<TipoProducto>();

            string consulta = "Select * from TipoProductos order by 2";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                TipoProducto oTipoTP = new TipoProducto();

                oTipoTP.IdTipo = (int)fila["idTipo"];
                oTipoTP.Nombre = fila["nombre"].ToString();

                lista.Add(oTipoTP);

            }

            return lista;

        }

        //public DataTable RecuperarTodosTP()
        //{
        //    string consulta = "select * from TipoProductos";
        //    return BDHelper.ObtenerInstancia().Consultar(consulta);
        //}

        //public DataTable RecuperarPorIdTP(int idTP)
        //{
        //    //string consulta = "select c.nroDoc,t.descripcion, c.apellido, c.nombre, c.fechaNacimiento, s.descripcionS, b.nombreBarrio, c.telefono from Clientes c join TipoDocumento t on (c.tipoDoc=t.idTipo ) join TipoSexo s on (c.idSexo = s.idSexo) join Barrios b on (c.idBarrio = b.idBarrio) where nroDoc = " + nroDoc;
        //    string consulta = "select * from TipoProductos where idTipo = " + idTP;
        //    return BDHelper.ObtenerInstancia().Consultar(consulta);
        //}

        //public int CrearTP(TipoProducto oTipoP)
        //{
        //    string consulta = "insert into TipoProductos (idTipo, color, material, costo, peso, largo, ancho, alto, cant_stock, periodoGarantia, nombre) " +
        //        "values (" +
        //        oTipoP.IdTipo + ",'" +
        //        oTipoP.Color + "','" +
        //        oTipoP.Material + "'," +
        //        oTipoP.Costo + "," +
        //        oTipoP.Peso + "," +
        //        oTipoP.Largo + "," +
        //        oTipoP.Ancho + "," +
        //        oTipoP.Alto + "," +
        //        oTipoP.Cant_stock + "," +
        //        oTipoP.PeriodoGarantia + ",'" +
        //        oTipoP.Nombre + "')";

        //    return BDHelper.ObtenerInstancia().Actualizar(consulta);
        //}

        //public int ActualizarTP(TipoProducto oTipo)
        //{
        //    string consulta = "update TipoProductos set nombre='" + oTipo.Nombre + "'," +
        //        //"idTipo=" + oTipo.IdTipo + "," +
        //        "color='" + oTipo.Color + "'," +
        //        //"nombre='" + oCliente.Nombre + "'," +
        //        "material='" + oTipo.Material + "'," +
        //        "costo=" + oTipo.Costo + "," +
        //        "largo=" + oTipo.Largo + "," +
        //        "ancho=" + oTipo.Ancho + "," +
        //        "alto=" + oTipo.Alto + "," +
        //        "cant_stock=" + oTipo.Cant_stock + "," +
        //        "periodoGarantia=" + oTipo.PeriodoGarantia + "," +
        //        "where idTipo=" + oTipo.IdTipo;
        //    //"and tipoDoc=" + oCliente.TipoDoc.IdTipoD;
        //    return BDHelper.ObtenerInstancia().Actualizar(consulta);


        //}

        //public int EliminarTP(int idTipo)
        //{
        //    string consulta = "delete from TipoProductos where idTipo=" + idTipo;
        //    return BDHelper.ObtenerInstancia().Actualizar(consulta);
        //}
    }
}
