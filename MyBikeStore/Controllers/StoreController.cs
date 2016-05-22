using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBikeStore.Models;

namespace MyBikeStore.Controllers
{
    public class StoreController : Controller
    {
        MyBikeStoreEntities storeDB = new MyBikeStoreEntities();
        
        // GET: /Store/
        public ActionResult Index()
        {
            var kategorii = storeDB.Kategorii.ToList();

            return View(kategorii);
        }

        // GET: /Store/Browse
        public ActionResult Browse(string kategorija)
        {
            var kategorijaModel = storeDB.Kategorii.Include("Velosipedi").Single(k => k.Ime_na_kategorija == kategorija);
            return View(kategorijaModel);
        }

        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var velosiped = storeDB.Velosipedi.Find(id);
            
            return View(velosiped);
        }
    }
}