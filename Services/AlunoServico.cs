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
            // foreach(var aluno in alunos){
            //     var lastCiclo = contexto.Ciclos.FirstOrDefault(x => x.AlunoId == aluno.Id && x.DataFinal == null);
            //     var mes = new Mes();
            //     mes.AlunoId = aluno.Id;
            //     mes.Ativo = aluno.Ativo;
            //     mes.Data = new DateTime(now.Year, now.Month, aluno.DiaPagamento);
            //     mes.CicloId = lastCiclo == null ? 0 : lastCiclo.Id;
            //     contexto.Meses.Add(mes);
            // }
            contexto.SaveChanges();
        }

        public Aluno ObterPorId(int id)
        {
            var aluno = contexto.Alunos.Include(x => x.Meses).Select(x => new Aluno(){
                Id = x.Id,
                Nome = x.Nome,
                DiaPagamento = x.DiaPagamento,
                Ativo = x.Ativo,
                Meses = x.Meses.OrderBy(d => d.Data).ToList()
            }).FirstOrDefault(a => a.Id == id);
            // aluno.Meses = contexto.Meses
            return aluno;
        }

        public Aluno ObterPorIdParaEditar(int id)
        {
            return contexto.Alunos.Include(x => x.Ciclo).FirstOrDefault(x => x.Id == id);
        }

        public Mes ObterMesPorId(int id)
        {
            return contexto.Meses.Include(x => x.Aluno).FirstOrDefault(x => x.Id == id);
        }

        // public List<Ciclo> ObterCiclosPorAlunoId(int alunoId)
        // {
        //     var ciclos = contexto.Ciclos.Where(a => a.Aluno.Id == alunoId).Select(x => 
        //         new Ciclo(){
        //             Id = x.Id,
        //             Plano = x.Plano,
        //             DataInicio = x.DataInicio,
        //             DataFinal = x.DataFinal,
        //             Professor = x.Professor,
        //             ValorPromocional = x.ValorPromocional
        //         }
        //     ).ToList();
        //     return ciclos;
        // }

        public Ciclo ObterCicloPorAlunoId(int alunoId)
        {
            return contexto.Alunos.Include(x => x.Ciclo).Select(x => x.Ciclo).FirstOrDefault(a => a.Id == alunoId);
        }

        public List<Plano> ObterPlanos()
        {
            return contexto.Planos.ToList();
        }

        public ResultProcessing SalvarMes(Mes mes)
        {
            var result = new ResultProcessing();

            try
            {
                var mesDB = contexto.Meses.FirstOrDefault(x => x.Id == mes.Id);
                if(mesDB.Pago == false && mes.Pago){
                    mesDB.DiaPagamento = DateTime.Now;
                }
                if(mesDB.Pago && mes.Pago == false){
                    mesDB.DiaPagamento = null;
                }
                mesDB.Pago = mes.Pago;
                if(mesDB.Ativo && mes.Ativo == false){
                    mesDB.DiaPagamento = null;
                    mesDB.Pago = false;
                }
                mesDB.Ativo = mes.Ativo;
                contexto.Entry(mesDB).State = EntityState.Modified;
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

        public ResultProcessing Salvar(Aluno aluno)
        {
            var result = new ResultProcessing();

            try
            {
                if (aluno.Id == 0)
                {
                    // var ciclo = new Ciclo();
                    // ciclo.Plano = contexto.Planos.FirstOrDefault(x => x.Id == aluno.PlanoId);
                    aluno.Ciclo.Professor = contexto.Professores.FirstOrDefault();
                    var planoSelecionado = contexto.Planos.FirstOrDefault(x => x.Id == aluno.Ciclo.PlanoId);
                    if(aluno.Ciclo.ValorPromocional == planoSelecionado.Valor){
                        aluno.Ciclo.ValorPromocional = null;
                    }
                    contexto.Alunos.Add(aluno);
                    contexto.SaveChanges();
                    // contexto.Alunos.Add(aluno);

                    var mes = new Mes();
                    mes.Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, aluno.DiaPagamento);
                    mes.AlunoId = aluno.Id;
                    mes.Ciclo = new Ciclo(){
                        PlanoId = aluno.Ciclo.PlanoId,
                        ProfessorId = aluno.Ciclo.ProfessorId,
                        ValorPromocional = aluno.Ciclo.ValorPromocional
                    };
                    contexto.Meses.Add(mes);
                }
                else
                {
                    var alunoDB = ObterPorIdParaEditar(aluno.Id);
                    alunoDB.Ciclo.PlanoId = aluno.Ciclo.PlanoId;
                    alunoDB.Ciclo.ValorPromocional = aluno.Ciclo.ValorPromocional;
                    
                    alunoDB.Nome = aluno.Nome;
                    alunoDB.DataNascimento = aluno.DataNascimento;
                    alunoDB.Telefone = aluno.Telefone;
                    alunoDB.DiaPagamento = aluno.DiaPagamento;
                    alunoDB.Peso = aluno.Peso;
                    alunoDB.Braco = aluno.Braco;
                    alunoDB.Abs = aluno.Abs;
                    alunoDB.Gluteo = aluno.Gluteo;
                    alunoDB.Perna = aluno.Perna;
                    alunoDB.IMC = aluno.IMC;

                    contexto.Entry(alunoDB).State = EntityState.Modified;
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

        public ResultProcessing Ativar(int id)
        {
            var result = new ResultProcessing { Success = true };
            try
            {
                var aluno = contexto.Alunos.FirstOrDefault(a => a.Id == id);

                if (aluno.Ativo == true)
                {
                    aluno.Ativo = false;
                }
                else
                {
                    aluno.Ativo = true;
                }
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
            }
            return result;
        }
        
        public ResultProcessing Pagar(int id)
        {
            var result = new ResultProcessing { Success = true };
            try
            {
                var mes = contexto.Meses.FirstOrDefault(a => a.Id == id);

                if (mes.Pago == true)
                {
                    mes.Pago = false;
                }
                else
                {
                    mes.Pago = true;
                }
                contexto.SaveChanges();
            }
            catch (Exception e)
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
            
            var dadosFiltrados = contexto.Alunos.Include(x => x.Meses).Where(a =>
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
