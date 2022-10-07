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
    public class HotelBookingQueryHandler : IRequestHandler<HotelBookingQuery, HotelBookingQueryResult>
    {
        private readonly IHotelService hotelService;
        public HotelBookingQueryHandler(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public async Task<HotelBookingQueryResult> Handle(HotelBookingQuery request, CancellationToken cancellationToken)
        {
            if (IsValidBooking(request))
            {
                return BookHotel(request);
            }

            return BookHotelFail(request);
        }

        private bool IsValidBooking(HotelBookingQuery request)
        {
            bool isValidBooking = true;
            if (request.HotelId <= 0 || request.RoomCount <= 0 || request.GuestList.Count <= 0)
            {
                isValidBooking = false;
                return isValidBooking;
            }
            return isValidBooking;
        }

        private HotelBookingQueryResult BookHotel(HotelBookingQuery request)
        {
            HotelBookingQueryResult response = new HotelBookingQueryResult();
            //Do all the DB query Transcation here
            HotelBookingResponse bookingResponse = new HotelBookingResponse
            {
                HotelBookingId = Random.Shared.Next(50, 500),
                BookingBy = request.BookingBy,
                AdvanceAmount = request.AdvanceAmount,
                CheckedInDate = request.CheckedInDate,
                CheckedOutDate = request.CheckedOutDate,
                GuestCount = request.GuestList.Count,
                IsSuccess = true,
                Message = "Booking Confirm.",
                RoomCount = request.RoomCount,
                TotalAmount = Random.Shared.Next(1000, 10000)
            };
            response.BookingResponse = bookingResponse;
            return response;
        }

        private HotelBookingQueryResult BookHotelFail(HotelBookingQuery request)
        {
            HotelBookingQueryResult response = new HotelBookingQueryResult();
            //Do all the DB query Transcation here
            HotelBookingResponse bookingResponse = new HotelBookingResponse
            {
                Message = "Booking Failed.",
                IsSuccess = false,
            };
            response.BookingResponse = bookingResponse;
            return response;
        }
    }
}
