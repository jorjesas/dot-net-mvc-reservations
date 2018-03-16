namespace Reservations.API.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class ReservationsDataDBConfiguration : DbMigrationsConfiguration<Reservations.API.Dal.Contexts.ReservationsContext>
    {
        public ReservationsDataDBConfiguration()
        {
            AutomaticMigrationsEnabled = false;
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
        }
    }
}
