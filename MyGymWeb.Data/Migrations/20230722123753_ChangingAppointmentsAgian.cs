using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class ChangingAppointmentsAgian : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainer_AspNetUsers_UserId",
                table: "UserTrainer");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainer_Trainers_TrainerId",
                table: "UserTrainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrainer",
                table: "UserTrainer");

            migrationBuilder.RenameTable(
                name: "UserTrainer",
                newName: "UsersTrainers");

            migrationBuilder.RenameIndex(
                name: "IX_UserTrainer_TrainerId",
                table: "UsersTrainers",
                newName: "IX_UsersTrainers_TrainerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentTime",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersTrainers",
                table: "UsersTrainers",
                columns: new[] { "UserId", "TrainerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersTrainers_AspNetUsers_UserId",
                table: "UsersTrainers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersTrainers_Trainers_TrainerId",
                table: "UsersTrainers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersTrainers_AspNetUsers_UserId",
                table: "UsersTrainers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersTrainers_Trainers_TrainerId",
                table: "UsersTrainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersTrainers",
                table: "UsersTrainers");

            migrationBuilder.RenameTable(
                name: "UsersTrainers",
                newName: "UserTrainer");

            migrationBuilder.RenameIndex(
                name: "IX_UsersTrainers_TrainerId",
                table: "UserTrainer",
                newName: "IX_UserTrainer_TrainerId");

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentTime",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrainer",
                table: "UserTrainer",
                columns: new[] { "UserId", "TrainerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainer_AspNetUsers_UserId",
                table: "UserTrainer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainer_Trainers_TrainerId",
                table: "UserTrainer",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
