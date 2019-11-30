using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Data.Migrations
{
    public partial class Retirada_tabela_Ciclo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meses_Ciclos_CicloId",
                table: "Meses");

            migrationBuilder.DropTable(
                name: "Ciclos");

            migrationBuilder.DropIndex(
                name: "IX_Meses_CicloId",
                table: "Meses");

            migrationBuilder.DropColumn(
                name: "CicloId",
                table: "Meses");

            migrationBuilder.DropColumn(
                name: "CicloId",
                table: "Alunos");

            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "Planos",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "PlanoId",
                table: "Meses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Meses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ValorPromocional",
                table: "Meses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanoId",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ValorPromocional",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meses_PlanoId",
                table: "Meses",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Meses_ProfessorId",
                table: "Meses",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meses_Planos_PlanoId",
                table: "Meses",
                column: "PlanoId",
                principalTable: "Planos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meses_Professores_ProfessorId",
                table: "Meses",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meses_Planos_PlanoId",
                table: "Meses");

            migrationBuilder.DropForeignKey(
                name: "FK_Meses_Professores_ProfessorId",
                table: "Meses");

            migrationBuilder.DropIndex(
                name: "IX_Meses_PlanoId",
                table: "Meses");

            migrationBuilder.DropIndex(
                name: "IX_Meses_ProfessorId",
                table: "Meses");

            migrationBuilder.DropColumn(
                name: "PlanoId",
                table: "Meses");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Meses");

            migrationBuilder.DropColumn(
                name: "ValorPromocional",
                table: "Meses");

            migrationBuilder.DropColumn(
                name: "PlanoId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "ValorPromocional",
                table: "Alunos");

            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "Planos",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "CicloId",
                table: "Meses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CicloId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ciclos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanoId = table.Column<int>(type: "int", nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    ValorPromocional = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciclos_Planos_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Planos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ciclos_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meses_CicloId",
                table: "Meses",
                column: "CicloId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_PlanoId",
                table: "Ciclos",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_ProfessorId",
                table: "Ciclos",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meses_Ciclos_CicloId",
                table: "Meses",
                column: "CicloId",
                principalTable: "Ciclos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
