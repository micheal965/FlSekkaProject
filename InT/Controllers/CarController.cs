//using Int.Core.DTOs.Cars;
//using Int.Core.Services.Contrct;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace InT.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CarController : ControllerBase
//    {
//        private readonly ICarService _carService;

//        public CarController(ICarService carService)
//        {
//            _carService = carService;
//        }
//[Authorize(Roles = "admin")]

//[HttpGet]
//        public async Task<IActionResult> GatAllCars()
//        

//            var rsult = await _carService.GetAllCarsAsync();
//            return Ok(rsult);
//        }

//        [HttpGet("Brands")]
//        public async Task<IActionResult> GatAllBrans()
//        {
//            var result = await _carService.GetAllBrandsAsync();
//            return Ok(result);
//        }
//        [HttpGet("Colors")]
//        public async Task<IActionResult> GatAllColors()
//        {
//            var result = await _carService.GetAllCarsAsync();
//            return Ok(result);
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetCarById(int? id)
//        {
//            if (id is null) return BadRequest("Invalid Id");

//            var result = await _carService.GetCarByIdAsync(id.Value);

//            if (result is null) return NotFound("car with this id is not found");
//            return Ok(result);
//        }

//        [HttpPost("upload")]
//        public async Task<IActionResult> UploadCar([FromForm] UploadCarDTO carDto)
//        {
//            try
//            {
//                var car = await _carService.UploadCarAsync(carDto);
//                return Ok(new { Message = "Car uploaded successfully", CarId = car.CId });
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(new { Message = "Error uploading car", Error = ex.Message });
//            }
//        }
//    }
//}
