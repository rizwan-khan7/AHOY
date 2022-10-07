using AHOY.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Models.Search
{
    public class HotelSearch
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public decimal StartPrice { get; set; }
        public decimal OfferStartPrice { get; set; }
        public int Rating { get; set; }
        public int RatingCount { get; set; }
        public List<HotelImg> HotelImages { get; set; }
    }
}
