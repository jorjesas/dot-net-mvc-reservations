using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.API.Models.Reservations
{
    public class GuestAddress
    {
        [ForeignKey("Guest")]
        public int GuestAddressId { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        [Required]
        public string Country { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
