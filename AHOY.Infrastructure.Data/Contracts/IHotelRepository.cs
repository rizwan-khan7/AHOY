using AHOY.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Infrastructure.Data.Contracts
{
    public interface IHotelRepository
    {
        Task<List<Hotels>> GetHotelList();
        Task<Hotels> GetHotelDetailsById(long hotelId);
        Task<List<Facilities>> GetFacilities();
        Task<List<HotelImages>> GetHotelImages();
    }
}
