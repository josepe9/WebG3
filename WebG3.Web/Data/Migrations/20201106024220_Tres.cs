using Microsoft.EntityFrameworkCore.Migrations;

namespace WebG3.Web.Data.Migrations
{
    public partial class Tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Medicos_PersonaId",
                table: "Medicos",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Personas_PersonaId",
                table: "Medicos",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Personas_PersonaId",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_PersonaId",
                table: "Medicos");
        }
    }
}
