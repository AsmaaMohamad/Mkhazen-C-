using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class SalesBill
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public double cost { get; set; }
        public double paid { get; set; }
        public double rmain { get; set; }
        [ForeignKey("RepresentativeBuy")]
        public int Rep_id { get; set; }
        [ForeignKey("Customer")]
        public int cust_id { get; set; }
        public Representative RepresentativeBuy { get; set; }//
        public Customer Customer{ get; set; }//

       // public ICollection<Prouduct> Buyprouduct { get; set; }//

    }
}
