

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class Payments
    {
        [Key]
        [Display(Name="ID")]
        public int PaymentsId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(300)]
        public string PaymentComments {get; set;}
        public int PaymentAmount {get; set;}
        [Required]
        public int BookingId {get; set;}
         [Required]
        public int CustomerId {get; set;}
         [Required]
        public int PaymentMethodId {get; set;}

       public Bookings bookings {get; set;}
       public Custumers Custumers {get; set;}
       public PaymentMethods PaymentMethods {get; set;}
    }
}