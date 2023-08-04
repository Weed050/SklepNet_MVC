using System.ComponentModel.DataAnnotations;

namespace SklepNet_MVC.Models.Sklep
{
    public class StanyMagazynowe
    {
        [Key]
        public int IdStanMagazynowy { get; set; }
        public virtual Towar Towar { get; set; }
        public int IdTowar { get; set; }
        public int Stan { get; set; }
        public DateTime DataDodania { get; set; }

    }
}
