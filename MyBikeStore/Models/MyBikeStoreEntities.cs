using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MyBikeStore.Models
{
    public class MyBikeStoreEntities : DbContext
    {
        [Key]
        public DbSet<Velosiped> Velosipedi { get; set; }
        public DbSet<Kategorija> Kategorii { get; set; }
    }
}