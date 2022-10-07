using AHOY.Models.Hotel;
using AHOY.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Application.Features.Hotel.SearchHotel
{
    public class GetSearchHotelQueryResult
    {
        public List<HotelSearch> HotelDetailsList { get; set; }
    }
}
