using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.GetHotelDetail
{
    public class GetHotelDetailQuery : IRequest<GetHotelDetailQueryResult>
    {
        public long HotelId { get; set; }
    }
}
