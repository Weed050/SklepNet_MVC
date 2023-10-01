using Microsoft.EntityFrameworkCore;
using SklepNet_MVC.Data;
using SklepNet_MVC.Models.CMS;
using SklepNet_MVC.Models.Sklep;

namespace SklepNet_MVC.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SklepNetDBContext(serviceProvider.GetRequiredService<DbContextOptions<SklepNetDBContext>>()))
            {
                context.Database.EnsureCreated();
                // If you miss 14 line and you don't have DB ready structure, you're fucked, because it will create empty DB and it won't fill it with data

                if (!context.Aktualnosci.Any())
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
                        context.Aktualnosci.AddRange(a);
                    context.SaveChanges();
                }
                if (!context.Towar.Any())
                {
                    var towary = new List<Towar>
                    {
                        new Towar { Nazwa = "Towar 1", Opis = "Opis towaru 1", VIPtowar = false, towarPromocyjny = true, Cena = 1 },
                       new Towar { Nazwa = "Towar 2", Opis = "Opis towaru 2", VIPtowar = false, towarPromocyjny = true, Cena = 2 },
                       new Towar { Nazwa = "Towar 3", Opis = "Opis towaru 3", VIPtowar = false, towarPromocyjny = true, Cena = 3 },
                       new Towar { Nazwa = "Towar 4", Opis = "Opis towaru 4", VIPtowar = false, towarPromocyjny = true, Cena = 4 },
                       new Towar { Nazwa = "Towar 5", Opis = "Opis towaru 5", VIPtowar = false, towarPromocyjny = true, Cena = 5 },
                    };

                    foreach (var t in towary)
                        context.Towar.AddRange(t);
                    context.SaveChanges();
                }

                if (!context.TowarZdjecie.Any())
                {
                    var towarZdjecia = new List<TowarZdjecie>
                    {

                     new TowarZdjecie { TowarID = 1,URL = "/Content/Zdjecia/Zdj1.jpg" },
                     new TowarZdjecie { TowarID = 2,URL = "/Content/Zdjecia/Zdj2.jpg" },
                     new TowarZdjecie { TowarID = 3,URL = "/Content/Zdjecia/Zdj3.jpg" },
                     new TowarZdjecie { TowarID = 4,URL = "/Content/Zdjecia/Zdj4.jpg" },
                     new TowarZdjecie { TowarID = 5,URL = "/Content/Zdjecia/Zdj5.jpg" },
                    };
                    foreach (var tZ in towarZdjecia)
                        context.TowarZdjecie.AddRange(tZ);
                    context.SaveChanges();
                }



                if (!context.StanyMagazynowe.Any())
                {
                    var towarStany = new List<StanyMagazynowe>
                    {
                        new StanyMagazynowe {TowarID = 1,Stan = 10,DataDodania = DateTime.Now},
                        new StanyMagazynowe {TowarID = 2,Stan = 4,DataDodania = DateTime.Now},
                        new StanyMagazynowe {TowarID = 3,Stan = 7,DataDodania = DateTime.Now},
                        new StanyMagazynowe {TowarID = 4,Stan = 10,DataDodania = DateTime.Now},
                        new StanyMagazynowe {TowarID = 5,Stan = 3,DataDodania = DateTime.Now},

                    };

                    foreach (var sM in towarStany)
                        context.StanyMagazynowe.AddRange(sM);
                    context.SaveChanges();
                }
            }
        }
    }
}
