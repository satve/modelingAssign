using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modeling.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public string Color { get; set; }
    }
}