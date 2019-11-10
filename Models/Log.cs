using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Logs")]
    public class Log
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Ip")]
        public string Ip { get; set; }

        [Display(Name = "Tipo Log")]
        public TipoLog TipoLog { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Status Anterior")]
        public string StatusAnterior { get; set; }

        [Display(Name = "Status Atual")]
        public string StatusAtual { get; set; }

        [Display(Name = "Usuário")]
        public string NomeUsuario { get; set; }

        public Log()
        {
            Data = DateTime.Now;
        }
    }
}
