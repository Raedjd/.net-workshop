namespace RJ.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adrProp : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Chemical", name: "Adresse_StreetAddress", newName: "street");
            AlterColumn("dbo.Chemical", "street", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chemical", "street", c => c.String());
            RenameColumn(table: "dbo.Chemical", name: "street", newName: "Adresse_StreetAddress");
        }
    }
}
