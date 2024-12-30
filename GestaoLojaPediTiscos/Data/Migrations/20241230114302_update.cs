using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaPediTiscos.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoritos_Produtos_ProdutoId1",
                table: "Favoritos");

            migrationBuilder.DropIndex(
                name: "IX_Favoritos_ProdutoId1",
                table: "Favoritos");

            migrationBuilder.DropColumn(
                name: "ProdutoId1",
                table: "Favoritos");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Favoritos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_ProdutoId",
                table: "Favoritos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoritos_Produtos_ProdutoId",
                table: "Favoritos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoritos_Produtos_ProdutoId",
                table: "Favoritos");

            migrationBuilder.DropIndex(
                name: "IX_Favoritos_ProdutoId",
                table: "Favoritos");

            migrationBuilder.AlterColumn<string>(
                name: "ProdutoId",
                table: "Favoritos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId1",
                table: "Favoritos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_ProdutoId1",
                table: "Favoritos",
                column: "ProdutoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoritos_Produtos_ProdutoId1",
                table: "Favoritos",
                column: "ProdutoId1",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
