using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class Generes
    {
        public int GenereId { get; set; }
        public string GenereDesc {get; set;}

        public ICollection<FilmTitles> FilmTitles {get; set;}
    }
}