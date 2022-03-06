using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class mig19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Fournisseur_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Products_ProductsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Providings");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "MyCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ProvidersId",
                table: "Providings",
                newName: "IX_Providings_ProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providings",
                table: "Providings",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "MyCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Fournisseur_ProvidersId",
                table: "Providings",
                column: "ProvidersId",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Products_ProductsProductId",
                table: "Providings",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Fournisseur_ProvidersId",
                table: "Providings");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Products_ProductsProductId",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providings",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories");

            migrationBuilder.RenameTable(
                name: "Providings",
                newName: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "MyCategories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Providings_ProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Fournisseur_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Products_ProductsProductId",
                table: "ProductProvider",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
