using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BackendApi.Dto.AmenitiesDto
{
    public class UpdateAmenitiesDto
    {
        [Required]
        public string Name { get; set; }
    }
}