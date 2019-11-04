using System.Linq;
using Microsoft.EntityFrameworkCore;
using ExamenParcial2.Models;

namespace ExamenParcial2.Data 
{
    public static class DbInitializer {
        public static void Initializate(Examen2Contex context) {
            context.Database.EnsureCreated(); // crea bd si no existe

           if(context.Guests.Any()) {
                 // la bd ya tiene datos
          }else{
            var Guests = new Guests[] {
                new Guests {GuestTile="guest1",GuestAddressPostalCode = "1234", GuestAddressSCountry="MEX",
                  GuestAddressStreet="SN luis", GuestAddressTown="x",GuestContactPhone="1234567890",GuestForenames="x", GuestsDOB="x", GuestSurnames="x"},
                new Guests {GuestTile="guest2",GuestAddressPostalCode = "4321", GuestAddressSCountry="US",
                  GuestAddressStreet="", GuestAddressTown="d",GuestContactPhone="0987654321",GuestForenames="", GuestsDOB="a", GuestSurnames="a"},
                new Guests {GuestTile="guest3",GuestAddressPostalCode = "2222", GuestAddressSCountry="MEX",
                  GuestAddressStreet="", GuestAddressTown="q",GuestContactPhone="0978654322",GuestForenames="guest", GuestsDOB="q", GuestSurnames="a"},
                  new Guests {GuestTile="guest4",GuestAddressPostalCode = "1111", GuestAddressSCountry="US",
                  GuestAddressStreet="", GuestAddressTown="q",GuestContactPhone="1234567899",GuestForenames="guest", GuestsDOB="DOB", GuestSurnames="surnames"}
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(Guests g in Guests) {
                context.Guests.Add(g);
            }

          
            context.SaveChanges();
          }

             

            if(context.Custumers .Any()) {
                return; // la bd ya tiene datos
            }

            var Custumers = new Custumers[] {
              new Custumers{CustomerAddressPostalCode="9999", CustomerAddressSCountry="MEX", CustomerSurnames="Armando",
              ContactEmailAddress="mando@hotmail.com", CustomerContactPhone="0987654321",
               CustomerAddressStreet="Colon #66", CustomerAddressTown="x",
              CustomerDOB="ok", CustomerForenames="Forenames", CustomerMobibletPhone="1234567890", CustomerTile="Cliente 1",
              CustomerWorkPhone="1234567899"},
            };

            foreach(Custumers g in Custumers) {
                context.Custumers.Add(g);
            }

            context.SaveChanges(); 
        }
    }
}