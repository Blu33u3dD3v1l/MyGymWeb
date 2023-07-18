using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class RemovedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_AspNetUsers_GetTrainerId",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_GetTrainerId",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "GetTrainerId",
                table: "Trainers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GetTrainerId",
                table: "Trainers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_GetTrainerId",
                table: "Trainers",
                column: "GetTrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_AspNetUsers_GetTrainerId",
                table: "Trainers",
                column: "GetTrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
