using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.PropertyDto;
using BackendApi.Models;

namespace BackendApi.Mappers
{
    public static class PropertyMapper
    {
        public static Property ToProperty(this CreatePropertyDto create)
        {
            return new Property
            {
                HostId = create.HostId,
                Title = create.Title,
                Description = create.Description,
                Address = create.Address,
                City = create.City,
                PricePerNight = create.PricePerNight,
                MaxGuests = create.MaxGuests
            };
        }
        public static ViewPropertyDto viewPropertyDto(this Property property)
        {
            return new ViewPropertyDto
            {
                PropertyId = property.PropertyId,
                HostId = property.HostId,
                Title = property.Title,
                Description = property.Description,
                Address = property.Address,
                City = property.City,
                PricePerNight = property.PricePerNight,
                MaxGuests = property.MaxGuests,
                IsVerified = property.IsVerified,
                Images = property.Images.Select(x => x.ToPropertyImageDto()).ToList(),
            };
        }
    }
}