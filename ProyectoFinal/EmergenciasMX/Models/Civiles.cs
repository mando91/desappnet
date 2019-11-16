using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class Civiles
    {
        
        public int CivilesId { get; set; }
    
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string ApellidoPaterno { get; set; }
        [StringLength(30)]
        public string ApellidoMaterno { get; set; }
       
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string Correo { get; set; }
        
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(10)]
        public string Telefono { get; set; }  
        [StringLength(30)]
            public string EstadoCicil { get; set; }
            
        [Required(ErrorMessage="El campo es obligatorio")]

        public int Edad { get; set; }

       
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]

        public string Ciudad { get; set; }
       
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string Estado { get; set; }
       
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string Pais { get; set; }

        public ICollection<Donadores> Donadores {get; set;}
        public ICollection<CivilesAtencionMedica> CivilesAtencionMedica {get; set;}
        public ICollection<MuertesCiviles> MuertesCiviles {get; set;}
      
    }
}