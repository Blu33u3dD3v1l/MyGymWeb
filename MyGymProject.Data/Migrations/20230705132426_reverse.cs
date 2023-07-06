using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class reverse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("de2f3c98-2c0b-4def-b8e2-6e0ddef45663"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "Moto", "Name", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[] { new Guid("de2f3c98-2c0b-4def-b8e2-6e0ddef45663"), ".\\Images\\Image.Jpg.jpg", "gfgfgfgf", "fdsdsf", "Alabala", "gfgfgf", 200m, "gfgfgfgff", null });
        }
    }
}
