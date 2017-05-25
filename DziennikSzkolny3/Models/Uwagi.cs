using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Uwagi
    {


        public int UwagiID { get; set; }
        public int NauczycielID { get; set; }
        public int UczenID { get; set; }
        //[Required]
        //[MaxLength(1024)]
        //[MinLength(10)]
        public string Uwaga { get; set; }
        //[Required]
        public DateTime Data { get; set; }
        public virtual Uczen Uczen { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }




    }
}