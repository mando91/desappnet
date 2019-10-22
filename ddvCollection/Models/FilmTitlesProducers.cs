

using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class FilmTitlesProducers
    {
        public int ProducerId { get; set; }
        public string FilmTitleId {get; set;}
        public Producers Producers { get; set;}       
        public FilmTitles FilmTitles {get; set;}
    }
}