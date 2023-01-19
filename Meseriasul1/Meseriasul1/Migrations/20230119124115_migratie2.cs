using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meseriasul1.Migrations
{
    public partial class migratie2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramareID",
                table: "Servicii",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Programare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dataprogramarii = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programare", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicii_ProgramareID",
                table: "Servicii",
                column: "ProgramareID");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicii_Programare_ProgramareID",
                table: "Servicii",
                column: "ProgramareID",
                principalTable: "Programare",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicii_Programare_ProgramareID",
                table: "Servicii");

            migrationBuilder.DropTable(
                name: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Servicii_ProgramareID",
                table: "Servicii");

            migrationBuilder.DropColumn(
                name: "ProgramareID",
                table: "Servicii");
        }
    }
}
