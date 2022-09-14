using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Factura
	{
		public int TipoFactura { get; set; }
		public int NroFactura { get; set; }
		public DateTime FechaEmision { get; set; }
		public int IdFormaPago { get; set; }
		public int Total { get; set; }
		public int TipoDocCl { get; set; }
		public int NroDocCl { get; set; }

		//public Facturas(int tipoFactura_, int nroFactura_, DateTime fechaEmision_, int idFormaPago_, int total_, int tipoDocCl_, int nroDocCl_)
		//{
		//	this.tipoFactura = tipoFactura_;
		//	this.nroFactura = nroFactura_;
		//	this.fechaEmision = fechaEmision_;
		//	this.idFormaPago = idFormaPago_;
		//	this.total = total_;
		//	this.tipoDocCl = tipoDocCl_;
		//	this.nroDocCl = nroDocCl_;
		//}
	}
}
