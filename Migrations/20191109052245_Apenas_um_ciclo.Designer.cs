﻿// <auto-generated />
using System;
using ControleFinanceiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleFinanceiro.Migrations
{
    [DbContext(typeof(ControleFinanceiroContexto))]
    [Migration("20191109052245_Apenas_um_ciclo")]
    partial class Apenas_um_ciclo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleFinanceiro.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("Abs")
                        .HasColumnType("real");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<float?>("Braco")
                        .HasColumnType("real");

                    b.Property<int>("CicloId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiaPagamento")
                        .HasColumnType("int");

                    b.Property<float?>("Gluteo")
                        .HasColumnType("real");

                    b.Property<float?>("IMC")
                        .HasColumnType("real");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Perna")
                        .HasColumnType("real");

                    b.Property<float?>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CicloId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Ciclo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlanoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<double?>("ValorPromocional")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PlanoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Ciclos");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Mes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CicloId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DiaPagamento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("CicloId");

                    b.ToTable("Meses");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Plano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuantidadeDias")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Administrador")
                        .HasColumnType("bit");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Aluno", b =>
                {
                    b.HasOne("ControleFinanceiro.Models.Ciclo", "Ciclo")
                        .WithMany()
                        .HasForeignKey("CicloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Ciclo", b =>
                {
                    b.HasOne("ControleFinanceiro.Models.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleFinanceiro.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControleFinanceiro.Models.Mes", b =>
                {
                    b.HasOne("ControleFinanceiro.Models.Aluno", "Aluno")
                        .WithMany("Meses")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleFinanceiro.Models.Ciclo", "Ciclo")
                        .WithMany()
                        .HasForeignKey("CicloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
