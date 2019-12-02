using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    public class Enums
    {
        public enum Status
        {
            Ativos = 1,
            Inativos = 2,
            Todos = 3,
        }
        public enum Situacao
        {
            Todos = 1,
            PagamentoEmDia = 2,
            Devendo = 3,
        }
    }
}
