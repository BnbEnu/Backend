using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class Property
    {
        public Guid PropertyId { get; set; }
        public Guid HostId { get; set; }
        public User? Host { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public decimal PricePerNight { get; set; }
        public int MaxGuests { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<PropertyImage> Images { get; set; } = new List<PropertyImage>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
    }
}