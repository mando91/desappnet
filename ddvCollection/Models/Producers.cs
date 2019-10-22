using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class Producers
    {
        public int ProducerId { get; set; }
        public string ProducerName {get; set;}
        public string ContactEmialAdress{get; set;}
        public string WebSite{get; set;}

        public ICollection<FilmTitlesProducers> FilmTitlesProducers {get; set;}
    }
}