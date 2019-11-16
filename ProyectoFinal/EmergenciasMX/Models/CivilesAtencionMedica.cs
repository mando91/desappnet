using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class CivilesAtencionMedica
    {
        
        public int CivilesAtencionMedicaId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public int CivilesId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public bool RequiereSangre {get; set;}
        public string OrganoRequerido {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(10)]
        public string Gravedad {get; set;}
        public Civiles Civiles {get; set;}
      
    }
}