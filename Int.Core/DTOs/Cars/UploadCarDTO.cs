using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.DTOs.Cars
{
    public class UploadCarDTO
    {
        public string? Description { get; set; }
        public string Location { get; set; } = null!;
        public int? PlateNumber { get; set; }
        public int? ColorCode { get; set; }
        public int? BrandCode { get; set; }
        public List<IFormFile> CarPhotos { get; set; } = new List<IFormFile>();

    }
}
