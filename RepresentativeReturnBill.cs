﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makhazen
{
    public class RepresentativeReturnBill
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public Representative RepresentativeReturn { get; set; }
        //public ICollection<Prouduct> Returnprouduct { get; set; }
    }
}