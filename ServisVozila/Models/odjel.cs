using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServisVozila.Models
{    
    [Table("odjel")]
    public class odjel
    {
        [Key]
        [Display(Name ="ID odjel")]
        [Required] 
        public int idOdjel { get; set; } 

       [Display(Name ="Naziv odjela")]
       [Required]
       public string nazivOdjel { get; set; } 

    }
}