using System.Linq;
using Microsoft.EntityFrameworkCore;
using EmergenciasMX.Models;

namespace EmergenciasMX.Areas.Identity.Data
{
    public static class DbInitializer {
        public static void Initializate(emergenciasMxContext context) {
            context.Database.EnsureCreated(); // crea bd si no existe
        
        if(context.TipoEmergencia.Any()) {
                 // la bd ya tiene datos
          }else{
            var TipoEmergencia = new TipoEmergencia[] {
               new TipoEmergencia {Nombre= "Robo", Desc = "Robo a hogar", Gravedad ="Medio" }, 
               new TipoEmergencia {Nombre= "Robo", Desc = "Robo a manor armada", Gravedad ="Alto" }, 
               new TipoEmergencia {Nombre= "Robo", Desc = "Automovil", Gravedad ="Medio" }, 
               new TipoEmergencia {Nombre= "Descompostura", Desc = "Descompostura vehiculo", Gravedad ="Medio" }, 
               new TipoEmergencia {Nombre= "Emergencia medica", Desc = "Emergencia medica urgencias", Gravedad ="Alto" } 
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(TipoEmergencia g in TipoEmergencia) {
                context.TipoEmergencia.Add(g);
            }

          
            context.SaveChanges();
          }

           if(context.Emergencia.Any()) {
                 // la bd ya tiene datos
          }else{
            var Emergencia = new Emergencia[] {
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = "jerez, zac", Estatus ="Pendiente", TipoEmergenciaId =1},
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = " zac, zac", Estatus ="Procesda", TipoEmergenciaId =2},
               new Emergencia {Descripcion= "Robo", Lugar = "jerez, zac", Estatus ="Pendiente", TipoEmergenciaId =3},
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = "jerez, zac", Estatus ="Procesda", TipoEmergenciaId =1},
               new Emergencia {Descripcion= "Descompostura", Lugar = "jerez, zac", Estatus ="Pendiente", TipoEmergenciaId =4},
               new Emergencia {Descripcion= "Emergencia clinica", Lugar = "jerez, zac", Estatus ="Procesda", TipoEmergenciaId =5},
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = "Fresnillo, zac", Estatus ="Pendiente", TipoEmergenciaId =1},
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = "jerez, zac", Estatus ="Procesda", TipoEmergenciaId =1}, 
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = "Fresnillo, zac", Estatus ="Recivida", TipoEmergenciaId =1}, 
               new Emergencia {Descripcion= "Robo a casa hogar", Lugar = "Zac, zac", Estatus ="Procesda", TipoEmergenciaId =1} 
              
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(Emergencia g in Emergencia) {
                context.Emergencia.Add(g);
            }
          
            context.SaveChanges();
          }

           if(context.InstitucionPublica.Any()) {
                 // la bd ya tiene datos
          }else{
            var InstitucionPublica = new InstitucionPublica[] {
               new InstitucionPublica {Nombre= "IMSS", Estado = "Zacatecas", Municipio ="Zacatecas", Pais ="Mexico", NumeroIP=1},
               new InstitucionPublica {Nombre= "Bomberos", Estado = "Zacatecas", Municipio ="Zacatecas", Pais ="Mexico", NumeroIP=2},
              new InstitucionPublica {Nombre= "SEDENA", Estado = "Zacatecas", Municipio ="Zacatecas", Pais ="Mexico", NumeroIP=3},
              new InstitucionPublica {Nombre= "Policia Estatal", Estado = "Zacatecas", Municipio ="Zacatecas", Pais ="Mexico", NumeroIP=4},
              new InstitucionPublica {Nombre= "Servico de Gruas", Estado = "Zacatecas", Municipio ="Zacatecas", Pais ="Mexico", NumeroIP=4},
              new InstitucionPublica {Nombre= "Transito", Estado = "Zacatecas", Municipio ="Zacatecas", Pais ="Mexico", NumeroIP=4}
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(InstitucionPublica g in InstitucionPublica) {
                context.InstitucionPublica.Add(g);
            }
          
            context.SaveChanges();
          }

          if(context.Vehiculo.Any()) {
                 // la bd ya tiene datos
          }else{
            var Vehiculo = new Vehiculo[] {
              new Vehiculo {Modelo= "Lobo", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=4, Matricula ="1321"},
              new Vehiculo {Modelo= "Lobo", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=4, Matricula ="2321"},
              new Vehiculo {Modelo= "Lobo", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=4, Matricula ="3321"},
              new Vehiculo {Modelo= "Lobo", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=4, Matricula ="5321"},
              new Vehiculo {Modelo= "Lobo", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=4, Matricula ="4321"},
              new Vehiculo {Modelo= "Cheyene", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=5, Matricula ="1123"},
              new Vehiculo {Modelo= "Cheyene", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=5, Matricula ="2123"},
              new Vehiculo {Modelo= "Cheyene", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=5, Matricula ="3231"},
              new Vehiculo {Modelo= "Cheyene", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=5, Matricula ="4123"},
              new Vehiculo {Modelo= "Cheyene", Marca = "Ford", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=5, Matricula ="5123"},
              new Vehiculo {Modelo= "Ambulancia", Marca = "Ford", Tipo ="Camioneta Combi", CantidadPasajeros =6, InstitucionPublicaId=1, Matricula ="1321"},
              new Vehiculo {Modelo= "Camion de Bomberos", Marca = "Ford", Tipo ="Camion", CantidadPasajeros =2, InstitucionPublicaId=2, Matricula ="1321"},
              new Vehiculo {Modelo= "Tornado", Marca = "Nissan", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=3, Matricula ="4123"},
              new Vehiculo {Modelo= "Tornado", Marca = "Nissan", Tipo ="Camioneta", CantidadPasajeros =4, InstitucionPublicaId=3, Matricula ="5123"},
               
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(Vehiculo g in Vehiculo) {
                context.Vehiculo.Add(g);
            }
          
            context.SaveChanges();
          }

           if(context.EmergenciaInstitucion.Any()) {
                 // la bd ya tiene datos
          }else{
            var EmergenciaInstitucion = new EmergenciaInstitucion[] {
               new EmergenciaInstitucion {EmergenciaId= 1, InstitucionPublicaId = 1 },
               new EmergenciaInstitucion {EmergenciaId= 2, InstitucionPublicaId = 2 },
               new EmergenciaInstitucion {EmergenciaId= 3, InstitucionPublicaId = 4 },
               new EmergenciaInstitucion {EmergenciaId= 4, InstitucionPublicaId = 1 },
               new EmergenciaInstitucion {EmergenciaId= 5, InstitucionPublicaId = 2 },
               new EmergenciaInstitucion {EmergenciaId= 6, InstitucionPublicaId = 3 },
               new EmergenciaInstitucion {EmergenciaId= 7, InstitucionPublicaId = 1 },
               new EmergenciaInstitucion {EmergenciaId= 8, InstitucionPublicaId = 2 },
               new EmergenciaInstitucion {EmergenciaId= 9, InstitucionPublicaId = 1 },
               
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(EmergenciaInstitucion g in EmergenciaInstitucion) {
                context.EmergenciaInstitucion.Add(g);
            }
          
            context.SaveChanges();
          }
        
        }

        
    }
}