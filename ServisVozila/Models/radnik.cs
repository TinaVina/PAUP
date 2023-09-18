using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServisVozila.Models
{
    [Table("radnik")]
 
    public class radnik
    {
        [Key]
        [Display(Name ="ID radnika")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public int idRadnik { get; set; }     

        [Display(Name = "OIB")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(11, ErrorMessage = "Neispravan OIB")]
        public string oibRadnik { get; set; }

        [Display(Name = "Ime ")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maximalno {1} znakova")]
        public string imeRadnik { get; set; }

        [Display(Name = "Prezime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maximalno {1} znakova")]
        public string prezimeRadnik { get; set; }

        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Display(Name = "Broj telefona")]
        public int brojTelefona { get; set; }

        [Display(Name ="Satnica")]
        public int satnica { get; set; }

      
        [Display(Name = "Datum rođenja")]
        public DateTime datRodenja { get; set; }

        [Display(Name = "ID odjela")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public int radnik_odjel { get; set; }


    }
}