namespace Makhazen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecivePermtionProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        prdct_id = c.Int(nullable: false),
                        recivePermtion_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Prouducts", t => t.prdct_id, cascadeDelete: true)
                .ForeignKey("dbo.ReceivePermissions", t => t.recivePermtion_id, cascadeDelete: true)
                .Index(t => t.prdct_id)
                .Index(t => t.recivePermtion_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecivePermtionProducts", "recivePermtion_id", "dbo.ReceivePermissions");
            DropForeignKey("dbo.RecivePermtionProducts", "prdct_id", "dbo.Prouducts");
            DropIndex("dbo.RecivePermtionProducts", new[] { "recivePermtion_id" });
            DropIndex("dbo.RecivePermtionProducts", new[] { "prdct_id" });
            DropTable("dbo.RecivePermtionProducts");
        }
    }
}
