using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.SearchHotel
{
    public class GetSearchHotelQuery : IRequest<GetSearchHotelQueryResult>
    {
        public string HotelName { get; set; }
        public string City { get; set; }
        public DateTime CheckedInDate { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public int RoomCount { get; set; }
        public int GuestCount { get; set; }
    }
}
