using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class Suppliers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public double remin { get; set; }
        public ICollection<Receipt_to_suppliers> receipt_To_Suppliers { get; set; }//
        public ICollection<ReturnToSupplier> returnToSuppliers { get; set; }//

    }
}
