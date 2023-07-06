using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class CascadeDeleteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gyms_Trainers_TrainerId",
                table: "Gyms");

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_Trainers_TrainerId",
                table: "Gyms",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gyms_Trainers_TrainerId",
                table: "Gyms");

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_Trainers_TrainerId",
                table: "Gyms",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id");
        }
    }
}
