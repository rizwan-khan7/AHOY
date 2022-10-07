using AHOY.Application.Features.Hotel.SearchHotel;
using AHOY.Models.Hotel;
using AHOY.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Service.Hotel.Contacts
{
    public interface IHotelService
    {
        Task<HotelDetail> GetHotelDetailsById(long hotelId);
        Task<List<HotelSearch>> GetHotelDetails(GetSearchHotelQuery request);
    }
}
