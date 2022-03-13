using Microsoft.AspNetCore.Mvc;
using car.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using Mapster;

namespace car.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        
        private readonly ICarsServices _carsServices;

        
        public CarsController(ICarsServices carsService) => _carsServices = carsService;

        [HttpGet("")]
        [ProducesResponseType(typeof(CarViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение Автомобилей ")]
        public IActionResult GetCar()
        {
            var destObject = _carsServices.Adapt<CarViewModel>();
            _carsServices.Adapt(destObject);
            var destinations = destObject; // - хуй пойму и рабоает с ним и без него
             return Ok(destinations);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<CarViewModel>), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение листа автомобилей ")]
        public IActionResult GetCars()
        {
            var cars = _carsServices.Adapt<CarViewModel>();
            _carsServices.Adapt(cars);
            var result = cars;
            return Ok(result);
            //  var cars = _carsServices.GetCars();
            //  var result = new List<CarViewModel>();
            //      foreach (var car in cars)
            //  {
            //     var destObject = result.Adapt<CarViewModel>();
            //     var ViewModel = new CarViewModel() { Id = car.Id, Description = car.Description, Name = car.Name };
            //    result.Add(ViewModel);
            // }
        }
    }
}
