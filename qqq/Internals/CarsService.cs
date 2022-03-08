using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using System.Collections.Generic;

namespace Cars.BLL.Internals
{
    internal class CarsService : ICarsServices
    {


        public CarDto GetCar()
        {
            return new CarDto() { Id=15, Name = "Mashinka", Description ="all hello i`ts test"};

        }
        public List<CarDto> GetCars()
        {
            var result = new List<CarDto>
            {
                GetCar()
            };
            return result;
        }
    }
}
