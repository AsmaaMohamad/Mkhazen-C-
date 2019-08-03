namespace Makhazen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CustomerRepresentatives", newName: "RepresentativeCustomers");
            DropForeignKey("dbo.ReceivePermissionProuducts", "ReceivePermission_ID", "dbo.ReceivePermissions");
            DropForeignKey("dbo.ReceivePermissionProuducts", "Prouduct_ID", "dbo.Prouducts");
            DropIndex("dbo.ReceivePermissionProuducts", new[] { "ReceivePermission_ID" });
            DropIndex("dbo.ReceivePermissionProuducts", new[] { "Prouduct_ID" });
            DropPrimaryKey("dbo.RepresentativeCustomers");
            AddPrimaryKey("dbo.RepresentativeCustomers", new[] { "Representative_ID", "Customer_ID" });
            DropColumn("dbo.ReceivePermissions", "Quantity");
            DropTable("dbo.ReceivePermissionProuducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReceivePermissionProuducts",
                c => new
                    {
                        ReceivePermission_ID = c.Int(nullable: false),
                        Prouduct_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReceivePermission_ID, t.Prouduct_ID });
            
            AddColumn("dbo.ReceivePermissions", "Quantity", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.RepresentativeCustomers");
            AddPrimaryKey("dbo.RepresentativeCustomers", new[] { "Customer_ID", "Representative_ID" });
            CreateIndex("dbo.ReceivePermissionProuducts", "Prouduct_ID");
            CreateIndex("dbo.ReceivePermissionProuducts", "ReceivePermission_ID");
            AddForeignKey("dbo.ReceivePermissionProuducts", "Prouduct_ID", "dbo.Prouducts", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ReceivePermissionProuducts", "ReceivePermission_ID", "dbo.ReceivePermissions", "ID", cascadeDelete: true);
            RenameTable(name: "dbo.RepresentativeCustomers", newName: "CustomerRepresentatives");
        }
    }
}
