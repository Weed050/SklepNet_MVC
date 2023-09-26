using SklepNet_MVC.Data;
using SklepNet_MVC.Models.CMS;
using SklepNet_MVC.Models.Sklep;
using System.Data.Entity;

namespace SklepNet_MVC.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<SklepNetDBContext>
    {
        protected override void Seed(SklepNetDBContext context)
        {
            var aktualnosci = new List<Aktualnosci>
            {
                new Aktualnosci{Tytul = "Tytul aktualnosci 1",Tresc = "Tresc aktualnosci 1",Pozycja = 1},
                new Aktualnosci{Tytul = "Tytul aktualnosci 2",Tresc = "Tresc aktualnosci 2",Pozycja = 2},
                new Aktualnosci{Tytul = "Tytul aktualnosci 3",Tresc = "Tresc aktualnosci 3",Pozycja = 3},
                new Aktualnosci{Tytul = "Tytul aktualnosci 4",Tresc = "Tresc aktualnosci 4",Pozycja = 4},
                new Aktualnosci{Tytul = "Tytul aktualnosci 5",Tresc = "Tresc aktualnosci 5",Pozycja = 5},
            };

            foreach (var a in aktualnosci)
            context.Aktualnosci.Add(a);

            var towary = new List<Towar>
            {
                new Towar { Nazwa = "Towar 1", Opis = "Opis towaru 1", VIPtowar = false, towarPromocyjny = true, Cena = 1 },
               new Towar { Nazwa = "Towar 2", Opis = "Opis towaru 2", VIPtowar = false, towarPromocyjny = true, Cena = 2 },
               new Towar { Nazwa = "Towar 3", Opis = "Opis towaru 3", VIPtowar = false, towarPromocyjny = true, Cena = 3 },
               new Towar { Nazwa = "Towar 4", Opis = "Opis towaru 4", VIPtowar = false, towarPromocyjny = true, Cena = 4 },
               new Towar { Nazwa = "Towar 5", Opis = "Opis towaru 5", VIPtowar = false, towarPromocyjny = true, Cena = 5 },
               new Towar { Nazwa = "Towar 6", Opis = "Opis towaru 6", VIPtowar = false, towarPromocyjny = true, Cena = 6 },
               new Towar { Nazwa = "Towar 7", Opis = "Opis towaru 7", VIPtowar = false, towarPromocyjny = true, Cena = 7 },
               new Towar { Nazwa = "Towar 8", Opis = "Opis towaru 8", VIPtowar = false, towarPromocyjny = true, Cena = 8 },
               new Towar { Nazwa = "Towar 9", Opis = "Opis towaru 9", VIPtowar = false, towarPromocyjny = true, Cena = 9 },
               new Towar { Nazwa = "Towar 10", Opis = "Opis towaru 10", VIPtowar = false, towarPromocyjny = true, Cena = 10 }
            };

            foreach (var t in towary)
                context.Towar.Add(t);

            var towarZdjecia = new List<TowarZdjecie>
 {
             new TowarZdjecie { IdTowar = 1,URL = "/Content/Zdjecia/Zdj1.jpg" },
             new TowarZdjecie { IdTowar = 2,URL = "/Content/Zdjecia/Zdj2.jpg" },
             new TowarZdjecie { IdTowar = 3,URL = "/Content/Zdjecia/Zdj3.jpg" },
             new TowarZdjecie { IdTowar = 4,URL = "/Content/Zdjecia/Zdj4.jpg" },
             new TowarZdjecie { IdTowar = 5,URL = "/Content/Zdjecia/Zdj5.jpg" },

            };

            foreach(var tZ in towarZdjecia)
                context.TowarZdjecie.Add(tZ);

            var towarStany = new List<StanyMagazynowe>
            {
                new StanyMagazynowe {IdTowar = 1,Stan = 10,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 2,Stan = 4,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 3,Stan = 7,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 4,Stan = 10,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 5,Stan = 3,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 6,Stan = 7,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 7,Stan = 19,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 8,Stan = 19,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 9,Stan = 12,DataDodania = DateTime.Now},
                new StanyMagazynowe {IdTowar = 10,Stan = 16,DataDodania = DateTime.Now},
            };

            foreach(var sM in towarStany)
                context.StanyMagazynowe.Add(sM);

        }
    }
}
