using ProjetoFinal.Dominio.Contrato;
using ProjetoFinal.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal.Dominio
{

	public class Tarefa : EntidadeBase
	{
		public string Descricao { get; set; }
		public bool Concluido { get; set; }
		public DateTime DataCriacao { get; set; }
		public NivelCriticidade Criticidade { get; set; }
		public string Observacao { get; set; }
		public Usuario Proprietario { get; set; }
	}
}
