using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class Actors
    {
        public int ActorId { get; set; }
        public string ActorFullName {get; set;}
        public string memeActorNotes{get; set;}

        public ICollection<FilmActorRoles> FilmActorRoles {get; set;}
    }
}