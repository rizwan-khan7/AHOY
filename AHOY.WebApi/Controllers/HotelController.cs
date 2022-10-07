using AHOY.Application.Features.Hotel.GetHotelDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using AHOY.Models.Search;
using AHOY.Application.Features.Hotel.SearchHotel;
using AHOY.Models.Hotel;
using AutoMapper;
using static System.Net.Mime.MediaTypeNames;
using AutoMapper;
using AHOY.Application.Mapper;
using AHOY.Application.Features.Hotel.HotelBooking;
using AHOY.Application.Features.Hotel.HotelRating;

namespace AHOY.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ILogger<HotelController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public HotelController(ILogger<HotelController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("HotelDetails")]
        public async Task<ActionResult> GetHotelDetail(long hotelId)
        {
            _logger.LogInformation("Hotel Details Get started at {DT}", DateTime.UtcNow.ToLongTimeString());

            if (hotelId <= 0 || hotelId > 10)
            {
                _logger.LogInformation("Invalid hotel id", DateTime.UtcNow.ToLongTimeString());
                return this.BadRequest("Invalid hotel id.");
            }

            var query = new GetHotelDetailQuery { HotelId = hotelId };
            var result = await _mediator.Send(query);
            _logger.LogInformation("Hotel Details Get completed at {DT}", DateTime.UtcNow.ToLongTimeString());
            return this.Ok(result);
        }

        [HttpPost("SearchHotel")]
        public async Task<ActionResult> SearchHotel(HotelSearchFilter request)
        {
            _logger.LogInformation("Search Hotel Details started at {DT}", DateTime.UtcNow.ToLongTimeString());
            var requestFilter = _mapper.Map<GetSearchHotelQuery>(request);
            var result = await _mediator.Send(requestFilter);
            _logger.LogInformation("Search Hotel Details completed at {DT}", DateTime.UtcNow.ToLongTimeString());
            return this.Ok(result);
        }

        [HttpPost("HotelBooking")]
        public async Task<ActionResult> HotelBooking(HotelBooking request)
        {
            _logger.LogInformation("Hotel Booking process started at {DT}", DateTime.UtcNow.ToLongTimeString());
            var requestFilter = _mapper.Map<HotelBookingQuery>(request);
            var result = await _mediator.Send(requestFilter);
            _logger.LogInformation("Hotel Booking process completed at {DT}", DateTime.UtcNow.ToLongTimeString());
            if (result != null && result.BookingResponse != null && !result.BookingResponse.IsSuccess)
            {
                _logger.LogInformation("Hotel Booking failed at {DT}", DateTime.UtcNow.ToLongTimeString());
            }
            return this.Ok(result);
        }

        [HttpPost("HotelRating")]
        public async Task<ActionResult> HotelRating(HotelRating request)
        {
            _logger.LogInformation("Hotel Rating started at {DT}", DateTime.UtcNow.ToLongTimeString());
            var requestFilter = _mapper.Map<HotelRatingQuery>(request);
            var result = await _mediator.Send(requestFilter);
            _logger.LogInformation("Hotel Rating completed at {DT}", DateTime.UtcNow.ToLongTimeString());
            return this.Ok(result);
        }

    }
}
