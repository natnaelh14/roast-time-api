using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoastTime.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaturants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaturants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Restaturants",
                columns: new[] { "Id", "Address", "Category", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "918 Silver Spring Ave, Silver Spring, MD 20910", "Coffee Shop", 38.997700000000002, -77.030600000000007, "Kaldis Coffee" },
                    { new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"), "8240 Fenton St, Silver Spring, MD 20910", "Coffee Shop", 38.997700000000002, -77.030600000000007, "Black Lion" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaturants");
        }
    }
}
