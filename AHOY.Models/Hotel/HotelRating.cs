using AHOY.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Models.Hotel
{
    public class HotelRating
    {
        public long HotelId { get; set; }
        public int HotelBookingId { get; set; }
        public int RatingCount { get; set; }
        public string RatingDescription { get; set; }
    }
}
