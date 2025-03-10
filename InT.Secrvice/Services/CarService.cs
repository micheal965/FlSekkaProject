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
        private readonly IMapper _mapper;

        public CarService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
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

        //public async Task<CarDTO> UploadCarAsync(UploadCarDTO carDto)
        //{
        //    var car = _mapper.Map<Car>(carDto); // تحويل الـ DTO إلى Entity

        //    // إضافة السيارة إلى قاعدة البيانات
        //    await _unitOfWork.Repository<Car>().AddAsync(car);
        //    await _unitOfWork.CompleteAsync();

        //    // حفظ الصور
        //    if (carDto.CarPhotos != null && carDto.CarPhotos.Any())
        //    {
        //        var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
        //        if (!Directory.Exists(uploadPath))
        //        {
        //            Directory.CreateDirectory(uploadPath);
        //        }

        //        foreach (var photo in carDto.CarPhotos)
        //        {
        //            var fileName = $"{Guid.NewGuid()}_{photo.FileName}";
        //            var filePath = Path.Combine(uploadPath, fileName);

        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await photo.CopyToAsync(stream);
        //            }

        //            var carPhoto = new CarPhoto
        //            {
        //                CId = car.CId,  // ربط الصورة بالسيارة
        //                PhotoUrl = $"uploads/{fileName}"
        //            };

        //            await _unitOfWork.Repository<CarPhoto>().AddAsync(carPhoto);
        //        }

        //        await _unitOfWork.CompleteAsync();
        //    }

        //    return _mapper.Map<CarDTO>(car);
        //}
    }
}
