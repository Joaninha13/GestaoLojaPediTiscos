using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaPediTiscos.Migrations
{
    /// <inheritdoc />
    public partial class DBUpdate_Produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ModoDispo_ModoDispoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Promocoes_PromocoesId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ModoDispId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "PromocaoId",
                table: "Produtos",
                newName: "NVendas");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativa",
                table: "Promocoes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PromocoesId",
                table: "Produtos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ModoDispoId",
                table: "Produtos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Disponivel",
                table: "Produtos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ModoDispo_ModoDispoId",
                table: "Produtos",
                column: "ModoDispoId",
                principalTable: "ModoDispo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Promocoes_PromocoesId",
                table: "Produtos",
                column: "PromocoesId",
                principalTable: "Promocoes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ModoDispo_ModoDispoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Promocoes_PromocoesId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "NVendas",
                table: "Produtos",
                newName: "PromocaoId");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativa",
                table: "Promocoes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "PromocoesId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModoDispoId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Disponivel",
                table: "Produtos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "ModoDispId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ModoDispo_ModoDispoId",
                table: "Produtos",
                column: "ModoDispoId",
                principalTable: "ModoDispo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Promocoes_PromocoesId",
                table: "Produtos",
                column: "PromocoesId",
                principalTable: "Promocoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
