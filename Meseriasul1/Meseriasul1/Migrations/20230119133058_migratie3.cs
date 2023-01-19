using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meseriasul1.Migrations
{
    public partial class migratie3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meserias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meserie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experienta = table.Column<int>(type: "int", nullable: false),
                    ServiciuID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meserias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meserias_Servicii_ServiciuID",
                        column: x => x.ServiciuID,
                        principalTable: "Servicii",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meserias_ServiciuID",
                table: "Meserias",
                column: "ServiciuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meserias");
        }
    }
}
