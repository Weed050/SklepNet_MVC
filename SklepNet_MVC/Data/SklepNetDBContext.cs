using Microsoft.EntityFrameworkCore;
using SklepNet_MVC.Models.CMS;
using SklepNet_MVC.Models.Sklep;

namespace SklepNet_MVC.Data
{
    public class SklepNetDBContext : DbContext
    {
        public SklepNetDBContext(DbContextOptions<SklepNetDBContext> options): base(options)
        {
            
        }
        public DbSet<Aktualnosci> Aktualnosci { get; set; }
        //public DbSet<Ogloszenia> Ogloszenia { get; set; }
        public DbSet<Towar> Towar { get; set; }
        public DbSet<TowarZdjecie> TowarZdjecie { get; set; }
        public DbSet<StanyMagazynowe> StanyMagazynowe { get; set; }
    }
}
