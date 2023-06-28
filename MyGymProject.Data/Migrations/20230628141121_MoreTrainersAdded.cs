using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class MoreTrainersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "CLassicTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "CLassicTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "CLassicTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "CLassicTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "CLassicTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Type",
                value: "CLassicTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Type",
                value: "BoxingTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Type",
                value: "BoxingTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Type",
                value: "BoxingTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Type",
                value: "BoxingTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Type",
                value: "BoxingTrainer");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Type",
                value: "BoxingTrainer");

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "GymId", "ImageUrl", "Info", "Moto", "Name", "Practis", "PricePerHour", "Type" },
                values: new object[,]
                {
                    { 13, null, "https://fitnessgalore.net/wp-content/uploads/2013/12/kristenmcgeetodaynew-1050x1575.jpg", "Kristin McGee is an American fitness instructor and yogi who launched Peloton Interactive yoga classes.She is a mom of three boys and a fitness influencer who advocates for the benefits of movement.", "Go For It", "Kristin McGee", "Practis Above 7 Years", 100m, "YogaTrainer" },
                    { 14, null, "https://res.cloudinary.com/fleetnation/image/private/c_fit,w_1120/fl_no_overflow,g_south,l_text:style_gothic2:%C2%A9%20Imagerisium,o_20,y_10/fl_no_overflow,g_center,l_watermark4,o_25,y_50/v1471521586/qub6twmyw0o4b2gjdxyf.jpg", "Eugenie Peterson, known as Indra Devi, is a pioneering teacher of yoga as exercise, and an early disciple of the father of modern yoga.She went to India in her twenties, becoming a film star there and acquiring the stage name Indra Devi. She was the first woman to study under the yoga guru Krishnamacharya at the Mysore Palace, alongside B.K.S Iyengar and K. Pattabhi Jois who went on to become yoga gurus. Moving to China, she taught the first yoga classes in that country at Madame Chiang Kai-shek's house.", "Dream", "Indra Devi", "Practis Above 7 Years", 100m, "YogaTrainer" },
                    { 15, null, "https://i0.wp.com/ideamensch.com/wp-content/uploads/2021/02/brett-larkin-e1613526716771.jpg", "Brett Larkin is a Youtube Star, Pilates and Yoga instructor who rose to fame for her at-home, beginner-friendly vinyasa flow and meditation courses she posts to her YouTube channel, where she has amassed a following of 500,000 subscribers. The focus of her channel is to make yoga more accessible to everyone. She also offers a yoga instructor training online course. Born on July 24, , Brett Larkin hails from , United States. As in 2023, Brett Larkin's age is N/A. Check below for more deets about Brett Larkin. This page will put a light upon the Brett Larkin bio, wiki, age, birthday, family details, affairs, controversies, caste, height, weight, rumors, lesser-known facts, and more", "Dream", "Bett Larkin", "Practis Above 5 Years", 100m, "PilatesTrainer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Trainers");
        }
    }
}
