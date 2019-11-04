
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace ExamenParcial2.Models
{
    public class Bookings
    {
       [Required]
       public int CustomerId {get; set;}
        public int BookingId {get; set;}
        //public ICollection<BookingsRooms> BookingsRooms {get; set;}
        
         public DateTime DateBooikingMede {get; set;}
         public DateTime DateBooikedStart {get; set;}
         public DateTime DateBookedEnd {get; set;}
         public DateTime TotalPaymentDate {get; set;}
         public int TotalPaymentDueAmount {get; set;}
         public string BookingComments {get; set;}

         public Custumers Custumers{get; set;}
         public BookingsRooms bookingsRooms {get; set;}
         public ICollection<Payments> Payments {get; set;}
    }
}