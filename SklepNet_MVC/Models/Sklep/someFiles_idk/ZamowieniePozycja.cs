﻿using System.ComponentModel.DataAnnotations;

namespace SklepNet_MVC.Models.Sklep.someFiles_idk
{
    public class ZamowieniePozycja
    {
        [Key]
        public int IdZamowieniePozycja { get; set; }
        public int IdTowar { get; set; }
        public virtual Towar Towar { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }

        public decimal Wartosc { get; set; }
        public int IdZamowienie { get; set; }
        public Zamowienie Zamowienie { get; set; }
    }
}
