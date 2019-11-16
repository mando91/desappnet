using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmergenciasMX.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }

        public string Matricula {get; set;}
        public DateTime FechaRegistro {get; set;}
         [Required(ErrorMessage="El campo es obligatorio")]
        public string Modelo {get; set;}
         [Required(ErrorMessage="El campo es obligatorio")] 
        public string Tipo {get; set;} 
         [Required(ErrorMessage="El campo es obligatorio")]
        public string Marca {get; set;} 
         [Required(ErrorMessage="El campo es obligatorio")]
        public int CantidadPasajeros{ get; set;}

        public int InstitucionPublicaId { get; set; }
        public InstitucionPublica InstitucionPublica {get; set;}
    }
}