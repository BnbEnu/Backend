using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.Amenities;
using BackendApi.Dto.AmenitiesDto;
using BackendApi.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BackendApi.Mappers
{
    public static class AmenityMapper
    {
        public static Amenity ToAmnenity(this CreateAmenitiesDto create)
        {
            return new Amenity
            {
                Name = create.Name,
            };
        }

        public static ViewAmenitiesDto viewAmenitiesDto(this Amenity amenity)
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            return new ViewAmenitiesDto
            {
                Name = amenity.Name,
            };
#pragma warning restore CS8601 // Possible null reference assignment.
        }
    }
}