using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Models;
using ControleFinanceiro.Infra;
using ControleFinanceiro.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authorization;

namespace ControleFinanceiro.Services
{
    [Authorize]
    public class AlunoServico
    {
        private ApplicationDbContext contexto;

        public AlunoServico()
        {
            contexto = new ApplicationDbContext();
        }

        public int GerarMeses()
        {
            try{
                var now = DateTime.Now;
                var alunos = contexto.Alunos.Where(x => x.Ativo && x.Meses.Any(m => m.Data.Month == now.Month && m.Data.Year == now.Year) == false);
                foreach(var aluno in alunos){
                    var mes = new Mes(){
                        Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, aluno.DiaPagamento),
                        AlunoId = aluno.Id,
                        PlanoId = aluno.PlanoId,
                        ProfessorId = aluno.ProfessorId,
                        ValorPromocional = aluno.ValorPromocional
                    };
                    contexto.Meses.Add(mes);
                }
                contexto.SaveChanges();
                return alunos.Count();
            }
            catch(Exception e)
            {
                return -1;
            }
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
            var aluno = contexto.Alunos.FirstOrDefault(x => x.Id == id);
            aluno.Plano = contexto.Planos.FirstOrDefault(a => a.Id == aluno.PlanoId);
            return aluno;
        }

        public Mes ObterMesPorId(int id)
        {
            return contexto.Meses.Include(x => x.Aluno).Include(x => x.Plano).FirstOrDefault(x => x.Id == id);
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
                mesDB.PlanoId = mes.PlanoId;
                mesDB.ValorPromocional = mes.ValorPromocional;
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
                    aluno.ProfessorId = contexto.Professores.Select(p => p.Id).FirstOrDefault();
                    var mes = new Mes(){
                        Data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, aluno.DiaPagamento),
                        PlanoId = aluno.PlanoId,
                        ProfessorId = aluno.ProfessorId,
                        ValorPromocional = aluno.ValorPromocional
                    };
                    aluno.Meses = new List<Mes>();
                    aluno.Meses.Add(mes);
                    contexto.Alunos.Add(aluno);
                    //contexto.SaveChanges();

                    var alunoLog = new Aluno(){
                        Nome = aluno.Nome,
                        DataNascimento = aluno.DataNascimento,
                        Telefone = aluno.Telefone,
                        DiaPagamento = aluno.DiaPagamento,
                        Peso = aluno.Peso,
                        Braco = aluno.Braco,
                        Abs = aluno.Abs,
                        Gluteo = aluno.Gluteo,
                        Perna = aluno.Perna,
                        IMC = aluno.IMC,
                        PlanoId = aluno.PlanoId,
                        ProfessorId = aluno.ProfessorId,
                        ValorPromocional = aluno.ValorPromocional
                    };
                    new LogServico().Salvar("Inserir aluno", TipoLog.AddRecord, "", "", "", JsonSerializer.Serialize(alunoLog));
                }
                else
                {
                    var alunoDB = ObterPorIdParaEditar(aluno.Id);
                    alunoDB.PlanoId = aluno.PlanoId;
                    alunoDB.ValorPromocional = aluno.ValorPromocional;
                    
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

                    var statusAnterior = contexto.Alunos.AsNoTracking().FirstOrDefault(x => x.Id == alunoDB.Id);
                    new LogServico().Salvar("Editar aluno", TipoLog.UpdateRecord, "", "", JsonSerializer.Serialize(statusAnterior), JsonSerializer.Serialize(alunoDB));
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
                    new LogServico().Salvar("Destivar aluno", TipoLog.Desativar, "", "", "", JsonSerializer.Serialize(aluno));
                }
                else
                {
                    aluno.Ativo = true;
                    new LogServico().Salvar("Ativar aluno", TipoLog.Ativar, "", "", "", JsonSerializer.Serialize(aluno));
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
                    mes.DiaPagamento = null;
                    new LogServico().Salvar("Desfazer pagamento", TipoLog.UpdateRecord, "", "", "", JsonSerializer.Serialize(mes));
                }
                else
                {
                    mes.Pago = true;
                    mes.DiaPagamento = DateTime.Now;
                    new LogServico().Salvar("Fazer pagamento", TipoLog.UpdateRecord, "", "", "", JsonSerializer.Serialize(mes));
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
        public DadosPaginados ListarPaginado(int pagina, int qtdLinhas, string busca, string campoOrdenacao, string tipoOrdenacao, Enums.Status? status, Enums.Situacao? situacao)
        {
            //Calcula o registro inicial a ser mostrado com base na página atual e a qtd de linhas a ser exibida na mesma.
            int registroInicial = (pagina - 1) * qtdLinhas;
            campoOrdenacao += tipoOrdenacao.ToUpper().Equals("DESC") ? " DESCENDING" : "";
            
            var dadosFiltrados = contexto.Alunos.Include(x => x.Meses).Where(a =>
                ((status.Value == Enums.Status.Todos) || (status.Value == Enums.Status.Ativos && a.Ativo) || (status.Value == Enums.Status.Inativos && a.Ativo == false)) &&
                (
                    situacao.HasValue == false ||
                    (situacao.Value == Enums.Situacao.Todos) || 
                    (situacao.Value == Enums.Situacao.PagamentoEmDia && a.Meses.Any(m => m.Pago == false && m.Data.CompareTo(DateTime.Now) < 0) == false) || 
                    (situacao.Value == Enums.Situacao.Devendo && a.Meses.Any(m => m.Pago == false && m.Data.CompareTo(DateTime.Now) < 0) == true)
                ) &&
                (busca == null ||
                a.Nome.ToUpper().Contains(busca.ToUpper()))
            );
            dadosFiltrados = dadosFiltrados.OrderBy(campoOrdenacao);
            foreach(var aluno in dadosFiltrados){
                aluno.Meses = aluno.Meses.OrderByDescending(m => m.Data).ToList();
                aluno.Devendo = aluno.Meses.Any(m => m.Pago == false && m.Data.CompareTo(DateTime.Now) < 0);
            }
            
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
