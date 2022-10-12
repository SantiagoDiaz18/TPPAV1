using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPav1.Entidades
{
	public class Usuario
	{
		private int IdUsuario;

		public int Id_usuario
		{
			get { return IdUsuario; }
			set { IdUsuario = value; }
		}

		public string NombreUsuario { get; set; }
		public string Password { get; set; }
		public string Mail { get; set; }
		public bool Borrado { get; set; }
		//public Usuarios(int idUsuario_, string usuario_, string contraseña_, string mail_)
		//{
		//	this.idUsuario = idUsuario_;
		//	this.usuario = usuario_;
		//	this.contraseña = contraseña_;
		//	this.mail = mail_;
		//}
	}
}
