

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class BookingsRooms
    {
        [Key]
        [Display(Name="ID")]
        public int BookingId {get; set;}
        //public ICollection<BookingsRooms> BookingsRooms {get; set;}
        [Required]
         public int GuestId {get; set;}
         [Required]
         public int RoomId {get; set;}

         public Rooms Rooms{get; set;}
         public Guests Guests {get; set;}
        public ICollection<Bookings> Bookings {get; set;}
        
    }
}