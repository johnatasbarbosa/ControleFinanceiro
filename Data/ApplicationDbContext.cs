using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Identity;

namespace ControleFinanceiro.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext()
        {
        }
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Mes> Meses { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Plano> Planos { get; set; }

        // public DbSet<Ciclo> Ciclos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                // @"Server=(localdb)\mssqllocaldb;Database=ControleFinanceiro1;Integrated Security=True");
                @"Data Source=.\SQLEXPRESS;Initial Catalog=ControleFinanceiroDB;Integrated Security=True;MultipleActiveResultSets=True");
                // Server=(localdb)\\mssqllocaldb;Database=ControleFinanceiroDB;Trusted_Connection=True;MultipleActiveResultSets=true
        }
    }
}
