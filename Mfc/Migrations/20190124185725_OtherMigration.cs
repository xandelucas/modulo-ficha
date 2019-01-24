using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mfc.Migrations
{
    public partial class OtherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trabalho",
                table: "Cursos");

            migrationBuilder.AddColumn<int>(
                name: "TrabalhoId",
                table: "Cursos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Trabalho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTrabalho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabalho", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_TrabalhoId",
                table: "Cursos",
                column: "TrabalhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Trabalho_TrabalhoId",
                table: "Cursos",
                column: "TrabalhoId",
                principalTable: "Trabalho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Trabalho_TrabalhoId",
                table: "Cursos");

            migrationBuilder.DropTable(
                name: "Trabalho");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_TrabalhoId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "TrabalhoId",
                table: "Cursos");

            migrationBuilder.AddColumn<int>(
                name: "Trabalho",
                table: "Cursos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
