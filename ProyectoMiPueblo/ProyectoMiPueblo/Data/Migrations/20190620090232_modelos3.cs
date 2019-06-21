using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoMiPueblo.Data.Migrations
{
    public partial class modelos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estancia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnfitrionId = table.Column<int>(nullable: false),
                    Duracion = table.Column<int>(nullable: false),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estancia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Huesped",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huesped", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Huesped_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anfitriones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    Pueblo = table.Column<string>(maxLength: 50, nullable: false),
                    EstanciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anfitriones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anfitriones_Estancia_EstanciaId",
                        column: x => x.EstanciaId,
                        principalTable: "Estancia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anfitriones_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstanciaHuesped",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstanciaId = table.Column<int>(nullable: false),
                    HuespedId = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstanciaHuesped", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstanciaHuesped_Estancia_EstanciaId",
                        column: x => x.EstanciaId,
                        principalTable: "Estancia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstanciaHuesped_Huesped_HuespedId",
                        column: x => x.HuespedId,
                        principalTable: "Huesped",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anfitriones_EstanciaId",
                table: "Anfitriones",
                column: "EstanciaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Anfitriones_UserId",
                table: "Anfitriones",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EstanciaHuesped_EstanciaId",
                table: "EstanciaHuesped",
                column: "EstanciaId");

            migrationBuilder.CreateIndex(
                name: "IX_EstanciaHuesped_HuespedId",
                table: "EstanciaHuesped",
                column: "HuespedId");

            migrationBuilder.CreateIndex(
                name: "IX_Huesped_UserId",
                table: "Huesped",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anfitriones");

            migrationBuilder.DropTable(
                name: "EstanciaHuesped");

            migrationBuilder.DropTable(
                name: "Estancia");

            migrationBuilder.DropTable(
                name: "Huesped");
        }
    }
}
