using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Dto.PropertyImageDto;
using BackendApi.Models;

namespace BackendApi.Dto.PropertyDto
{
    public class ViewPropertyDto
    {
        public Guid PropertyId { get; set; }
        public Guid HostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public decimal PricePerNight { get; set; }
        public int MaxGuests { get; set; }
        public bool IsVerified { get; set; } = false;
        public List<ViewPropertyImageDto> Images { get; set; } = new List<ViewPropertyImageDto>();
       
    }
}