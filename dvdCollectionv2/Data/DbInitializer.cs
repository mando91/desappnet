 using System.Linq;
 using Microsoft.EntityFrameworkCore;
 using dvdCollection.Models;
 using dvdCollection.Data;

 namespace dvdcollection.Data
 {
     class DbInitializer
     {
      public static void Initializate(dvdCollectionContext context){
          context.Database.EnsureCreated();

          if(context.FilmGeneres.Any()){
              return; // ya tiene datos
          }
        // arreglo de tipo de filgeneres
          var filmGeneres = new FilmGeneres[]{
            new FilmGeneres{GenreDesc ="Actions"},
            new FilmGeneres{GenreDesc ="Aventure"},
            new FilmGeneres{GenreDesc ="Animation"},
            new FilmGeneres{GenreDesc ="Comedy"},
            new FilmGeneres{GenreDesc ="Drama"},
            new FilmGeneres{GenreDesc ="Family"}
          };

          // pasar el arreglo a la tabla

          foreach (var i in filmGeneres)
          {
              //context.FilmGeneres.add(i);
          }

          // grbar los adatos en bd fisica

          context.SaveChanges();
      }   
     }
 }