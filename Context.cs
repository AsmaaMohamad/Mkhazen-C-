using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class Context:DbContext
    {
        public Context() :
          //  base(@"Data Source=DESKTOP-0C7CV2F\MSSQL14.MSSQLSERVER;Initial Catalog=Makhazen;Integrated Security=True")
          base(@"Data Source=DESKTOP-BTH87SL\SQL2017EXPRESS;Initial Catalog=Makhazen;Integrated Security=True")
        {

        }
        public DbSet<Suppliers>Supplier { get; set; }
        public DbSet<Representative> Representative { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Prouduct> prouduct { get; set; }
        public DbSet<Receipt_to_suppliers> receipt_To_Suppliers { get; set; }
        public DbSet<ReturnToSupplier> ReturnToSupplier { get; set; }
        public DbSet<SalesBill> sellBill { get; set; }
        public DbSet<supplierBill_Product>supplierBill_Products{ get; set; }
        public DbSet<SalesBill_Product>SalesBill_Products { get; set; }
        public DbSet<RepresentativeReturnBill_Product> RepresentativeReturnBill_Products{ get; set; }
        public DbSet<RepresentativeReturnBill> RepresentativeReturnBills { get; set; }
        public DbSet<ReceivePermission> receivePermissions { get; set; }
        public DbSet<ReturnToSupllier_Product>returnToSupllier_Products { get; set; }
        public DbSet<RecivePermtionProduct> recivePermtionProducts { get; set; }
        //  public DbSet<CustomerBuyBill> CustomerBuyBill { get; set; }
        //  public DbSet<CustomerRuternBill> CustomerRuternBill { get; set; }

        public DbSet<Users> user { get; set; }







    }
}
