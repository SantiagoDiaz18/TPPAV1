using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Producto
	{
		public int IdProducto { get; set; }
		public TipoProducto IdTipo { get; set; }
		public ProductoColor IdColor { get; set; }
		public ProductoMaterial IdMaterial { get; set; }
		public int Precio { get; set; }
		public int Costo { get; set; }
		public int Peso { get; set; }
		public int Largo { get; set; }
		public int Ancho { get; set; }
		public int Alto { get; set; }
		public int Stock { get; set; }
		public DateTime PeriodoGarantia { get; set; }
		public int IdProveedor { get; set; }

		public Producto()
        {
			ProductoColor pc = new ProductoColor();
			TipoProducto tp = new TipoProducto();
			ProductoMaterial pm = new ProductoMaterial();
			IdColor = pc;
			IdMaterial = pm;
			IdTipo = tp;
        }

        internal List<Producto> traerPorId(int id)
        {
            throw new NotImplementedException();
        }


        //public Producto(int idProducto_, int precio_, int idTipo_, int idProveedor_)
        //{
        //	this.idProducto = idProducto_;
        //	this.precio = precio_;
        //	this.idTipo = idTipo_;
        //	this.idProveedor = idProveedor_;
        //}
    }
}
