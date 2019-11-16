using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class TipoEmergencia
    {
        public int TipoEmergenciaId { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(60)]
        public string Nombre {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(300)]
        public string Desc {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(12)]
        public string Gravedad {get; set;}

        public ICollection<Emergencia> Emergencia {get; set;}
        
    }
}