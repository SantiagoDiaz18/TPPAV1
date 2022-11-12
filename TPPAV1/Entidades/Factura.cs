using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	class Factura
	{
		public TipoFactura TipoFactura { get; set; }
		public int NroFactura { get; set; }
		public DateTime FechaEmision { get; set; }
		public FormaPago FormaPago { get; set; }
		public int Total { get; set; }
		public Cliente Cliente { get; set; }

		public List<DetalleFactura> Detalles {get; set; }

		public Factura()
        {
			TipoFactura tf = new TipoFactura();
			FormaPago fp = new FormaPago();
			Cliente c = new Cliente();
			List<DetalleFactura> lista = new List<DetalleFactura>();
			Detalles = lista;
			TipoFactura = tf;
			FormaPago = fp;
			Cliente = c;
        }

		public void AgregarDetalle(DetalleFactura oDetalle)
        {
			Detalles.Add(oDetalle);
        }

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
