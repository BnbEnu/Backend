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
        public User Host { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public decimal PricePerNight { get; set; }
        public int MaxGuests { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<PropertyImage> Images { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Amenities> Amenities { get; set; }
    }
}