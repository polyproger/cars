using car.ViewModels;
using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;

namespace car.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsServices _carsServices;

        public CarsController(ICarsServices carsService) => _carsServices = carsService;

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CarViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение автомобиля")]
        public IActionResult GetCar(long id)
        {
            var car = _carsServices.GetCar(id);
            var result = car.Adapt<CarViewModel>();

            return Ok(result);
        }

        [HttpPost("page")]
        [ProducesResponseType(typeof(List<CarViewModel>), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение автомобилей")]
        public IActionResult GetCars()
        {
            var cars = _carsServices.GetCars();
            var result = cars.Adapt<List<CarViewModel>>();
            return Ok(result);
        }
        [HttpPost("")]
        [ProducesResponseType(typeof(CarViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Добавление автомобилей")]
        public IActionResult AddCar(AddCarViewModel Add)
        {
            var addCarDto = Add.Adapt<AddCarDto>();
            var car = _carsServices.AddCar(addCarDto);
            var result = car.Adapt<AddCarViewModel>();
            return Ok(result);
        }
    }
}