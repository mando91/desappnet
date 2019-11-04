using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class Rooms
    {
        [Key]
        [Display(Name="ID")]
        public int RoomId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        public string Floor {get; set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        public string AdditionalNotes {get; set;}
        [Required]
        public int RoomBandId {get; set;}
        [Required]
        public int RoomPriceId {get; set;}
        [Required]
        public int RoomTypeId {get; set;}
        public RoomBands RoomBands {get; set;}
        public RoomPrices RoomPrices {get; set;}

        public RoomTypes RoomTypes {get; set;}
        public ICollection<RoomsFacilities> RoomsFacilities {get; set;}
        public ICollection<BookingsRooms> BookingsRooms {get; set;}
    }
}