using Microsoft.EntityFrameworkCore.Migrations;

namespace Kutuphane_Projesi.Migrations
{
    public partial class kitap_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kutuphanes");

            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaskiYili = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.KitapID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.CreateTable(
                name: "Kutuphanes",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaskiYili = table.Column<int>(type: "int", nullable: false),
                    KitapAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphanes", x => x.KitapID);
                });
        }
    }
}
