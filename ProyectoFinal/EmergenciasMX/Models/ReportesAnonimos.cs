using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class ReportesAnonimos
    {
        
        public int ReportesAnonimosId { get; set; }

       
        [StringLength(60)]
        public string Descripcion {get; set;} 
               
        [Required(ErrorMessage="El campo es obligatorio")]
        public int EmergenciaId { get; set; }
        public Emergencia Emergencia {get; set;}
   
    }
}