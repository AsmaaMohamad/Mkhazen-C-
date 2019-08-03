using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
   public class RepresentativeReturnBill_Product
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("prouduct")]
        public int prdct_id { get; set; }
        public Prouduct prouduct { get; set; }
        [ForeignKey("representativeReturnBill")]
        public int rep_ReturnBill_id { get; set; }
        public RepresentativeReturnBill representativeReturnBill { get; set; }
    }
}
