using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class InstitucionPublica
    {
        public int InstitucionPublicaId { get; set; }

         [MaxLength(40)]
         [Required]
         public string Nombre { get; set; }
         [Required(ErrorMessage="El campo es obligatorio")]
        public int NumeroIP { get; set; }
         [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(40)]
        public string Estado {get; set;}
         [Required(ErrorMessage="El campo es obligatorio")]
        [MaxLength(40)]
        public string Municipio {get; set;}
         [Required(ErrorMessage="El campo es obligatorio")]
          [MaxLength(40)]
        public string Pais {get; set;}

        public ICollection<Vehiculo> Vehiculo {get; set;}
        public ICollection<EmergenciaInstitucion> EmergenciaInstitucion {get; set;}

    }
}