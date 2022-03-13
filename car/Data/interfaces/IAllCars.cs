using System.Collections.Generic;

namespace car.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetObjectCar(int carId);
    }
}
