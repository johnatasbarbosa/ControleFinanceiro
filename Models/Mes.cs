using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Data de vencimento")]
        public DateTime Data { get; set; }

        public bool Pago { get; set; }

        [Display(Name = "Dia de pagamento")]
        public DateTime? DiaPagamento { get; set; }

        public bool Ativo { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        
        
        [Display(Name = "Plano (em dias)")]
        public int PlanoId { get; set; }
        public Plano Plano { get; set; }

        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        [Display(Name = "Valor Promocional")]
        public double? ValorPromocional { get; set; }

    }
}
