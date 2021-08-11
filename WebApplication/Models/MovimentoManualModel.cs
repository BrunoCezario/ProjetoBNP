using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
	public class MovimentoManualModel
	{
		public string Mes { get; set; }
		public string Ano { get; set; }
		public string NumLancamento { get; set; }
		public string CodProduto { get; set; }
		public string CodCosif { get; set; }
		public string Descricao { get; set; }
		public DateTime DataMovimento { get; set; }
		public string CodUsuario { get; set; }
		public decimal Valor { get; set; }
	}
}