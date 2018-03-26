namespace Reservations.API.Dal.Migrations.ReservationDBMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models.Reservations;

    public sealed class Configuration : DbMigrationsConfiguration<Reservations.API.Dal.Contexts.ReservationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ReservationDBMigrations";
        }

        protected override void Seed(Reservations.API.Dal.Contexts.ReservationsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Guests.AddOrUpdate(new Guest[] {
                new Guest() {GuestId=1, FirstName = "Dani", LastName = "Alves", BirthDate = DateTime.Now },
                new Guest() {GuestId=2, FirstName = "Philippe", LastName = "Candeloro", BirthDate = DateTime.Now },
                new Guest() {GuestId=3, FirstName = "Oliver", LastName = "Cromwell", BirthDate = DateTime.Now },
                new Guest() {GuestId=4, FirstName = "Louis", LastName = "Phillipe", BirthDate = DateTime.Now },
                new Guest() {GuestId=5, FirstName = "Louie", LastName = "De Broglie", BirthDate = DateTime.Now },
            });

            context.GuestAddress.AddOrUpdate(new GuestAddress[] {
                new GuestAddress() { GuestAddressId = 1, Address1 = "Memo Street nr. 1", Address2 = null, City = "Cluj", Country = "Romania", State = "Cluj", Zipcode = 432},
                new GuestAddress() { GuestAddressId = 2, Address1 = "Nemo Street nr. 1", Address2 = null, City = "Cluj", Country = "Romania", State = "Cluj", Zipcode = 234},
                new GuestAddress() { GuestAddressId = 3, Address1 = "Zolrilor Street nr. 1", Address2 = null, City = "Cluj", Country = "Romania", State = "Cluj", Zipcode = 876},
                new GuestAddress() { GuestAddressId = 4, Address1 = "Pasteur Street nr. 1", Address2 = null, City = "Cluj", Country = "Romania", State = "Cluj", Zipcode = 45},
                new GuestAddress() { GuestAddressId = 5, Address1 = "Marasti Street nr. 1", Address2 = null, City = "Cluj", Country = "Romania", State = "Cluj", Zipcode = 978}
            });

            context.Reservations.AddOrUpdate( new Reservation[] {
                new Reservation() { ReservationId = 1, GuestId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), HotelName = "Iaki", Price = 120},
                new Reservation() { ReservationId = 2, GuestId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), HotelName = "Radisson", Price = 200},
                new Reservation() { ReservationId = 3, GuestId = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), HotelName = "Belvedere", Price = 320}
            });
        }
    }
}
