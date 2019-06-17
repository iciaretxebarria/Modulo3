using Microsoft.EntityFrameworkCore.Migrations;

namespace EjercicioDepartamentos.Migrations
{
    public partial class Departamentos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Departamento",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Departamento",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);
        }
    }
}
