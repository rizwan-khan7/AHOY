using AHOY.Application.Features.Hotel.HotelBooking;
using AHOY.Application.Features.Hotel.HotelRating;
using AHOY.Application.Features.Hotel.SearchHotel;
using AHOY.Infrastructure.Data.Entities;
using AHOY.Models.Hotel;
using AHOY.Models.Search;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<HotelDetail, Hotels>().ReverseMap();
            CreateMap<HotelSearch, Hotels>().ReverseMap();
            CreateMap<HotelFacilities, Facilities>().ReverseMap();
            CreateMap<HotelImages, HotelImg>().ReverseMap();
            CreateMap<GetSearchHotelQuery, HotelSearchFilter>().ReverseMap();
            CreateMap<HotelBookingQuery, HotelBooking>().ReverseMap();
            CreateMap<HotelRatingQuery, HotelRating>().ReverseMap();
        }
    }
}
