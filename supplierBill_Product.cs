using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
   public class supplierBill_Product
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("prouduct")]
        public int prdct_id { get; set; }
        public Prouduct prouduct  { get; set; }
        [ForeignKey("receipt_To_Suppliers")]
        public int supBill_id { get; set; }
        public Receipt_to_suppliers receipt_To_Suppliers { get; set; }
        
    }
}
