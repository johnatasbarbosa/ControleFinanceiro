using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Ciclos")]
    public class Ciclo
    {
        public Ciclo(){
            DataInicio = DateTime.Now;
        }
        public int Id { get; set; }

        public Plano Plano { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }

        public Professor Professor { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public float? ValorPromocional { get; set; }
    }
}
