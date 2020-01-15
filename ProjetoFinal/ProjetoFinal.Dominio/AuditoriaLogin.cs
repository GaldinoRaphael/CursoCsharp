using ProjetoFinal.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal.Dominio
{
	public class AuditoriaLogin : EntidadeBase
	{
		public Usuario UsuarioLogado { get; set; }
		public DateTime Data { get; set; }
		public bool Logou { get; set; }
	}
}
