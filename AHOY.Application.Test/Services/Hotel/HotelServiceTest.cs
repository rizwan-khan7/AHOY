using AHOY.Application.Mapper;
using AHOY.Application.Service.Hotel.Contacts;
using AHOY.Infrastructure.Data.Contracts;
using AHOY.Infrastructure.Data.Entities;
using AHOY.Infrastructure.Data.Implementation;
using AutoMapper;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;

namespace AHOY.Application.Test.Services.Hotel
{
    public class HotelServiceTest
    {
        private readonly Mock<IHotelRepository> _HotelRepository;
        private readonly Mock<IMapper> _mapper;
        public HotelServiceTest()
        {
            _HotelRepository = new Mock<IHotelRepository>();
            _mapper = new Mock<IMapper>();
        }

        [Fact]
        public async Task Test_GetHotelDetailsById()
        {
            var mappingProfile = new Application.Mapper.AutoMapper();
            var mappingConfig = new MapperConfiguration(x => { x.AddProfile(mappingProfile); });
            var mapper = mappingConfig.CreateMapper();
            long hotelId = 2;
            List<Facilities> lstFacilities = new List<Facilities>();
            lstFacilities.Add(new Facilities { FacilitiesId = 1, Description = "Free WiFi", FacilitiesName = "Free WiFi" });

            List<HotelImages> lstHotelImages = new List<HotelImages>();
            lstHotelImages.Add(new HotelImages { HotelId = 1, ImageId = 1, ImageSrc = "Images/123.jpg" });
            var hotelDetail = new Hotels
            {
                HotelId = 2,
                Address = "Address",
                City = "Delhi",
                Country = "India",
                Description = "Sample Description",
                HotelName = "Test Hotel Name",
                PinCode = 110025
            };

            this._HotelRepository.Setup(x => x.GetHotelDetailsById(It.IsAny<long>())).ReturnsAsync(hotelDetail);
            this._HotelRepository.Setup(x => x.GetFacilities()).ReturnsAsync(lstFacilities);
            this._HotelRepository.Setup(x => x.GetHotelImages()).ReturnsAsync(lstHotelImages);
            var hotelService = new HotelService(_HotelRepository.Object, mapper);
            var result = await hotelService.GetHotelDetailsById(hotelId);
            Assert.NotNull(result);
        }
    }
}