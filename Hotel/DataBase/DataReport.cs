using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataBase
{
    internal class DataReport
    {
        [Key]
        public int ReportID { get; set; }
        public int RoomID { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int Duration { get; set; }

        public double BookingCost { get; set; }
    }
}
