using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class FilmActorRoles
    {
        public int FilmTitleId { get; set; }
        public int ActorId {get; set;}
        public int RolesTypeId { get; set;}       
        public string CharacterName {get; set;}
        public string CharacterDesdription {get; set;}

        public Actors Actors {get; set;}

        public RolesType RolesType {get; set;}

        public FilmTitles filmTitles {get; set;}
    }
}