using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaPediTiscos.Migrations
{
    /// <inheritdoc />
    public partial class update_ordem_subcategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ordem",
                table: "SubCategorias",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordem",
                table: "SubCategorias");
        }
    }
}
