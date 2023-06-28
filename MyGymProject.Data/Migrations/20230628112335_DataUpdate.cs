using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class DataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://rare-gallery.com/uploads/posts/585296-adult-barbell.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQnt7cNQqkpsp8fnIxvd5p_isrMs_NLaioC1-2Z5vn7XQ&s");
        }
    }
}
