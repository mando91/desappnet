using System.Collections.Generic;

namespace ddvCollection.Models
{
    public class Certificates
    {
        public int CertificateId { get; set; }
        public string CertificateDesc {get; set;}

        public ICollection<FilmTitles> FilmTitles {get; set;}
    }
}