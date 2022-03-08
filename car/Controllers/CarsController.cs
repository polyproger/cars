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
        [SwaggerOperation(Summary = "Получение Car`ov ")]
        public IActionResult GetCar()
        {
            var car = _carsServices.GetCar();
            var result = new CarViewModel { Id = car.Id, Description = car.Description, Name = car.Name };
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CarViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение Листа Car`ov ")]
        public IActionResult GetCars()
        {
            var cars = _carsServices.GetCars();
            var result = new List<CarViewModel>();
                foreach (var car in cars)
            {
                var ViewModel = new CarViewModel() { Id = car.Id, Description = car.Description, Name = car.Name };
                result.Add(ViewModel);

            }
            return Ok(result);
        }
    }
}
