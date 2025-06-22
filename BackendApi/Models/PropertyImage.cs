using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class PropertyImage
    {
        public Guid PropertyImageId { get; set; }

        [Required]
        public Guid PropertyId { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        [Required]
        public string ImageUrl { get; set; } 
    }
}