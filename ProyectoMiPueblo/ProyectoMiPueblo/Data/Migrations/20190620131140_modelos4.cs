using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoMiPueblo.Data.Migrations
{
    public partial class modelos4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anfitriones_Estancia_EstanciaId",
                table: "Anfitriones");

            migrationBuilder.DropIndex(
                name: "IX_Anfitriones_EstanciaId",
                table: "Anfitriones");

            migrationBuilder.DropColumn(
                name: "EstanciaId",
                table: "Anfitriones");

            migrationBuilder.CreateIndex(
                name: "IX_Estancia_AnfitrionId",
                table: "Estancia",
                column: "AnfitrionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estancia_Anfitriones_AnfitrionId",
                table: "Estancia",
                column: "AnfitrionId",
                principalTable: "Anfitriones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estancia_Anfitriones_AnfitrionId",
                table: "Estancia");

            migrationBuilder.DropIndex(
                name: "IX_Estancia_AnfitrionId",
                table: "Estancia");

            migrationBuilder.AddColumn<int>(
                name: "EstanciaId",
                table: "Anfitriones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Anfitriones_EstanciaId",
                table: "Anfitriones",
                column: "EstanciaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Anfitriones_Estancia_EstanciaId",
                table: "Anfitriones",
                column: "EstanciaId",
                principalTable: "Estancia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
