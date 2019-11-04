using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class Custumers
    {
        [Key]
        [Display(Name="ID")]
        public int CustomerId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerTile {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerForenames {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerSurnames {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerDOB {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerAddressStreet {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerAddressTown {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string CustomerAddressSCountry {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(4)]
        public string CustomerAddressPostalCode {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(10)]
        public string CustomerContactPhone {get; set;}
        public string CustomerWorkPhone {get; set;}
        public string CustomerMobibletPhone {get; set;}
        [DataType(DataType.EmailAddress)]
        public string ContactEmailAddress {get; set;}
        //public ICollection<BookingsRooms> BookingsRooms {get; set;}
        public ICollection<Payments> Payments {get; set;}
        public ICollection<Bookings> Bookings {get; set;}
    }
}