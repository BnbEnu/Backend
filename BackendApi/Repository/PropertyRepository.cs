using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Data;
using BackendApi.Dto.PropertyDto;
using BackendApi.Interface;
using BackendApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly AppDbContext _context;
        public PropertyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Property?> CreateAsync(Property property)
        {
            await _context.properties.AddAsync(property);
            await _context.SaveChangesAsync();
            return property;
        }

        public async Task<Property?> DeleteAsync(Guid id)
        {
            var property = await _context.properties.FirstOrDefaultAsync(c => c.PropertyId == id);
            if (property == null) return null;

            _context.properties.Remove(property);
            await _context.SaveChangesAsync();
            return property;
        }

        public async Task<List<Property>> GetAllAsync()
        {
            return await _context.properties.ToListAsync();
        }

        public async Task<Property?> GetByIdAsync(Guid id)
        {
            var property = await _context.properties.FirstOrDefaultAsync(c => c.PropertyId == id);
            if (property == null) return null;
            return property;
        }

        public async Task<Property?> UpdateAsync(Guid id, UpdatePropertyDto property)
        {
            var propertyModel = await _context.properties.FirstOrDefaultAsync(c => c.PropertyId == id);
            if (propertyModel == null) return null;

            if (!string.IsNullOrEmpty(property.Title)) propertyModel.Title = property.Title;
            if (!string.IsNullOrEmpty(property.Description)) propertyModel.Description = property.Description;
            if (!string.IsNullOrEmpty(property.Address)) propertyModel.Address = property.Address;
            if (!string.IsNullOrEmpty(property.City)) propertyModel.City = property.City;
            if (property.MaxGuests != default) propertyModel.MaxGuests = property.MaxGuests;
            if (property.PricePerNight != default) propertyModel.PricePerNight = property.PricePerNight;

            await _context.SaveChangesAsync();
            return propertyModel;
        }

        public async Task<bool> UpdateVerified(Guid id)
        {
            var property = await _context.properties.FirstOrDefaultAsync(c => c.PropertyId == id);
            if (property == null) return false;

            property.IsVerified = true;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}