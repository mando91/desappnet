using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class Donadores
    {
        
        public int DonadoresId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public int CivilesId { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(3)]
        public string TipoSangre {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        public bool DonadorAporbado {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string OrganoDonador {get; set;}
         [Required(ErrorMessage="El campo es obligatorio")]
        public DateTime FechaRegistro {get; set;}
        
        public Civiles Civiles {get; set;}
      
    }
}