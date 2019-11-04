using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class RoomBands
    {
        [Key]
        [Display(Name="ID")]
        public int RoomBandId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(300)]
        public string BandDesc {get; set;}

        public ICollection<Rooms> Rooms {get; set;}
    }
}