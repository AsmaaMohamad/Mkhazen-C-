namespace Makhazen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prouducts", "expireDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Prouducts", "expireDate");
        }
    }
}
