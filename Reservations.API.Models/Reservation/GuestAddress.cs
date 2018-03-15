using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSAuthentication.API.Models.Reservations
{
    public class GuestAddress
    {
        [Key]
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
