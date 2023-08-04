using System.ComponentModel.DataAnnotations.Schema;

namespace SklepNet_MVC.Models.Sklep
{
    public class TowarZdjecie
    {
        public int IdTowarZdjecie { get; set; }
        public string URL { get; set; }
        public virtual Towar Towar { get; set; }
        public int IdTowar { get; set; }
    }
}
