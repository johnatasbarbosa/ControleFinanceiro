using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        public Aluno()
        {
            Ativo = true;
        }

        public int Id { get; set; }

        // [StringLength(150, ErrorMessageResourceName = "MsgStringLength", ErrorMessageResourceType = typeof(Resources.Resources), MinimumLength = 7)]
        // [Required(ErrorMessageResourceName = "O campo {0} é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        public int DiaPagamento { get; set; }

        public float Peso { get; set; }

        public float Braco { get; set; }

        public float Abs { get; set; }

        public float Gluteo { get; set; }

        public float Perna { get; set; }

        public float IMC { get; set; }
        
        public bool Ativo { get; set; }

        public string Telefone { get; set; }


        public List<Mes> Meses { get; set; }
    }
}
