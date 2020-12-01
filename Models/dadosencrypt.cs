using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EncryptProva.Models
{
    public class dadosencrypt
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Obrigatorio preenchimento")]
        [Display(Name = "Texto: ")]
        public string campo { get; set; }
        

    
    }
}