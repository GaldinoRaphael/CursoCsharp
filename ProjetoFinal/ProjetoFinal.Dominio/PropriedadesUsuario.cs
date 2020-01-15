using ProjetoFinal.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal.Dominio
{
	public class PrioridadesUsuario : EntidadeBase
	{
		public Usuario Proprietario { get; set; }
		public IEnumerable<Tarefa> Tarefas { get; set; }
	}
}
