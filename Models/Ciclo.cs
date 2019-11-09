using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Ciclos")]
    public class Ciclo
    {
        public int Id { get; set; }

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
