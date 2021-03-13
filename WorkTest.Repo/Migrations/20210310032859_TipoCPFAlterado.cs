using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkTest.Repo.Migrations
{
    public partial class TipoCPFAlterado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                table: "Clientes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
