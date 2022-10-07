using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Infrastructure.Data.Entities
{
    public class Hotels
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public long PinCode { get; set; }
        public string Description { get; set; }
    }
}
