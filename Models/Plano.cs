using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Planos")]
    public class Plano
    {
        public Plano(){
            Excluido = false;
        }

        public int Id { get; set; }
        public int QuantidadeDias { get; set; }
        public float Valor { get; set; }
        public bool Excluido { get; set; }
    }
}
