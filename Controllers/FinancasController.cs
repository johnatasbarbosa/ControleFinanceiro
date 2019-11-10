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
using Newtonsoft.Json.Linq;

namespace ControleFinanceiro.Controllers
{
    public class FinancasController : Controller
    {
        private readonly ILogger<FinancasController> _logger;
        private FinancasServico servico = new FinancasServico();

        public FinancasController(ILogger<FinancasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        public ActionResult Visualizar(string id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var data = servico.Calcular(id);
            if (data != null)
            {
                return PartialView("_Visualizar", data);
            }
            ViewBag.Titulo = "Falha ao abrir o registro";
            ViewBag.Mensagem = "Registro não encontrado";
            return PartialView("_ErroModal");
        }

    }
}
