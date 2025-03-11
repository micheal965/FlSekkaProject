using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.DTOs.Cars
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        //  public string? CModel { get; set; }

        public string Location { get; set; }
        public int? CPlateNumber { get; set; }
        public int? CCode { get; set; }
        public int? BCode { get; set; }
        //public string? BrandName { get; set; }
        //public string? ColorName { get; set; }
        public List<string> imageUrls { get; set; } = new List<string>();

    }
}
