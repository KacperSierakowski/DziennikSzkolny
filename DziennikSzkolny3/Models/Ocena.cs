using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Ocena
    {
        public int OcenaID { get; set; }
        public int NauczycielID { get; set; }
        public int UczenID { get; set; }
        public int PrzedmiotID { get; set; }
        //[Required]
        public DateTime Data { get; set; }
        //[Required]
        //[Range(1, 4)]
        //[Display(Name = "Waga oceny")]
        public int Waga { get; set; }
        //[Required]
        //[Range(1, 6)]
        //[Display(Name = "Ocena")]
        public int Wartosc { get; set; } //Z uwagi na konflikt nazw pole Ocena z tabeli Ocena zmieniło nazwę na Wartosc
        //[StringLength(1024)]
        public string Komentarz { get; set; }
        public virtual Uczen Uczen { get; set; }
        public virtual Przedmiot Przedmiot { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }


    }
}