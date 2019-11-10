using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Models;

namespace ControleFinanceiro
{
    class ControleFinanceiroContexto : DbContext
    {
        public ControleFinanceiroContexto(DbContextOptions<ControleFinanceiroContexto> options) : base(options)         
        {         
        }       
        public ControleFinanceiroContexto()        
        {         
        }
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Mes> Meses { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Plano> Planos { get; set; }

        public DbSet<Ciclo> Ciclos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                // @"Server=(localdb)\mssqllocaldb;Database=ControleFinanceiro;Integrated Security=True");
                @"Data Source=.\SQLEXPRESS;Initial Catalog=ControleFinanceiro;Integrated Security=True;MultipleActiveResultSets=True");                    
        }
    }
}
