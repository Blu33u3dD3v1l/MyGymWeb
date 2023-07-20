using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class EntityQuitAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("231e7e18-1e90-4080-a3a0-a298babc7857"));

            migrationBuilder.AddColumn<bool>(
                name: "Quit",
                table: "Applies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quit",
                table: "Applies");

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Moto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[] { new Guid("231e7e18-1e90-4080-a3a0-a298babc7857"), ".\\Images\\Image.Jpg.jpg", "gfgfgfgf", true, "fdsdsf", "Alabala", null, "gfgfgf", 200m, "gfgfgfgff", null });
        }
    }
}
