using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class Amenities
    {
        public Guid AmenityId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}