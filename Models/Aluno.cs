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
        // [Required(ErrorMessage="O nome do usuário é obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage="O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage="O campo Data Nascimento é obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Dia de Pagamento")]
        [Required(ErrorMessage="O campo Dia de Pagamento é obrigatório.")]
        public int DiaPagamento { get; set; }

        [Display(Name = "Peso")]
        public float? Peso { get; set; }

        [Display(Name = "Braço")]
        public float? Braco { get; set; }

        [Display(Name = "Abs")]
        public float? Abs { get; set; }

        [Display(Name = "Gluteo")]
        public float? Gluteo { get; set; }

        [Display(Name = "Perna")]
        public float? Perna { get; set; }

        [Display(Name = "IMC")]
        public float? IMC { get; set; }
        
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        // [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$")]
        public string Telefone { get; set; }

        public List<Mes> Meses { get; set; }
        
        
        [Display(Name = "Plano (em dias)")]
        public int PlanoId { get; set; }
        [NotMapped]
        public Plano Plano { get; set; }

        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }
        [NotMapped]
        public Professor Professor { get; set; }

        [Display(Name = "Valor Promocional")]
        public double? ValorPromocional { get; set; }

        [NotMapped]
        public Enums.Status Status { get; set; }
        [NotMapped]
        public Enums.Situacao Situacao { get; set; }
        [NotMapped]
        public bool Devendo { get; set; }
    }
}
