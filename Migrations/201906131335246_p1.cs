namespace Makhazen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReceivePermissions", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.ReceivePermissions", "cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReceivePermissions", "cost", c => c.Double(nullable: false));
            DropColumn("dbo.ReceivePermissions", "Quantity");
        }
    }
}
