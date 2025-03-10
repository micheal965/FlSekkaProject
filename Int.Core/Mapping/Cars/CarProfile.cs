using AutoMapper;
using Int.Core.DTOs.Cars;
using Int.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Int.Core.Mapping.Cars
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDTO>()
                .ForMember(d => d.BrandName, option => option.MapFrom(s => s.BCodeNavigation))
                .ForMember(d => d.ColorName, option => option.MapFrom(s => s.CCodeNavigation))
                .ForMember(d => d.CarPhotos, option => option.MapFrom(s => $"/{s.CarPhotos}"));

            CreateMap<Brand, BrandDTO>()
                .ForMember(d => d.BrandCode, option => option.MapFrom(s => s.BCode))
                .ForMember(d => d.BrandName, option => option.MapFrom(s => s.BName));


            CreateMap<Color, ColorDTO>()
                .ForMember(d => d.ColorCode, option => option.MapFrom(s => s.CCode))
                .ForMember(d => d.ColorName, option => option.MapFrom(s => s.CName));


            //        CreateMap<UploadCarDTO, Car>()
            //         .ForMember(dest => dest.CId, opt => opt.Ignore())
            //          .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            //          .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            //          .ForMember(dest => dest.CPlateNumber, opt => opt.MapFrom(src => src.PlateNumber))
            //          .ForMember(dest => dest.CCode, opt => opt.MapFrom(src => src.ColorCode))
            //          .ForMember(dest => dest.BCode, opt => opt.MapFrom(src => src.BrandCode))
            //           .ForMember(dest => dest.CarPhotos, opt => opt.MapFrom(src =>
            //          src.photourl.Select(url => new CarPhoto { PhotoUrl = url }).ToList()
            //));



        }
    }
}
