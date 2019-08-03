using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
   public class ReceivePermission
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
      

        [ForeignKey("representative")]
        public int rep_id { get; set; }

        public Representative representative { get; set; }
       
         //public ICollection<Prouduct> prouducts { get; set; }
    }
}
