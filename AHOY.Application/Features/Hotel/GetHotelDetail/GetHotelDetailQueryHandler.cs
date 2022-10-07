using AHOY.Application.Service.Hotel.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.GetHotelDetail
{
    public class GetHotelDetailQueryHandler : IRequestHandler<GetHotelDetailQuery, GetHotelDetailQueryResult>
    {
        private readonly IHotelService hotelService;
        public GetHotelDetailQueryHandler(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public async Task<GetHotelDetailQueryResult> Handle(GetHotelDetailQuery request, CancellationToken cancellationToken)
        {
            var result =  await this.hotelService.GetHotelDetailsById(request.HotelId);
            return new GetHotelDetailQueryResult { HotelDetail = result };
        }
    }
}
