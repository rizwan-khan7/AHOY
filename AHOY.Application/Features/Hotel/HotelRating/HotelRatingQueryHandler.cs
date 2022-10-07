using AHOY.Application.Features.Hotel.HotelRating;
using AHOY.Application.Features.Hotel.SearchHotel;
using AHOY.Application.Service.Hotel.Contacts;
using AHOY.Models.Hotel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.HotelBooking
{
    public class HotelRatingQueryHandler : IRequestHandler<HotelRatingQuery, HotelRatingQueryResult>
    {
        private readonly IHotelService hotelService;
        public HotelRatingQueryHandler(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public async Task<HotelRatingQueryResult> Handle(HotelRatingQuery request, CancellationToken cancellationToken)
        {
            return HotelRating(request);
        }

        private HotelRatingQueryResult HotelRating(HotelRatingQuery request)
        {
            HotelRatingQueryResult response = new HotelRatingQueryResult();
            //Do all the DB query Transcation here
            HotelRatingResponse ratingResponse = new HotelRatingResponse
            {
                Message = "Thanks for rating.",
                IsSuccess = true,
            };
            response.RatingResponse = ratingResponse;
            return response;
        }
    }
}
