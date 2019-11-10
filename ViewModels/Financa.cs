using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.ViewModels
{
    public class Financa
    {
        public int QtdAlunosAtivos { get; set; }
        public double ValorArrecadado { get; set; }
        public double ValorTotal { get; set; }

    }
}
