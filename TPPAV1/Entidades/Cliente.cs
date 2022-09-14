using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Cliente
	{
		public int NroDoc { get; set; }
		public int TipoDoc { get; set; }
		public string Apellido { get; set; }
		public string Nombre { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public string Sexo { get; set; }
		public int IdBarrio { get; set; }
		public int Telefono { get; set; }
		public int IdUsuario { get; set; }

		public Cliente(int nroDoc_, int tipoDoc_, string apellido_, string nombre_, DateTime fechaNacimiento_, string sexo_, int idBarrio_, int telefono_, int idUsuario_)
		{
			this.NroDoc = nroDoc_;
			this.TipoDoc = tipoDoc_;
			this.Apellido = apellido_;
			this.Nombre = nombre_;
			this.FechaNacimiento = fechaNacimiento_;
			this.Sexo = sexo_;
			this.IdBarrio = idBarrio_;
			this.Telefono = telefono_;
			this.IdUsuario = idUsuario_;
		}
	}
}
