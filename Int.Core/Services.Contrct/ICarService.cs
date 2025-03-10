using Int.Core.DTOs.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.Services.Contrct
{
    public interface ICarService
    {
        //  Task<IEnumerable<CarDTO>> GetAllCarsAsync();
        //Task<IEnumerable<BrandDTO>> GetAllBrandsAsync();
        //   Task<IEnumerable<ColorDTO>> GetAllColorsAsync();
        //     Task<CarDTO> GetCarByIdAsync(int id);

        Task<CarDTO> UploadCarAsync(UploadCarDTO carDto);

        //Task<CarDTO> AddCarAsync(CarUploadDTO carDto);


    }
}
