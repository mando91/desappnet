
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class RoomsFacilities
    {
        public int RoomId {get; set;}
        public int FacilityId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string FacilitesDetails {get; set;}
        public FacilitesList FacilitesList {get; set;}

        public Rooms Rooms {get; set;}
    }
}