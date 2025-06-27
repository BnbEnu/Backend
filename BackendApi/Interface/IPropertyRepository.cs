using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.PropertyDto;
using BackendApi.Models;

namespace BackendApi.Interface
{
    public interface IPropertyRepository
    {
        Task<List<Property>> GetAllAsync();
        Task<Property?> GetByIdAsync(Guid id);
        Task<Property?> CreateAsync(Property property);
        Task<Property?> UpdateAsync(Guid id, UpdatePropertyDto property);
        Task<bool> UpdateVerified(Guid id);
        Task<Property?> DeleteAsync(Guid id);
    }
}