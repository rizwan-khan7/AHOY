using AHOY.Application.Features.Hotel.SearchHotel;
using AHOY.Application.Service.Hotel.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.SearchHotel
{
    public class GetSearchHotelQueryHandler : IRequestHandler<GetSearchHotelQuery, GetSearchHotelQueryResult>
    {
        private readonly IHotelService hotelService;
        public GetSearchHotelQueryHandler(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public async Task<GetSearchHotelQueryResult> Handle(GetSearchHotelQuery request, CancellationToken cancellationToken)
        {
            var result =  await this.hotelService.GetHotelDetails(request);
            return new GetSearchHotelQueryResult { HotelDetailsList = result };
        }
    }
}
