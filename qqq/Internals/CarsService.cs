using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using System.Collections.Generic;

namespace Cars.BLL.Internals
{
    internal class CarsService : ICarsServices
    {
        public CarDto GetCar(long id)
        {
            return new CarDto() { Id=id, Name = "Mashinka", Description = "all hello i`ts test" };
        }

        public List<CarDto> GetCars()
        {
            var result = new List<CarDto>
            {
                GetCar(1)
            };

            return result;
        }
    }
}
