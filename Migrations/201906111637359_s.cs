namespace Makhazen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prouducts", "SalesBill_ID", "dbo.SalesBills");
            DropIndex("dbo.Prouducts", new[] { "SalesBill_ID" });
            DropColumn("dbo.Prouducts", "SalesBill_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prouducts", "SalesBill_ID", c => c.Int());
            CreateIndex("dbo.Prouducts", "SalesBill_ID");
            AddForeignKey("dbo.Prouducts", "SalesBill_ID", "dbo.SalesBills", "ID");
        }
    }
}
