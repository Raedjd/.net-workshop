using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryFK",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryFK",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryFK",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "FK",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FK",
                table: "Products",
                column: "FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_FK",
                table: "Products",
                column: "FK",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_FK",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FK",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FK",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategoryFK",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryFK",
                table: "Products",
                column: "CategoryFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryFK",
                table: "Products",
                column: "CategoryFK",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
