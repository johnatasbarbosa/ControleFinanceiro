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
            ViewBag.Planos = servico.ObterPlanos();
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

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var aluno = servico.ObterPorIdParaEditar(id.Value);

            if (aluno == null)
            {
                return StatusCode(404);
            }

            ViewBag.Planos = servico.ObterPlanos();
            return PartialView("_Editar", aluno);
        }

        [HttpPost]
        public JsonResult Editar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                var resultado = servico.Salvar(aluno);
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

        [HttpGet]
        public ActionResult Visualizar(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var data = servico.ObterPorIdParaEditar(id.Value);
            if (data != null)
            {
                return PartialView("_Visualizar", data);
            }
            ViewBag.Titulo = "Falha ao abrir o registro";
            ViewBag.Mensagem = "Registro não encontrado";
            return PartialView("_ErroModal");
        }

        [HttpGet]
        public ActionResult Ativar(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var data = servico.ObterPorIdParaEditar(id.Value);
            if (data != null)
                return PartialView("_Ativar", data);
            else
            {
                ViewBag.Titulo = "Falha ao abrir o registro";
                ViewBag.Mensagem = "Registro não encontrado";
            }
            return PartialView("_ErroModal");
        }

        [HttpPost]
        public JsonResult Ativar(Aluno aluno)
        {
            var result = new ResultProcessing();

            result = servico.Ativar(aluno.Id);
            if (result.Success)
            {
                    result.Message = "Editado com Sucesso";
            }
            else
            {
                result.Success = false;
                result.Message = "Registro não encontrado";
            }

            return Json(new { success = result.Success, message = result.Message });
        }

        [HttpGet]
        public ActionResult Pagar(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var data = servico.ObterMesPorId(id.Value);
            if (data != null)
                return PartialView("_Pagar", data);
            else
            {
                ViewBag.Titulo = "Falha ao abrir o registro";
                ViewBag.Mensagem = "Registro não encontrado";
            }
            return PartialView("_ErroModal");
        }

        [HttpPost]
        public JsonResult Pagar(Mes mes)
        {
            var result = new ResultProcessing();

            result = servico.Pagar(mes.Id);
            if (result.Success)
            {
                    result.Message = "Editado com Sucesso";
            }
            else
            {
                result.Success = false;
                result.Message = "Registro não encontrado";
            }

            return Json(new { success = result.Success, message = result.Message });
        }

        [HttpGet]
        public ActionResult Pagamentos(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }

            var aluno = servico.ObterPorId(id.Value);
            // ViewBag.Ciclos = servico.ObterCiclosPorAlunoId(aluno.Id);
            if (aluno != null)
                return View("Pagamentos", aluno);
            else
            {
                ViewBag.Titulo = "Falha ao abrir o registro";
                ViewBag.Mensagem = "Registro não encontrado";
            }
            return PartialView("_ErroModal");
        }

        [HttpPost]
        public JsonResult SalvarMes([FromBody]JObject body)
        {
            var result = new ResultProcessing();

            var mes = new Mes(){
                Id = body.GetValue("id").Value<int>(),
                Pago = body.GetValue("pago").Value<bool>(),
                Ativo = body.GetValue("ativo").Value<bool>()
            };
            result = servico.SalvarMes(mes);

            return Json(new { success = result.Success, message = result.Message });
        }

    }
}
