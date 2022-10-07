using AHOY.Models.Hotel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.HotelBooking
{
    public class HotelBookingQuery : IRequest<HotelBookingQueryResult>
    {
        public long HotelId { get; set; }
        public DateTime CheckedInDate { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public int RoomCount { get; set; }
        public List<Guest> GuestList { get; set; }
        public string BookingBy { get; set; }
        public decimal AdvanceAmount { get; set; }
    }
}
