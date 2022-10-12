using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Localidad
	{
		public int IdLocalidad { get; set; }
		public string NombreLocalidad { get; set; }
		
		public bool Borrado { get; set; }

		//public Localidades(int idLocalidad_, string nombreLocalidad_, int idDepartamento_)
		//{
		//	this.idLocalidad = idLocalidad_;
		//	this.nombreLocalidad = nombreLocalidad_;
		//	this.idDepartamento = idDepartamento_;
		//}
	}
}
