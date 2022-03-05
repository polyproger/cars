using Microsoft.AspNetCore.Mvc;
using car.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace car.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase 
    {
        private readonly IAllCars _allCars;

        public CarsController(IAllCars iAllCars)
        {
            _allCars = iAllCars;
        }
        [HttpGet("")]
        [ProducesResponseType(typeof(CarsListViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение Автомобилей, категорий")]
        public IActionResult List()
        {
            var obj = new CarsListViewModel
            {
                AllCars = _allCars.Cars,
                currCategory = "Автомонстры"
            };

            return Ok(obj); // возвращает вью - некая хтмл страница, нужно на неё передать данные 
        }
    }
}
