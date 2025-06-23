using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class PropertyImage
    {
        public Guid PropertyImageId { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }
        public string ImageUrl { get; set; } 
    }
}