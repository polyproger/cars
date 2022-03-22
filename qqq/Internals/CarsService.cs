using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using Mapster;
using System.Collections.Generic;
using System.Linq;

namespace Cars.BLL.Internals
{
    internal class CarsService : ICarsServices
    {
        private static List<CarDto> _cars = new List<CarDto>();

        public CarDto AddCar(AddCarDto addCarDto)
        {
            var newCar = addCarDto.Adapt<CarDto>();
            newCar.Id = _cars.Count + 1;
            _cars.Add(newCar);
            return newCar;
        }

        public CarDto GetCar(long id)
        {
            return _cars.FirstOrDefault(x => x.Id == id);
        }

        public List<CarDto> GetCars()
        {
            return _cars;
        }
    }
}
