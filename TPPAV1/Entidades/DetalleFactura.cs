using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class DetalleFactura
	{
		public int TipoFactura { get; set; }
		public int NroFactura { get; set; }
		public int IdProducto { get; set; }
		public int PrecioUnitario { get; set; }
		public int Cantidad { get; set; }

		//public DetalleFactura(int tipoFactura_, int nroFactura_, int idProducto_, int precioUnitario_, int cantidad_)
		//{
		//	this.tipoFactura = tipoFactura_;
		//	this.nroFactura = nroFactura_;
		//	this.idProducto = idProducto_;
		//	this.precioUnitario = precioUnitario_;
		//	this.cantidad = cantidad_;
		//}
	}
}
