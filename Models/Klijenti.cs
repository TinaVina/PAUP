using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServisVozila.Models
{
    public class Klijenti
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public int id { get; set; }

        [Display(Name = "OIB")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(11, ErrorMessage = "Neispravan OIB")]
        public string oib { get; set; }

        [Display(Name = "Ime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public string ime { get; set; }

        [Display(Name = "Prezime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public string prezime { get; set; }

        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Display(Name = "Broj telefona")]
        public int brojTelefona { get; set; }

        [Display(Name = "Model vozila")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public Modeli modelVozila { get; set; }

        [Display(Name = "Kvar na vozilu")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public string kvarNaVozilu { get; set; }
    }
}