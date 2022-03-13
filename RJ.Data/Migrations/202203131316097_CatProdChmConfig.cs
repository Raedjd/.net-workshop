namespace RJ.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatProdChmConfig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Product");
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            AlterColumn("dbo.MyCategories", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
            RenameTable(name: "dbo.Product", newName: "Products");
        }
    }
}
