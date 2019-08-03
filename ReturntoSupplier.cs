using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class ReturnToSupplier
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public double cost { get; set; }
        public double paid { get; set; }
        public double rmain { get; set; }
        [ForeignKey("returnSuppliers")]
        public int Sup_id { get; set; }
        public Suppliers returnSuppliers { get; set; }//
        //public ICollection<Prouduct> Returnprouduct { get; set; }//
    }
}
