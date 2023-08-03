using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class GeneralExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProduct_AspNetUsers_userId",
                table: "UserProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProduct_Products_productId",
                table: "UserProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProduct",
                table: "UserProduct");

            migrationBuilder.RenameTable(
                name: "UserProduct",
                newName: "UsersProducts");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "UsersProducts",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UsersProducts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProduct_productId",
                table: "UsersProducts",
                newName: "IX_UsersProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersProducts",
                table: "UsersProducts",
                columns: new[] { "UserId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersProducts_AspNetUsers_UserId",
                table: "UsersProducts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersProducts_Products_ProductId",
                table: "UsersProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersProducts_AspNetUsers_UserId",
                table: "UsersProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersProducts_Products_ProductId",
                table: "UsersProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersProducts",
                table: "UsersProducts");

            migrationBuilder.RenameTable(
                name: "UsersProducts",
                newName: "UserProduct");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "UserProduct",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserProduct",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersProducts_ProductId",
                table: "UserProduct",
                newName: "IX_UserProduct_productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProduct",
                table: "UserProduct",
                columns: new[] { "userId", "productId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserProduct_AspNetUsers_userId",
                table: "UserProduct",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProduct_Products_productId",
                table: "UserProduct",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
