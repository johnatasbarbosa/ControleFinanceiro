using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario()
        {
            Ativo = true;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string NomeUsuario { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public bool Administrador { get; set; }

    }
}
