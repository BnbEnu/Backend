using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class Property
    {
        public Guid PropertyId { get; set; }

        [Required]
        public Guid HostId { get; set; }

        [ForeignKey("HostId")]
        public User Host { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        public string City { get; set; }

        public decimal PricePerNight { get; set; }

        public int MaxGuests { get; set; }

        public bool IsVerified { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Related tables
        public ICollection<PropertyImage> Images { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Amenity> Amenities { get; set; }
    }
}