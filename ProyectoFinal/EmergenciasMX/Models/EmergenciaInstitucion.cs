using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class EmergenciaInstitucion
    {
        
        public int EmergenciaInstitucionId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public int EmergenciaId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        
        public int InstitucionPublicaId { get; set; }

        public InstitucionPublica InstitucionPublica {get; set;}
        public Emergencia Emergencia {get; set;}
    }
}