using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Dto.PropertyImageDto
{
    public class CreatePropertyImageDto
    {
        public Guid propertyId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}