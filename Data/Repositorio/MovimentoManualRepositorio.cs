using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
	public class MovimentoManualRepositorio : IMovimentoManualRepositorio
	{
		public Persistencia _persistencia;
		public MovimentoManualRepositorio(Persistencia persistencia)
		{
			_persistencia = persistencia;
		}

		public void Adicionar(MovimentoManual movimento)
		{
			_persistencia.MovimentoManual.Add(movimento);

			_persistencia.SaveChanges();

		}
	}
}
