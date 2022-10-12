using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Proveedor
	{
		public int IdProveedor { get; set; }
		public string RazonSocial { get; set; }
		public int Telefono { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public Barrio IdBarrio { get; set; }

		public Proveedor()
        {
			Barrio b = new Barrio();
			IdBarrio = b;
        }

		//public Proveedores(int idProveedor_, string razonSocial_, int telefono_, string nombre_, string apellido_, int idBario_)
		//{
		//	this.idProveedor = idProveedor_;
		//	this.razonSocial = razonSocial_;
		//	this.telefono = telefono_;
		//	this.nombre = nombre_;
		//	this.apellido = apellido_;
		//	this.idBario = idBario_;
		//}
	}
}
