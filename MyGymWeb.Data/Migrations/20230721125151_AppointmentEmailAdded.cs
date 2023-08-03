using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class AppointmentEmailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Appointments");
        }
    }
}
