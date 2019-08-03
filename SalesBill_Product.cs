﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
   public class SalesBill_Product
    {
        public int ID { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("prouduct")]
        public int prdct_id { get; set; }
        public Prouduct prouduct { get; set; }
        [ForeignKey("salesBill")]
        public int salesBill_id { get; set; }
        public SalesBill salesBill { get; set; }
    }

}
