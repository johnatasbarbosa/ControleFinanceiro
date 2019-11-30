using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Models;
using ControleFinanceiro.Infra;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using ControleFinanceiro.Data;
using Microsoft.AspNetCore.Authorization;

namespace ControleFinanceiro.Services
{
    [Authorize]
    public class PlanoServico
    {
        private ApplicationDbContext contexto;

        public PlanoServico()
        {
            contexto = new ApplicationDbContext();
        }

        public Plano ObterPorId(int id)
        {
            return contexto.Planos.FirstOrDefault(x => x.Id == id);
        }

        public List<Plano> ObterPlanos()
        {
            return contexto.Planos.ToList();
        }

        public ResultProcessing Salvar(Plano plano)
        {
            var result = new ResultProcessing();

            try
            {
                if (plano.Id == 0)
                {
                    contexto.Planos.Add(plano);
                    new LogServico().Salvar("Inserir plano", TipoLog.AddRecord, "", "", "", JsonSerializer.Serialize(plano));
                }
                else
                {
                    var planoDB = ObterPorId(plano.Id);
                    // planoDB.QuantidadeDias = plano.QuantidadeDias;
                    // planoDB.Valor = plano.Valor;
                    planoDB.Excluido = true;
                    contexto.Entry(planoDB).State = EntityState.Modified;

                    var newPlano = new Plano(){
                        QuantidadeDias = plano.QuantidadeDias,
                        Valor = plano.Valor
                    };
                    contexto.Planos.Add(newPlano);

                    new LogServico().Salvar("Editar plano", TipoLog.UpdateRecord, "", "", JsonSerializer.Serialize(planoDB), JsonSerializer.Serialize(newPlano));
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
            
            var dadosFiltrados = contexto.Planos.Where(a =>
                a.Excluido == false &&
                (busca == null ||
                a.QuantidadeDias.ToString().Contains(busca.ToUpper()))
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
