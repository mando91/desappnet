
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenParcial2.Models
{
    public class PaymentMethods
    {
        [Key]
        [Display(Name="ID")]
        public int PaymentMethodId {get; set;}
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(30)]
        public string PaymentMethod {get; set;}
         public ICollection<Payments> Payments {get; set;}
       
    }
}