using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBikeStore.Models
{
    public class Proizvoditel
    {
        [Key]
        public string Ime_na_proizvoditel { get; set; }
        public Kategorija kategorija { get; set; }
    }
}