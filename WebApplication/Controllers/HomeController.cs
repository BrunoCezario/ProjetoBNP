using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using Dominio;

namespace WebApplication.Controllers
{
	public class HomeController : Controller
	{
		public IMovimentoManualRepositorio _repositorio;
		public HomeController(IMovimentoManualRepositorio repositorio)
		{
			_repositorio = repositorio;
		}
		public ActionResult Index()
		{
			return View();
		}


		public ActionResult Cadastrar(MovimentoManualModel modeloDeTela)
		{
			MovimentoManual movimentoManual = ConversorDaEntidade(modeloDeTela);

			_repositorio.Adicionar(movimentoManual);

			return View();

		}

		private static MovimentoManual ConversorDaEntidade(MovimentoManualModel modeloDeTela)
		{
			var movimentoManual = new MovimentoManual();
			movimentoManual.Mes = modeloDeTela.Mes;
			movimentoManual.Ano = modeloDeTela.Ano;
			movimentoManual.NumLancamento = modeloDeTela.NumLancamento;
			movimentoManual.CodProduto = modeloDeTela.CodProduto;
			movimentoManual.CodCosif = modeloDeTela.Descricao;
			movimentoManual.DataMovimento = DateTime.Now.Date;
			movimentoManual.CodUsuario = "TESTE";
			movimentoManual.Valor = modeloDeTela.Valor;
			return movimentoManual;
		}
	}

}