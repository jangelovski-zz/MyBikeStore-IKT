using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyBikeStore.Models
{
    public class InitialData : DropCreateDatabaseIfModelChanges<MyBikeStoreEntities>
    {
        protected override void Seed(MyBikeStoreEntities context)
        {
            var kategorii = new List<Kategorija>
            {
                new Kategorija { Ime_na_kategorija = "Спортски" },
                new Kategorija { Ime_na_kategorija = "Класични" },
                new Kategorija { Ime_na_kategorija = "Екстремни" },
                new Kategorija { Ime_na_kategorija = "BMX" },
                new Kategorija { Ime_na_kategorija = "Планински" },
                new Kategorija { Ime_na_kategorija = "Тандем велосипеди" },
                new Kategorija { Ime_na_kategorija = "Детски" }

            };

            var proizvoditeli = new List<Proizvoditel>
            {
                new Proizvoditel {Ime_na_proizvoditel = "Giant" },
                new Proizvoditel {Ime_na_proizvoditel = "Trek" },
                new Proizvoditel {Ime_na_proizvoditel = "Intense" },
                new Proizvoditel {Ime_na_proizvoditel = "Scott" },
                new Proizvoditel {Ime_na_proizvoditel = "KTM" },
                new Proizvoditel {Ime_na_proizvoditel = "Kona" },
                new Proizvoditel {Ime_na_proizvoditel = "Merida" },
                new Proizvoditel {Ime_na_proizvoditel = "Bianchi" },
                new Proizvoditel {Ime_na_proizvoditel = "Schwinn" },
                new Proizvoditel {Ime_na_proizvoditel = "Fuji" },
                new Proizvoditel {Ime_na_proizvoditel = "Sobim" },
                new Proizvoditel {Ime_na_proizvoditel = "Genesis" },
            };

            new List<Velosiped>
            {
                new Velosiped
                {
                    Ime = "Émonda SLR 9",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Trek"),
                    Cena = 20000,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "Émonda SLR 9 Women's",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Trek"),
                    Cena = 20000,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "Émonda SLR 10",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Trek"),
                    Cena = 11999,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "Émonda SLR 8 (H1 fit)",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Trek"),
                    Cena = 8000,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "FastRoad CoMax",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Класични"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Giant"),
                    Cena = 3000,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "Defy Advanced SL",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Giant"),
                    Cena = 6200,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "MACINA Moto Street 11 P5 45",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Класични"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "KTM"),
                    Cena = 9800,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "VENTURA Cross 9",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "KTM"),
                    Cena = 12100,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "AMPARO XL 8-RT 28 648",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Спортски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "KTM"),
                    Cena = 11200,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "E RACE P 27.5",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Екстремни"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "KTM"),
                    Cena = 10999,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "M16C",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Екстремни"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Intense"),
                    Cena = 18900,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                },
                new Velosiped
                {
                    Ime = "Amplify",
                    Kategorija = kategorii.Single(kat => kat.Ime_na_kategorija == "Детски"),
                    Proizvoditel = proizvoditeli.Single(pr => pr.Ime_na_proizvoditel == "Giant"),
                    Cena = 2900,
                    VelosipedURL = "/Content/Images/placeholder.gif"
                }
            }.ForEach(pr => context.Velosipedi.Add(pr));
        }
    }
}