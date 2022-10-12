using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	class DetalleFactura
	{
		public Producto IdProducto { get; set; }
		public int PrecioUnitario { get; set; }
		public int Cantidad { get; set; }


		public DetalleFactura()
        {
			Producto p = new Producto();
			IdProducto = p;
        }


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
