using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rehber.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RehberKDetails",
                columns: table => new
                {
                    İd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deger = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KisiId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Kaldirma = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RehberKDetails", x => x.İd);
                });

            migrationBuilder.CreateTable(
                name: "RehberKs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Firma = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Kaldirma = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RehberKs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RehberKDetails");

            migrationBuilder.DropTable(
                name: "RehberKs");
        }
    }
}
