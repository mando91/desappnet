using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class MuertesCiviles
    {
        
        public int MuertesCivilesId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public int CivilesId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(1000)]
        public string CausaMuerte {get; set;}
    
        public Civiles Civiles {get; set;}
      
    }
}