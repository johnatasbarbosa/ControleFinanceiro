using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DiaPagamento = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Braco = table.Column<float>(nullable: false),
                    Abs = table.Column<float>(nullable: false),
                    Gluteo = table.Column<float>(nullable: false),
                    Perna = table.Column<float>(nullable: false),
                    IMC = table.Column<float>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeDias = table.Column<int>(nullable: false),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Administrador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    Pago = table.Column<bool>(nullable: false),
                    DiaPagamento = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false),
                    CicloId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meses_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciclos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanoId = table.Column<int>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: false),
                    ValorPromocional = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciclos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ciclos_Planos_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Planos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ciclos_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_AlunoId",
                table: "Ciclos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_PlanoId",
                table: "Ciclos",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_ProfessorId",
                table: "Ciclos",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Meses_AlunoId",
                table: "Meses",
                column: "AlunoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciclos");

            migrationBuilder.DropTable(
                name: "Meses");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Planos");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
