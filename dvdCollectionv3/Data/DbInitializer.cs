using System.Linq;
using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;

namespace dvdCollection.Data 
{
    public static class DbInitializer {
        public static void Initializate(dvdCollectionContext context) {
            context.Database.EnsureCreated(); // crea bd si no existe

            if(context.FilmGeneres.Any()) {
                 // la bd ya tiene datos
            }

            // arreglo del tipo FilmGeneres 
            var FilmGeneres = new FilmGeneres[] {
                new FilmGeneres {GenreDesc="Action"},
                new FilmGeneres {GenreDesc="Aventure"},
                new FilmGeneres {GenreDesc="Animation"},
                new FilmGeneres {GenreDesc="Biography"},
                new FilmGeneres {GenreDesc="Comedy"},
                new FilmGeneres {GenreDesc="Crime"},
                new FilmGeneres {GenreDesc="Drama"},
                new FilmGeneres {GenreDesc="Family"},
                new FilmGeneres {GenreDesc="Fantasy"},
                new FilmGeneres {GenreDesc="History"}
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(FilmGeneres g in FilmGeneres) {
                context.FilmGeneres.Add(g);
            }
            //grabar los datos en la bd fisica
            context.SaveChanges();    

            var FilmCertificates = new FilmCertificates[]{
                new FilmCertificates{FilmCertificate="G"},
                new FilmCertificates{FilmCertificate="PG"},
                new FilmCertificates{FilmCertificate="R"},
                new FilmCertificates{FilmCertificate="PG-13"}
            }; 

            foreach(FilmCertificates g in FilmCertificates) {
                context.FilmCertificates.Add(g);
            }
            //grabar los datos en la bd fisica
            context.SaveChanges();  

            var Actors = new Actors[]{
                new Actors {ActorFullName="Lianda Blair", ActorNotes="Actriz" },
                new Actors {ActorFullName="Scarlett johansson", ActorNotes="Actriz" },
                new Actors {ActorFullName="Pam", ActorNotes="Actriz" }
            };

            
            foreach(Actors g in Actors) {
                context.Actors.Add(g);
            }
            //grabar los datos en la bd fisica
            context.SaveChanges(); 
             var RoleTypes = new RoleTypes[] {
                new RoleTypes {RoleDesc="Lead"},
                new RoleTypes {RoleDesc="Principal"},
                new RoleTypes {RoleDesc="Supporting"},
                new RoleTypes {RoleDesc="Featured"},
                new RoleTypes {RoleDesc="Extra"},
            };
            foreach(RoleTypes r in RoleTypes) {
                context.RoleTypes.Add(r);
            }
            context.SaveChanges(); 
        }
    }
}