using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public Guid BookingId { get; set; }
        public Booking? Booking { get; set; }
        public int Rating { get; set; }
        public string? ReviewText { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}