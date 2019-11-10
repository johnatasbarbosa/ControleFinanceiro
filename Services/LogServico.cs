using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Models;
using ControleFinanceiro.ViewModels;
using ControleFinanceiro.Infra;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Services
{
    public class LogServico
    {
        private ControleFinanceiroContexto contexto;

        public LogServico()
        {
            contexto = new ControleFinanceiroContexto();
        }

        public Log ObterPorId(int id)
        {
            return contexto.Logs.FirstOrDefault(l => l.Id == id);
        }

        public ResultProcessing Salvar(string descricao, TipoLog tipo, string usuario = "", string ip = "", string statusAnterior = "", string statusAtual = "")
        {
            Log item = new Log()
            {
                Descricao = descricao,
                TipoLog = tipo,
                NomeUsuario = usuario,
                Ip = ip,
                StatusAnterior = statusAnterior,
                StatusAtual = statusAtual
            };
            return Salvar(item);
        }

        public ResultProcessing Salvar(Log item)
        {
            var result = new ResultProcessing();
            try
            {
                if (item.Id == 0)
                {
                    contexto.Logs.Add(item);
                }
                else
                {
                    result.Success = false;
                    result.Message = "Is not logs editing allowed";
                    return result;
                }
                contexto.SaveChanges();
                result.Success = true;
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        /// <summary>
        /// Filtra e ordena os dados 
        /// </summary>
        /// <param name="pagina">Posição da página atual sendo exibida</param>
        /// <param name="qtdLinhas">Quantidade de registro por páginas</param>
        /// <param name="busca">Palavra a ser buscada em todos os campos</param>
        /// <param name="campoOrdenacao">Campo a ser ordenado</param>
        /// <param name="tipoOrdenacao">Tipo de ordenação : asc / desc</param>
        /// <returns>Retorna apenas os dados que devem ser exibidos na página atual.
        /// </returns>
        public DadosPaginados ListarPaginado(int pagina, int qtdLinhas, string busca, string campoOrdenacao, string tipoOrdenacao, TipoLog? tipo)
        {
            //Calcula o registro inicial a ser mostrado com base na página atual e a qtd de linhas a ser exibida na mesma.
            int registroInicial = (pagina - 1) * qtdLinhas;
            campoOrdenacao += tipoOrdenacao.ToUpper().Equals("DESC") ? " DESCENDING" : "";

            var dadosFiltrados = contexto.Logs.Where(p =>
                (tipo.HasValue == false || tipo.Value == 0 || p.TipoLog == tipo) && (
                busca == null ||
                p.Descricao.Contains(busca) ||
                p.Ip.Contains(busca) ||
                p.Data.ToString().Contains(busca) ||
                p.NomeUsuario.Contains(busca) ||
                p.TipoLog.ToString().Contains(busca))
            );
            dadosFiltrados = dadosFiltrados.OrderBy(campoOrdenacao);

            DadosPaginados dadosPaginados = new DadosPaginados();
            dadosPaginados.Pagina = pagina;
            dadosPaginados.QuantidadePorPagina = qtdLinhas;
            dadosPaginados.Total = dadosFiltrados.Count();

            if (qtdLinhas < 0)
            {
                dadosPaginados.Dados = dadosFiltrados.Skip(registroInicial).ToList();
            }
            else
            {
                dadosPaginados.Dados = dadosFiltrados.Skip(registroInicial).Take(qtdLinhas).ToList();
            }
            foreach (Log l in dadosPaginados.Dados)
            {
                l.StatusAnterior = "";
                l.StatusAtual = "";
            }
            return dadosPaginados;
        }
    }
}
