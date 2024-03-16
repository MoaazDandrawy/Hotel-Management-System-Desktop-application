using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Type
    {
        [Key]
        [DisplayName("Category ID")]
        public int TypeID { get; set; }

        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Daily Cost")]
        public double DailyCost { get; set; }

        [DisplayName("Guest Number")]
        public int GuestCount { get; set; }

        public List<Room> Rooms { get; set; }

    }
}
