using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class Representative
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public ICollection<SalesBill> SalesBill { get; set; }//
        public ICollection<ReceivePermission> ReceivePermission { get; set; }//
        public ICollection<RepresentativeReturnBill> representativeReturnBills { get; set; }
        public ICollection<Customer> customers { get; set; }//
    }
}
