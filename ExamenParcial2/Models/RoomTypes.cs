using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class RoomTypes
    {
        [Key]
        [Display(Name="ID")]
        public int RoomTypeId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(80)]
        public string RoomType {get; set;}
        public ICollection<Rooms> Rooms {get; set;}
    }
}