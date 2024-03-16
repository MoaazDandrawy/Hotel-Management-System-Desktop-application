using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Booking
    {
        [Key]
        public int BookingID { get; set; }
        
        [ForeignKey("Customer")]
        public string CustomerSSN { get; set; }
        
        public Customer Customer { get; set; }

        [ForeignKey("Room")]
        public int RoomID { get; set; }

        public Room Room { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public User User { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int Duration { get; set; }

        public double BookingCost { get; set; }


    }
}
