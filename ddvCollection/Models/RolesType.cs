using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class RolesType
    {
        public int RoleTypeId { get; set; }
        public string RoleDesc {get; set;}

        public ICollection<FilmActorRoles> FilmActorRoles {get; set;}
    }
}