using Microsoft.EntityFrameworkCore.Migrations;

namespace ESXSol.Migrations
{
    public partial class Marca_ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marca_Patrimonio_PatrimonioId",
                table: "Marca");

            migrationBuilder.DropIndex(
                name: "IX_Marca_PatrimonioId",
                table: "Marca");

            migrationBuilder.DropColumn(
                name: "PatrimonioId",
                table: "Marca");

            migrationBuilder.CreateIndex(
                name: "IX_Patrimonio_MarcaId",
                table: "Patrimonio",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrimonio_Marca_MarcaId",
                table: "Patrimonio",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrimonio_Marca_MarcaId",
                table: "Patrimonio");

            migrationBuilder.DropIndex(
                name: "IX_Patrimonio_MarcaId",
                table: "Patrimonio");

            migrationBuilder.AddColumn<int>(
                name: "PatrimonioId",
                table: "Marca",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marca_PatrimonioId",
                table: "Marca",
                column: "PatrimonioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marca_Patrimonio_PatrimonioId",
                table: "Marca",
                column: "PatrimonioId",
                principalTable: "Patrimonio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
