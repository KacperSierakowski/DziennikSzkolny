using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Frekwencja
    {
        public int FrekwencjaID { get; set; }
        public int UczenID { get; set; }
        public int NauczycielID { get; set; }
        public int PrzedmiotID { get; set; }

        public char Czy_Usprawiedliwiona { get; set; }//Tutaj zmiana!
        //[Required]
        public DateTime Data { get; set; }
        public virtual Uczen Uczen { get; set; }
        public virtual Przedmiot Przedmiot { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }


    }
}