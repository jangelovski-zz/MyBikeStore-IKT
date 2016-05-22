using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBikeStore.Models
{
    public class Kategorija
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int KategorijaID { get; set; }
        public string Ime_na_kategorija { get; set; }
        public string OpisKat { get; set; }
        public List<Velosiped> Velosipedi { get; set; }
    }
}