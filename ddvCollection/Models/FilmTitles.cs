using System;
using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class FilmTitles
    {
        public int FilmTileId { get; set; }
        public string FilmTitle {get; set;}
        public string FilmStory {get; set;}
        public DateTime FilmReleaseDate {get; set;}
        public int  FilmDuration  {get; set;}
        public int  FilmGenereId  {get; set;}
        public int  CertificateId  {get; set;}
        public Generes Generes {get; set;}
        public Certificates Certificates {get; set;}
        public ICollection<FilmTitlesProducers> FilmTitlesProducers {get; set;}
        public ICollection<FilmActorRoles> FilmActorRoles {get; set;}
    }
}