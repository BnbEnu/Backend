using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BackendApi.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<Property> Properties { get; set; } = new List<Property>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}