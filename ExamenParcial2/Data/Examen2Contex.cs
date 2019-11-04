
using Microsoft.EntityFrameworkCore;
using ExamenParcial2.Models;


namespace ExamenParcial2.Data 
{
    public class Examen2Contex : DbContext
    {
        public Examen2Contex(DbContextOptions<Examen2Contex> options) : base(options) 
        {
        }

        public DbSet<RoomTypes> RoomTypes {get; set;}
        public DbSet<RoomBands> RoomBands {get; set;}
        public DbSet<RoomPrices> RoomPrices {get; set;}
        public DbSet<Rooms> Rooms {get; set;}
        public DbSet<Guests> Guests {get; set;}
        public DbSet<Custumers> Custumers {get; set;}
        public DbSet<PaymentMethods> PaymentMethods {get; set;}
        public DbSet<FacilitesList> FacilitesList {get; set;}
        public DbSet<RoomsFacilities> RoomsFacilities {get; set;}
        public DbSet<BookingsRooms> BookingsRooms {get; set;}
        public DbSet<Bookings> Bookings {get; set;}
        public DbSet<Payments> Payments {get; set;}
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<RoomsFacilities>().HasKey(c => new {c.RoomId, c.FacilityId});
           modelBuilder.Entity<Bookings>().HasKey(c => new {c.BookingId});
           modelBuilder.Entity<Payments>().HasKey(c => new {c.CustomerId, c.PaymentsId, c.PaymentMethodId});
        }
       
    } 
}