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
using ControleFinanceiro.Data;
using Microsoft.AspNetCore.Authorization;

namespace ControleFinanceiro.Services
{
    [Authorize]    
    public class FinancaServico
    {
        private ApplicationDbContext contexto;

        public FinancaServico()
        {
            contexto = new ApplicationDbContext();
        }

        public Plano ObterPorId(int id)
        {
            return contexto.Planos.FirstOrDefault(x => x.Id == id);
        }

        public Financa Calcular(string dateString){
            try{
                DateTime data = Convert.ToDateTime(dateString);
                var valorArrecadado = contexto.Meses.Where(m => m.Pago && m.Ativo && m.Data.Month == data.Month && m.Data.Year == data.Year).Sum(m => m.ValorPromocional.HasValue ? m.ValorPromocional.Value : m.Plano.Valor);
                var valorTotal = contexto.Meses.Where(m => m.Ativo && m.Data.Month == data.Month && m.Data.Year == data.Year).Sum(m => m.ValorPromocional.HasValue ? m.ValorPromocional.Value : m.Plano.Valor);
                var qtdAlunosPagarem = contexto.Meses.Count(m => m.Pago && m.Ativo && m.Data.Month == data.Month && m.Data.Year == data.Year);
                var qtdAlunosTotais = contexto.Meses.Count(m => m.Ativo && m.Data.Month == data.Month && m.Data.Year == data.Year);

                var financa = new Financa(){
                    ValorArrecadado = valorArrecadado,
                    ValorTotal = valorTotal,
                    QtdAlunosPagarem = qtdAlunosPagarem,
                    QtdAlunosTotais = qtdAlunosTotais
                };
                return financa;
            }
            catch(Exception e)
            {
                var a = e;
                return null;
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
        public DadosPaginados ListarPaginado(int pagina, int qtdLinhas, string busca, string campoOrdenacao, string tipoOrdenacao)
        {
            //Calcula o registro inicial a ser mostrado com base na página atual e a qtd de linhas a ser exibida na mesma.
            int registroInicial = (pagina - 1) * qtdLinhas;
            campoOrdenacao += tipoOrdenacao.ToUpper().Equals("DESC") ? " DESCENDING" : "";
            
            // var dadosFiltrados = contexto.Planos.Where(a =>
            //     (busca == null ||
            //     a.QuantidadeDias.ToString().Contains(busca.ToUpper()))
            // );
            // var distinctPeople = contexto.Meses.GroupBy(p => p.Data).Select(g => g.First()).ToList();
            var meses = contexto.Meses.Select(m => new DateTime(m.Data.Year, m.Data.Month, 1)).Distinct().ToList();
            // var meses2 = meses.OrderByDescending(m => m.Year).ThenByDescending(m => m.Month).ToList();

            // var dadosFiltrados = contexto.Meses.Select(m => new DateTime(m.Data.Year, m.Data.Month, 1)).Distinct();
            var dadosFiltrados = meses.OrderByDescending(x => x.Date);
            
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
            return dadosPaginados;
        }

    }
}
