using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Data;
using BackendApi.Dto.AmenitiesDto;
using BackendApi.Interface;
using BackendApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Repository
{
    public class AmenityRepository : IAmenityRepository
    {
        private readonly AppDbContext _context;
        public AmenityRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Amenity> CreateAsync(Amenity amenityModel)
        {
            await _context.amenities.AddAsync(amenityModel);
            await _context.SaveChangesAsync();
            return amenityModel;

        }

        public async Task<Amenity?> DeleteAsync(Guid id)
        {
            var amenity = await _context.amenities.FirstOrDefaultAsync(x => x.AmenityId == id);
            if (amenity == null) return null;
            _context.amenities.Remove(amenity);
            await _context.SaveChangesAsync();

            return amenity;
        }

        public async Task<List<Amenity>> GetAllAsync()
        {
            return await _context.amenities.ToListAsync();
        }

        public async Task<Amenity?> GetByIdAsync(Guid id)
        {
            return await _context.amenities.FirstOrDefaultAsync(c => c.AmenityId == id);
            
        }

        public async Task<Amenity?> UpdateAsync(Guid id, UpdateAmenitiesDto updateAmenitiesDto)
        {
            var amenity = await _context.amenities.FirstOrDefaultAsync(c => c.AmenityId == id);
            if (amenity == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(updateAmenitiesDto.Name))
            {
                amenity.Name = updateAmenitiesDto.Name;
            }

            await _context.SaveChangesAsync();
            return amenity;
        }
    }
}