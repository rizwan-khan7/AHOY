using AHOY.Models.Hotel;
using AHOY.Models.Search;
using AHOY.WebApi.Controllers;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;

namespace AHOY.WebApi.Tests.Hotel
{
    public class HotelControllerTest
    {
        private readonly Mock<ILogger<HotelController>>_logger;
        private readonly Mock<IMediator> _mediator;
        private readonly Mock<IMapper> _mapper;
        public HotelControllerTest()
        {
            _logger = new Mock<ILogger<HotelController>>();
            _mediator = new Mock<IMediator>();
            _mapper = new Mock<IMapper>();
        }

        [Fact]
        public async Task Test_GetHotelDetail()
        {
            long hotelId = 2;
            var controller = new HotelController(_logger.Object, _mediator.Object, _mapper.Object);
            var result = await controller.GetHotelDetail(hotelId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Test_SearchHotel()
        {
            var controller = new HotelController(_logger.Object, _mediator.Object, _mapper.Object);
            var filter = new HotelSearchFilter();
            var result = await controller.SearchHotel(filter);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Test_HotelBooking()
        {
            var controller = new HotelController(_logger.Object, _mediator.Object, _mapper.Object);
            var booking = new HotelBooking
            {
                 HotelId = 1,
                 BookingBy = "Test",
                 AdvanceAmount = 5000,
                 RoomCount = 1,
                 GuestList = new List<Guest> { new Guest { FirstName = "Test First Name", LastName = "Test Last Name", Age = 32, IdNumber = "ABCD", IdType = 2  } }
            };
            var result = await controller.HotelBooking(booking);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Test_HotelRating()
        {
            var controller = new HotelController(_logger.Object, _mediator.Object, _mapper.Object);
            var rating = new HotelRating
            {
                HotelBookingId = 1,
                HotelId=  1,
                RatingCount = 5,
                RatingDescription = "Test Description"
            };
            var result = await controller.HotelRating(rating);
            Assert.NotNull(result);
        }

    }
}