using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaPediTiscos.Migrations
{
    /// <inheritdoc />
    public partial class updateDB_add_favoritos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_AspNetUsers_ClienteId1",
                table: "Encomendas");

            migrationBuilder.DropIndex(
                name: "IX_Encomendas_ClienteId1",
                table: "Encomendas");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Encomendas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Encomendas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "NIF",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Encomendas_ClienteId",
                table: "Encomendas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Encomendas_AspNetUsers_ClienteId",
                table: "Encomendas",
                column: "ClienteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_AspNetUsers_ClienteId",
                table: "Encomendas");

            migrationBuilder.DropIndex(
                name: "IX_Encomendas_ClienteId",
                table: "Encomendas");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Encomendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteId1",
                table: "Encomendas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "NIF",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Encomendas_ClienteId1",
                table: "Encomendas",
                column: "ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Encomendas_AspNetUsers_ClienteId1",
                table: "Encomendas",
                column: "ClienteId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
