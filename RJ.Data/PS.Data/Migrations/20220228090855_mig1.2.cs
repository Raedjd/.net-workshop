using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_FK",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "FK",
                table: "Products",
                newName: "CategoryFK");

            migrationBuilder.RenameIndex(
                name: "IX_Products_FK",
                table: "Products",
                newName: "IX_Products_CategoryFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryFK",
                table: "Products",
                column: "CategoryFK",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryFK",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryFK",
                table: "Products",
                newName: "FK");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryFK",
                table: "Products",
                newName: "IX_Products_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_FK",
                table: "Products",
                column: "FK",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
