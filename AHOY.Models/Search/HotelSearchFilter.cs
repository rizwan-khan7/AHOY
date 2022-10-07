using AHOY.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Models.Search
{
    public class HotelSearchFilter
    {
        public string HotelName { get; set; }
        public string City { get; set; }
        public DateTime CheckedInDate { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public int RoomCount { get; set; }
        public int GuestCount { get; set; }
    }
}
