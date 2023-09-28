using System.ComponentModel.DataAnnotations;

namespace SklepNet_MVC.Models.Sklep
{
    public class StanyMagazynowe
    {
        [Key]
        public int IdStanMagazynowy { get; set; }
        public  Towar Towar { get; set; }
        public int TowarID{ get; set; }

        public int Stan { get; set; }
        public DateTime DataDodania { get; set; }

    }
}
