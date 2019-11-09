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
    public class PlanoController : Controller
    {
        private readonly ILogger<PlanoController> _logger;
        private PlanoServico servico = new PlanoServico();

        public PlanoController(ILogger<PlanoController> logger)
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
        public ActionResult Incluir()
        {
            return PartialView("_Incluir");
        }

        [HttpPost]
        public JsonResult Incluir(Plano plano)
        {
            var result = new ResultProcessing();

            if (ModelState.IsValid)
            {
                result = servico.Salvar(plano);
                
                if(result.Success)
                    return Json(new { success = result.Success, message = result.Message });                
            }

            return Json(new { success = false, message = "Error" });
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var plano = servico.ObterPorId(id.Value);

            if (plano == null)
            {
                return StatusCode(404);
            }

            ViewBag.Planos = servico.ObterPlanos();
            return PartialView("_Editar", plano);
        }

        [HttpPost]
        public JsonResult Editar(Plano plano)
        {
            if (ModelState.IsValid)
            {
                var resultado = servico.Salvar(plano);
                if (resultado.Success)
                {
                    resultado.Message = "Editado com Sucesso";
                }
                return Json(new { success = resultado.Success, message = resultado.Message });
            }

            var mensagem = "";
            foreach (var erro in ModelState.Values.SelectMany(item => item.Errors))
            {
                if (mensagem != "") mensagem += " / ";
                mensagem += erro.ErrorMessage;
            }

            return Json(new { success = false, message = mensagem });
        }
    }
}
