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
        // [Display(Name = "Quantidade de alunos ativos no mês")]
        public int QtdAlunosPagarem { get; set; }
        public int QtdAlunosTotais { get; set; }
        // [Display(Name = "Valor Arrecadado até o momento")]
        public double ValorArrecadado { get; set; }
        // [Display(Name = "Valor Total a receber")]
        public double ValorTotal { get; set; }

    }
}
