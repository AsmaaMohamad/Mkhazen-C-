using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public ICollection<Representative> representatives { get; set; }//

    }
}
