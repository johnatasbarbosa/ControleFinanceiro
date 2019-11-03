using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Meses")]
    public class Mes
    {
        public Mes()
        {
            DiaPagamento = null;
            Pago = false;
            Ativo = true;
        }

        public int Id { get; set; }

        public DateTime Data { get; set; }

        public bool Pago { get; set; }

        public DateTime? DiaPagamento { get; set; }

        public bool Ativo { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int CicloId { get; set; }
        // public Ciclo Ciclo { get; set; }
    }
}
