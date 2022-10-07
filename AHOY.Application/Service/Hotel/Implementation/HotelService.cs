using AHOY.Application.Features.Hotel.SearchHotel;
using AHOY.Infrastructure.Data.Contracts;
using AHOY.Infrastructure.Data.Entities;
using AHOY.Models.Hotel;
using AHOY.Models.Search;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Service.Hotel.Contacts
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IMapper mapper;
        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            this.hotelRepository = hotelRepository;
            this.mapper = mapper;
        }
        public async Task<HotelDetail> GetHotelDetailsById(long hotelId)
        {
            var result = await hotelRepository.GetHotelDetailsById(hotelId);
            var hotelDetail = mapper.Map<HotelDetail>(result);
            var facilities = await hotelRepository.GetFacilities();
            hotelDetail.Facilities = mapper.Map<List<HotelFacilities>>(facilities);
            var images = await hotelRepository.GetHotelImages();
            hotelDetail.Images = mapper.Map<List<HotelImg>>(images);
            hotelDetail.StartPrice = Random.Shared.Next(500, 9500);
            return hotelDetail;
        }

        public async Task<List<HotelSearch>> GetHotelDetails(GetSearchHotelQuery request)
        {
            var hotelList = await hotelRepository.GetHotelList();
            if (!string.IsNullOrEmpty(request.City))
            {
                hotelList = hotelList.Where(x => x.City.Contains(request.City)).ToList();
            }

            if (!string.IsNullOrEmpty(request.HotelName))
            {
                hotelList = hotelList.Where(x => x.HotelName.Contains(request.HotelName)).ToList();
            }

            var hotelDetails = mapper.Map<List<HotelSearch>>(hotelList);
            var facilities = await hotelRepository.GetFacilities();
            foreach (var hotel in hotelDetails)
            {
                var images = await hotelRepository.GetHotelImages();
                hotel.HotelImages = mapper.Map<List<HotelImg>>(images);
                hotel.StartPrice = Random.Shared.Next(500, 9500);
                hotel.OfferStartPrice = hotel.StartPrice - (hotel.StartPrice / 10);
                hotel.Rating = Random.Shared.Next(1, 5);
                hotel.RatingCount = Random.Shared.Next(5, 500);
            }
            return hotelDetails;
        }
    }
}
