using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Barrio
	{
		public int IdBarrio { get; set; }
		public string NombreBarrio { get; set; }
		public Localidad Localidad { get; set; }

		public Barrio()
        {
			Localidad localidad = new Localidad();
			this.Localidad = localidad;
        }
		//public bool Borrado { get; set; }

		//public Barrio(int idBarrio_, string nombreBarrio_, int idLocalidad_)
		//{
		//	this.IdBarrio = idBarrio_;
		//	this.NombreBarrio = nombreBarrio_;
		//	this.IdLocalidad = idLocalidad_;
		//}
	}
}
