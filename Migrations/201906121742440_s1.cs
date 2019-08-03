namespace Makhazen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "remin", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "remin");
        }
    }
}
