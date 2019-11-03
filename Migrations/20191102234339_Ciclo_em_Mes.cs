using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Migrations
{
    public partial class Ciclo_em_Mes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Meses_CicloId",
                table: "Meses",
                column: "CicloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meses_Ciclos_CicloId",
                table: "Meses",
                column: "CicloId",
                principalTable: "Ciclos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meses_Ciclos_CicloId",
                table: "Meses");

            migrationBuilder.DropIndex(
                name: "IX_Meses_CicloId",
                table: "Meses");
        }
    }
}
