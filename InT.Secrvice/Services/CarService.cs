using AutoMapper;
using Int.Core.DTOs.Cars;
using Int.Core.Entities;
using Int.Core.Services.Contrct;
using Int.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InT.Secrvice.Services
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICloudinaryServices _cloudinaryServices;
        private readonly IMapper _mapper;

        public CarService(IUnitOfWork unitOfWork, ICloudinaryServices cloudinaryServices, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _cloudinaryServices = cloudinaryServices;
            _mapper = mapper;
        }
        //public async Task<IEnumerable<CarDTO>> GetAllCarsAsync()
        //{
        //    return _mapper.Map<IEnumerable<CarDTO>>(await _unitOfWork.Repository<Car>().GetAllAsync());
        //}

        //public async Task<IEnumerable<BrandDTO>> GetAllBrandsAsync()
        //{
        //    return _mapper.Map<IEnumerable<BrandDTO>>(await _unitOfWork.Repository<Brand>().GetAllAsync());
        //}



        //public async Task<IEnumerable<ColorDTO>> GetAllColorsAsync()
        //{
        //    // return _mapper.Map<IEnumerable<ColorDTO>>(await _unitOfWork.Repository<Color>().GetAllAsync()); 
        //    var color = await _unitOfWork.Repository<Color>().GetAllAsync();
        //    var mappedcolor = _mapper.Map<IEnumerable<ColorDTO>>(color);
        //    return mappedcolor;

        //}

        //public async Task<CarDTO> GetCarByIdAsync(int id)
        //{
        //    var car = await _unitOfWork.Repository<Car>().GetByIdAsync(id);
        //    var mappedCar = _mapper.Map<CarDTO>(car);
        //    return mappedCar;

        //}

        public async Task<CarDTO> UploadCarAsync(UploadCarDTO carDto)
        {
            var car = new Car()
            {
                Description = carDto.Description,
                Location = carDto.Location,
                CPlateNumber = carDto.PlateNumber,
                CCode = carDto.ColorCode,
                BCode = carDto.BrandCode,
            };

            var CarRepo = _unitOfWork.Repository<Car>();
            //upload data to cloudinary
            if (carDto.CarPhotos != null && carDto.CarPhotos.Count > 0)
            {

                var uploadResults = await _cloudinaryServices.UploadImagesAsync(carDto.CarPhotos);
                var carImages = uploadResults.Select(result => new CarPhoto
                {
                    carId = car.Id,
                    imageUrl = result.imageUrl,
                    publicId = result.publicId,
                }).ToList();

                foreach (var carImage in carImages)
                {
                    car.CarPhotos.Add(carImage);
                }
            }
            await CarRepo.AddAsync(car);
            var result = await _unitOfWork.CompleteAsync();
            if (result > 0)
            {
                return _mapper.Map<CarDTO>(car);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
