using AHOY.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.Infrastructure.Data.Data
{
    public static class Data
    {
        private static readonly string[] HotelsName = new[]
        {
        "OCTAVE PLAZA HOTEL", "TELEHAUS INTERNATIONAL", "TREEBO TREND CLASSIO RICHMOND", "HOTEL WINDSOR CASTLE INN", "KOMFORT TERRACES", "HOTEL VELLARA", "THE CURZON COURT", "MONARCH LUXUR", "HOTEL TAP PARADISE", "BALLAL RESIDENCY"
        };

        private static readonly string[] City = new[]
        {
        "Mumbai", "Delhi", "Bangalore", "Hyderabad", "Ahmedabad", "Chennai", "Kolkata", "Surat", "Jaipur", "Lucknow"
        };

        private static readonly int[] PinCode = new[]
        {
        110025, 110006, 110005, 110024, 110023, 110022, 110055, 110044, 110027, 332001
        };

        private static readonly string[] Facilities = new[]
        {
        "Breakfast Services", "Fitness Center", "Free Wi-Fi", "Swimming Pool", "Air Conditioning", "24-hour Room Service", "Indoor Games", "Free Parking", "Conference Room", "Restaurant"
        };

        public static List<Hotels> GetHotelList()
        {
            var list = Enumerable.Range(1, 10).Select(index => new Hotels
            {
                HotelId = index,
                City = City[index - 1],
                PinCode = PinCode[index - 1],
                Address = "Stareet " + index + ", Near Main City. ",
                Country = "India",
                Description = "Sample Description",
                HotelName = HotelsName[index - 1]
            });
            return list.ToList();
        }

        public static List<Facilities> GetFacilitiesList()
        {
            var list = Enumerable.Range(1, 10).Select(index => new Facilities
            {
                FacilitiesId = index,
                FacilitiesName = Facilities[Random.Shared.Next(Facilities.Length)],
                Description = "Include with service"
            });
            return list.ToList();
        }

        public static List<HotelImages> GetHotelImages()
        {
            var list = Enumerable.Range(1, 5).Select(index => new HotelImages
            {
                ImageId = index,
                ImageSrc = "https://miro.medium.com/max/828/1*jZ3P8P-5hmYkWU4AWdFMjw.jpeg"
            });
            return list.ToList();
        }
    }
}
