using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkTest.Repo.Migrations
{
    public partial class TipoAlteradoTipoEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeEndereco",
                table: "Enderecos",
                newName: "TipoEndereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoEndereco",
                table: "Enderecos",
                newName: "NomeEndereco");
        }
    }
}
