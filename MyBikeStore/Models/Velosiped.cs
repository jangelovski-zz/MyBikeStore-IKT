using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBikeStore.Models
{
    public class Velosiped
    {
        public int VelosipedID { get; set; }
        public Proizvoditel Proizvoditel { get; set; }
        public Kategorija Kategorija { get; set; }
        public string Ime { get; set; }
        public decimal Cena { get; set; }
        public string VelosipedURL { get; set; }
    }
}