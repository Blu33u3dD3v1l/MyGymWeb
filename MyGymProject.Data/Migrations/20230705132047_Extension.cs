using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class Extension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("94b95079-9873-4e30-90df-43e93df2f629"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "Moto", "Name", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[] { new Guid("94b95079-9873-4e30-90df-43e93df2f629"), "C:\\Users\\UEFI\\source\\repos\\MyGymWeb\\MyGymWeb.Infrastructure\\Extensions\\d5c3dad529dff7caad63ae899c7af0e9.jpg", "fdfdfdfdfdf", "fdsfsfsfsffs", "Arnold", "fdfdfdfffd", 200m, "dfdfdfdfdfddf", null });
        }
    }
}
