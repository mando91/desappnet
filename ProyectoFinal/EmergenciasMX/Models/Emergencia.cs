using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class Emergencia
    {
        public int EmergenciaId { get; set; }

       
        public DateTime Fecha {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(500)]
        public string Descripcion {get; set;} 
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(60)]
        public string Lugar{ get; set;}
         [Required]
        public string Estatus {get; set;}
         

        public int TipoEmergenciaId { get; set; }
        public TipoEmergencia TipoEmergencia {get; set;}

         public ICollection<EmergenciaInstitucion> EmergenciaInstitucion {get; set;}

          public ICollection<ReportesAnonimos> ReportesAnonimos {get; set;}
    }
}