using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Models.Hotel
{
    public class HotelDetail
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public long PinCode { get; set; }
        public string Description { get; set; }
        public decimal StartPrice { get; set; }
        public List<HotelFacilities> Facilities { get; set; }
        public List<HotelImg> Images { get; set; }
    }
}
