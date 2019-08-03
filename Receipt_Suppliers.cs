using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class Receipt_to_suppliers
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public double cost { get; set; }
        public double paid { get; set; }
        public double rmain { get; set; }

        [ForeignKey("buySuppliers")]
        public int sup_id { get; set; }

        public Suppliers buySuppliers { get; set; }
        //public ICollection<Prouduct> Buyprouduct { get; set; }

    }
}
