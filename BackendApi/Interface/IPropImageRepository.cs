using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.PropertyImageDto;
using BackendApi.Models;

namespace BackendApi.Interface
{
    public interface IPropImageRepository
    {
        Task<List<PropertyImage>> GetPropertyImagesAsync(Guid id);
        Task<PropertyImage> CreatePropertyImageAsync(PropertyImage propertyImage);
        Task<PropertyImage?> UpdatePropertyImageAsync(Guid id, UpdatePropertyImageDto update);
        Task<PropertyImage?> DeletePropertyImageAsync(Guid id);
    }
}