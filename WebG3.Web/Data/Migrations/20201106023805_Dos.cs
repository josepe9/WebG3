using Microsoft.EntityFrameworkCore.Migrations;

namespace WebG3.Web.Data.Migrations
{
    public partial class Dos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Personas",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 45);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Direccion",
                table: "Personas",
                type: "int",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 45);
        }
    }
}
