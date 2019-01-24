using Microsoft.EntityFrameworkCore.Migrations;

namespace Mfc.Migrations
{
    public partial class CursoForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Trabalho_TrabalhoId",
                table: "Cursos");

            migrationBuilder.AlterColumn<int>(
                name: "TrabalhoId",
                table: "Cursos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Trabalho_TrabalhoId",
                table: "Cursos",
                column: "TrabalhoId",
                principalTable: "Trabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Trabalho_TrabalhoId",
                table: "Cursos");

            migrationBuilder.AlterColumn<int>(
                name: "TrabalhoId",
                table: "Cursos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Trabalho_TrabalhoId",
                table: "Cursos",
                column: "TrabalhoId",
                principalTable: "Trabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
