using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Models;
using ControleFinanceiro.Infra;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Services
{
    public class AlunoServico
    {
        private ControleFinanceiroContexto contexto;

        public AlunoServico()
        {
            contexto = new ControleFinanceiroContexto();
        }

        public void GerarMeses(){
            var now = DateTime.Now;
            var alunos = contexto.Alunos.Where(x => x.Meses.Any(m => m.Data.Month == now.Month && m.Data.Year == now.Year) == false);
            foreach(var aluno in alunos){
                var lastCiclo = contexto.Ciclos.FirstOrDefault(x => x.AlunoId == aluno.Id && x.DataFinal == null);
                var mes = new Mes();
                mes.AlunoId = aluno.Id;
                mes.Ativo = aluno.Ativo;
                mes.Data = new DateTime(now.Year, now.Month, aluno.DiaPagamento);
                mes.CicloId = lastCiclo == null ? 0 : lastCiclo.Id;
                contexto.Meses.Add(mes);
            }
            contexto.SaveChanges();
        }

        public Aluno ObterPorId(int id)
        {
            return contexto.Alunos.FirstOrDefault(a => a.Id == id);
        }    

        public ResultProcessing Excluir(int id)
        {
            var result = new ResultProcessing();

            try
            {
                var aluno = ObterPorId(id);
                contexto.Alunos.Remove(aluno);
                result.Success = true;
                result.Message = "Excluido com Sucesso";
                contexto.SaveChanges();
            }
            catch(Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
            }

            return result;
        }

        public ResultProcessing Salvar(Aluno aluno)
        {
            var result = new ResultProcessing();

            try
            {
                if (aluno.Id == 0)
                {
                    contexto.Alunos.Add(aluno);
                }
                else
                {
                    contexto.Entry(aluno).State = EntityState.Modified;
                }
                result.Success = true;
                result.Message = "Salvo com Sucesso";
                contexto.SaveChanges();
            }
            catch(Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
            }
            return result;
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
            
            var dadosFiltrados = contexto.Alunos.Where(a =>
                (busca == null ||
                a.Nome.ToUpper().Contains(busca.ToUpper()))
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
            return dadosPaginados;
        }

    }
}
