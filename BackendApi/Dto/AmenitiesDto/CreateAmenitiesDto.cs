using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BackendApi.Dto.Amenities
{
    public class CreateAmenitiesDto
    {
        [Required]
        public required string Name { get; set; }
    }
}