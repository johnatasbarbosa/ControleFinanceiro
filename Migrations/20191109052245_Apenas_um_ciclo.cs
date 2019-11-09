using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Migrations
{
    public partial class Apenas_um_ciclo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciclos_Alunos_AlunoId",
                table: "Ciclos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ciclos_Professores_ProfessorId",
                table: "Ciclos");

            migrationBuilder.DropIndex(
                name: "IX_Ciclos_AlunoId",
                table: "Ciclos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Ciclos");

            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "Ciclos");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Ciclos");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Ciclos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CicloId",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CicloId",
                table: "Alunos",
                column: "CicloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Ciclos_CicloId",
                table: "Alunos",
                column: "CicloId",
                principalTable: "Ciclos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ciclos_Professores_ProfessorId",
                table: "Ciclos",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Ciclos_CicloId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ciclos_Professores_ProfessorId",
                table: "Ciclos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CicloId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "CicloId",
                table: "Alunos");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Ciclos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Ciclos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFinal",
                table: "Ciclos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Ciclos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_AlunoId",
                table: "Ciclos",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciclos_Alunos_AlunoId",
                table: "Ciclos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ciclos_Professores_ProfessorId",
                table: "Ciclos",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
