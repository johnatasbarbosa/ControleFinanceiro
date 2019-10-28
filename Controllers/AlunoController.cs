using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControleFinanceiro.Models;
using ControleFinanceiro.Infra;
using ControleFinanceiro.Services;
using System.Net;

namespace ControleFinanceiro.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        private AlunoServico servico = new AlunoServico();

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // servico.GerarMeses();
            string[] meses = new string[12]{"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
            ViewBag.PrimeiroMes = meses[DateTime.Now.Month - 3];
            ViewBag.SegundoMes = meses[DateTime.Now.Month - 2];
            ViewBag.TerceiroMes = meses[DateTime.Now.Month - 1];
            return View();
        }
        
        public IActionResult Listar(GridParams parametros)
        {
            CampoOrdenado campo = parametros.ObterCampoOrdenado(Request);
            var dadosPaginados = servico.ListarPaginado(parametros.Current, parametros.rowCount, parametros.SearchPhrase, campo.Campo, campo.Ordem);
            var retorno = Json(new { current = dadosPaginados.Pagina, rowCount = dadosPaginados.QuantidadePorPagina, rows = dadosPaginados.Dados, total = dadosPaginados.Total });
            return retorno;
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return PartialView("_Incluir");
        }

        [HttpPost]
        public JsonResult Incluir(Aluno aluno)
        {
            var result = new ResultProcessing();

            if (ModelState.IsValid)
            {
                result = servico.Salvar(aluno);
                
                if(result.Success)
                    return Json(new { success = result.Success, message = result.Message });                
            }

            return Json(new { success = false, message = "Error" });
        }

    }
}
