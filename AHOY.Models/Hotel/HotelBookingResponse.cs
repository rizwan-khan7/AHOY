using AHOY.Models.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Models.Hotel
{
    public class HotelBookingResponse
    {
        public long HotelBookingId { get; set; }
        public string BookingBy { get; set; }
        public decimal AdvanceAmount { get; set; }
        public DateTime CheckedInDate { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public int GuestCount { get; set; }
        public int RoomCount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsSuccess { get; set; }
        public string Message{ get; set; }
    }
}
