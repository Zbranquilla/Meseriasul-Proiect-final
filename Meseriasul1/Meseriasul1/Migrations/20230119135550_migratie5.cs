using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meseriasul1.Migrations
{
    public partial class migratie5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramareID",
                table: "Meserias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meserias_ProgramareID",
                table: "Meserias",
                column: "ProgramareID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meserias_Programare_ProgramareID",
                table: "Meserias",
                column: "ProgramareID",
                principalTable: "Programare",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meserias_Programare_ProgramareID",
                table: "Meserias");

            migrationBuilder.DropIndex(
                name: "IX_Meserias_ProgramareID",
                table: "Meserias");

            migrationBuilder.DropColumn(
                name: "ProgramareID",
                table: "Meserias");
        }
    }
}
