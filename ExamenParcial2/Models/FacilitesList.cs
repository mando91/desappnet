

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class FacilitesList
    {
        [Key]
        [Display(Name="ID")]
        public int FacilityId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string FacilitesDesc {get; set;}
         public ICollection<RoomsFacilities> RoomsFacilities {get; set;}
    }
}