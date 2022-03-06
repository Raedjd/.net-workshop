using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class mig16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.RenameTable(
                name: "Providers",
                newName: "Fournisseur");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Fournisseur",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fournisseur",
                table: "Fournisseur",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Fournisseur_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Fournisseur_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fournisseur",
                table: "Fournisseur");

            migrationBuilder.RenameTable(
                name: "Fournisseur",
                newName: "Providers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Providers",
                newName: "UserName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
