using Reservations.API.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.API.Dal.Contexts
{
    public class ReservationsContext : DbContext
    {
        public ReservationsContext()
            : base("ReservationsContext")
        {

        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestAddress> GuestAddress { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
