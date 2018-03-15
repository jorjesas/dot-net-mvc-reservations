using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSAuthentication.API.Models.Reservations
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual GuestAddress Address { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

    }
}
