using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomNum { get; set; }

        [ForeignKey("Type")]
        public int TypeID { get; set; }

        public Type Type { get; set; }

        public string Status { get; set; }

        public List<Booking> Bookings { get; set; }


    }
}
