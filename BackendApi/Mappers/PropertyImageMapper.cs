using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.PropertyImageDto;
using BackendApi.Models;

namespace BackendApi.Mappers
{
    public static class PropertyImageMapper
    {
        public static PropertyImage ToPropertyImageDto(this CreatePropertyImageDto create)
        {
            return new PropertyImage
            {
                PropertyId = create.propertyId,
                ImageUrl = create.ImageUrl,
            };
        }
        public static ViewPropertyImageDto ToPropertyImageDto(this PropertyImage propertyImage)
        {
            return new ViewPropertyImageDto
            { 
                ImageUrl = propertyImage.ImageUrl,
            };
        }
    }
}