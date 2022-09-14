using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class TipoProducto
	{
		public int IdTipo { get; set; }
		public string Color { get; set; }
		public string Material { get; set; }
		public int Costo { get; set; }
		public int Peso { get; set; }
		public int Largo { get; set; }
		public int Ancho { get; set; }
		public int Alto { get; set; }
		public int Cant_stock { get; set; }
		public int PeriodoGarantia { get; set; }
		public string Nombre { get; set; }

		//public TipoProductos(int idTipo_, string color_, string material_, int costo_, int peso_, int largo_, int ancho_, int alto_, int cant_stock_, int periodoGarantia_, string nombre_)
		//{
		//	this.idTipo = idTipo_;
		//	this.color = color_;
		//	this.material = material_;
		//	this.costo = costo_;
		//	this.peso = peso_;
		//	this.largo = largo_;
		//	this.ancho = ancho_;
		//	this.alto = alto_;
		//	this.cant_stock = cant_stock_;
		//	this.periodoGarantia = periodoGarantia_;
		//	this.nombre = nombre_;
		//}
	}
}
