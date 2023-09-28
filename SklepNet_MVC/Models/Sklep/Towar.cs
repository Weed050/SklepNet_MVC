using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace SklepNet_MVC.Models.Sklep
{
    public class Towar
    {
        [Key]
        public int IdTowar { get; set; }

        [Required(ErrorMessage = "Nazwa towaru wymagana")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Opis towaru wymagany")]
        public string Opis { get; set; }

        [DataType(DataType.Currency,ErrorMessage = "Wartość podana jest nie prawidłowa. Musi być liczbą.")]
        [Required(ErrorMessage = "Cena towaru wymagana")]
        public double Cena { get; set; }
        [Display(Name = "VIP Towar")]
        public bool VIPtowar { get; set; }
        [Display(Name = "Towar Promocyjny")]
        public bool towarPromocyjny { get; set; }
        //public virtual ICollection<TowarZdjecie> TowarZdjecie { get; set; }
        //public virtual ICollection<StanyMagazynowe> StanyMagazynowe { get; set; }
        public List<TowarZdjecie> ZdjeciaTowarow { get; set; } = new List<TowarZdjecie> { };
        public List<StanyMagazynowe> StanyMagazynowe { get; set; } = new List<StanyMagazynowe> { };
    }
}
