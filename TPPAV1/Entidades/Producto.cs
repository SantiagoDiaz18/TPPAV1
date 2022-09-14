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
		public int Precio { get; set; }
		public int IdTipo { get; set; }
		public int IdProveedor { get; set; }

		//public Producto(int idProducto_, int precio_, int idTipo_, int idProveedor_)
		//{
		//	this.idProducto = idProducto_;
		//	this.precio = precio_;
		//	this.idTipo = idTipo_;
		//	this.idProveedor = idProveedor_;
		//}
	}
}
