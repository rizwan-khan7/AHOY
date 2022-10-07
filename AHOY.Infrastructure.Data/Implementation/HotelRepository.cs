using AHOY.Infrastructure.Data.Contracts;
using AHOY.Infrastructure.Data.Data;
using AHOY.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Infrastructure.Data.Implementation
{
    public class HotelRepository : IHotelRepository
    {
        public HotelRepository()
        { }

        public async Task<List<Hotels>> GetHotelList()
        {
            return await Task.FromResult(Data.Data.GetHotelList());
        }
        public async Task<Hotels> GetHotelDetailsById(long hotelId)
        {
           return await Task.FromResult(Data.Data.GetHotelList().FirstOrDefault(x => x.HotelId == hotelId));
        }

        public async Task<List<Facilities>> GetFacilities()
        {
            return await Task.FromResult(Data.Data.GetFacilitiesList());
        }

        public async Task<List<HotelImages>> GetHotelImages()
        {
            return await Task.FromResult(Data.Data.GetHotelImages());
        }
    }
}
