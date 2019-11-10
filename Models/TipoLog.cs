using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    public enum TipoLog
    {
        [Display(Name = "Login")]
        Login = 1,
        [Display(Name = "Novo")]
        AddRecord = 2,
        [Display(Name = "Atualizar")]
        UpdateRecord = 3,
        [Display(Name = "Excluir")]
        DeleteRecord = 4,
        [Display(Name = "Email")]
        Email = 5,
        [Display(Name = "Erro")]
        Error = 6,
        [Display(Name = "Ativar")]
        Ativar = 7,
        [Display(Name = "Desativar")]
        Desativar = 8
    }
}
