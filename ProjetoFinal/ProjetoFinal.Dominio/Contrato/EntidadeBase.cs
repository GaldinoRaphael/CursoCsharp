using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal.Dominio.Contrato
{
	public abstract class EntidadeBase
	{
		public EntidadeBase() => Id = Guid.NewGuid();

		public Guid Id { get; private set; }
	}
}
