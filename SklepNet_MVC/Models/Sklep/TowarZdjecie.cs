using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SklepNet_MVC.Models.Sklep
{
    public class TowarZdjecie
    {
        [Key]
        public int TowarZdjecieID { get; set; }
        public string URL { get; set; }
        public Towar Towar { get; set; }
        public int TowarID{ get; set; }
    }
}
