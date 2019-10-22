using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class RoleTypes {
         [Key]
         [Display(Name="ID")]
        public int RoleTypeID { get; set;}
        public string RoleDesc { get; set;}

        public ICollection<FilmsActorRoles> FilmActorRoles { get; set;}

    }
}