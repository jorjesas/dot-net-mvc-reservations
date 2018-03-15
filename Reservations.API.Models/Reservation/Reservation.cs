using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSAuthentication.API.Models.Reservations
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public string HotelName { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int GuestId { get; set; }
        public Guest Guest { get; set; }
    }
}
