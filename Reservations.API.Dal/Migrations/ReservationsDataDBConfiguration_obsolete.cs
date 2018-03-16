using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.API.Dal.Migrations
{
    public sealed class ReservationsDataDBConfiguration_obsolete : DbMigrationsConfiguration<Contexts.ReservationsContext>
    {
        public ReservationsDataDBConfiguration_obsolete()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
