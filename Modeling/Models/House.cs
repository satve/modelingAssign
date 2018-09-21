using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modeling.Models
{
    public class House
    {
        public int Value { get; set; }
        public string LotSize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }

    }
}