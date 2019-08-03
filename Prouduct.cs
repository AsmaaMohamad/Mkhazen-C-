using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
   public class Prouduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
      
        public double wholesalePrice { get; set; }
        public double retrialPrice { get; set; }
        public DateTime expireDate { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("category")]
        public int cat_id { get; set; }
        public Category category { get; set; }
        //public ICollection<Receipt_to_suppliers> Receipt_to_suppliers { get; set; }//
        //public ICollection<ReturnToSupplier> returnToSuppliers { get; set; }//
        //public ICollection<SalesBill> SalesBill { get; set; }//
        //public ICollection<RepresentativeReturnBill> representativeReturnBills { get; set; }
        //  public ICollection<ReceivePermission> receivePermissions { get; set; }//
       // public ICollection<ReceivePermissionProuduct> receivePermissionProuducts { get; set; }

    }
}
