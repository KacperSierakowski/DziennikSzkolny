using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Uwagi
    {


        public int UwagiID { get; set; }
        public int NauczycielID { get; set; }
        public int UczenID { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        [Display(Name = "Treść uwagi")]
        public string Uwaga { get; set; }
        [Required]
        [Display(Name = "Data wstawienia")]
        public DateTime Data { get; set; }
        public virtual Uczen Uczen { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }




    }
}