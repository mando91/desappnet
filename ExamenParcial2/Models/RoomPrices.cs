using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class RoomPrices
    {
        [Key]
        [Display(Name="ID")]
        public int RoomPriceId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        public int RoomPrice {get; set;}
        public ICollection<Rooms> Rooms {get; set;}
    }
}