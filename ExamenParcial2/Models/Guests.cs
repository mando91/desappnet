using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class Guests
    {
        [Key]
        [Display(Name="ID")]
        public int GuestId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestTile {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestForenames {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestSurnames {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestsDOB {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestAddressStreet {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestAddressTown {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string GuestAddressSCountry {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(4)]
        public string GuestAddressPostalCode {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(10)]
        public string GuestContactPhone {get; set;}

       public ICollection<BookingsRooms> BookingsRooms {get; set;}
    }
}