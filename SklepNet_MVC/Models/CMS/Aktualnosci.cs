using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SklepNet_MVC.Models.CMS
{
    public class Aktualnosci
    {
        [Key]
        public int IdAktualnosc { get; set; }
        //[Required(ErrorMessage = "Wpisz tytuł aktualności")]
        //[MaxLength(30, ErrorMessage = "Tytuł aktualności powinien zawierać maxymalnie 30 znaków")]
        //[Display(Name = "Tytuł")]
        public string Tytul { get; set; }
        //[Display(Name = "Treść")]
        //[Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }
        //[Display(Name = "Pozycja wyświetlania")]
        //[Required(ErrorMessage = "Wpisz pozycję wyświetlania")]
        public int Pozycja { get; set; }
    }
}
