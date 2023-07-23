using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class AppointmentTrainerIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TrainerId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TrainerId",
                table: "Appointments",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Trainers_TrainerId",
                table: "Appointments",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Trainers_TrainerId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_TrainerId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Appointments");
        }
    }
}
