using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.AmenitiesDto;
using BackendApi.Models;

namespace BackendApi.Interface
{
    public interface IAmenityRepository
    {
        Task<List<Amenity>> GetAllAsync();
        Task<Amenity?> GetByIdAsync(Guid id);
        Task<Amenity> CreateAsync(Amenity amenityModel);
        Task<Amenity?> UpdateAsync(Guid id, UpdateAmenitiesDto updateAmenitiesDto);
        Task<Amenity?> DeleteAsync(Guid id);
    }
}