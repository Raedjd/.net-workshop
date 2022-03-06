namespace RJ.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TP_ANNOTAIONS : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Providers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Providers", "Pwd", c => c.String(nullable: false));
            DropColumn("dbo.Providers", "ConfPwd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Providers", "ConfPwd", c => c.String());
            AlterColumn("dbo.Providers", "Pwd", c => c.String());
            AlterColumn("dbo.Providers", "Email", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
