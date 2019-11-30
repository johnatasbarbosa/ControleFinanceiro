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
using Microsoft.AspNetCore.Authorization;

namespace ControleFinanceiro.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LogController : Controller
    {
        private LogServico servico = new LogServico();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar(GridParams parametros, TipoLog? tipoLog)
        {
            CampoOrdenado campo = parametros.ObterCampoOrdenado(Request);

            var dadosPaginados = servico.ListarPaginado(parametros.Current, parametros.rowCount, parametros.SearchPhrase, campo.Campo, campo.Ordem, tipoLog);
            return Json(new { current = dadosPaginados.Pagina, rowCount = dadosPaginados.QuantidadePorPagina, rows = dadosPaginados.Dados, total = dadosPaginados.Total });
        }

        [HttpGet]
        public ActionResult ExibirDetalhes(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            Log log = servico.ObterPorId(id.Value);

            if (log == null)
            {
                return StatusCode(404);
            }

            return PartialView("_ExibirDetalhes", log);

        }
    }
}