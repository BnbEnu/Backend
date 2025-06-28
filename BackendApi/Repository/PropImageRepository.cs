using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Data;
using BackendApi.Dto.PropertyImageDto;
using BackendApi.Interface;
using BackendApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Repository
{
    public class PropImageRepository : IPropImageRepository
    {
        private readonly AppDbContext _context;
        public PropImageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PropertyImage> CreatePropertyImageAsync(PropertyImage propertyImage)
        {
            await _context.propertyImages.AddAsync(propertyImage);
            await _context.SaveChangesAsync();

            return propertyImage;
        }

        public async Task<PropertyImage?> DeletePropertyImageAsync(Guid id)
        {
            var image = await _context.propertyImages.FirstOrDefaultAsync(c => c.PropertyImageId == id);
            if (image == null) return null;

            _context.propertyImages.Remove(image);
            await _context.SaveChangesAsync();

            return image;
        }

        public async Task<List<PropertyImage>> GetPropertyImagesAsync(Guid id)
        {
            return await _context.propertyImages
                .Where(c => c.PropertyId == id)
                .ToListAsync();
        }

        public async Task<PropertyImage?> UpdatePropertyImageAsync(Guid id, UpdatePropertyImageDto update)
        {
            var propertyImage = await _context.propertyImages.FirstOrDefaultAsync(c => c.PropertyImageId == id);
            if (propertyImage == null) return null;
            if (!string.IsNullOrWhiteSpace(update.ImageUrl)) propertyImage.ImageUrl = update.ImageUrl;

            return propertyImage;
        }
    }
}