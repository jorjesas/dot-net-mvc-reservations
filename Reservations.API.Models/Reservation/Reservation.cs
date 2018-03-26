using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.API.Models.Reservations
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Required]
        public string HotelName { get; set; }
        public decimal Price { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public int GuestId { get; set; }
        [JsonIgnore]
        public Guest Guest { get; set; }
    }
}
