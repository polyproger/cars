using Cars.BLL.Dtos;
using System.Collections.Generic;

namespace Cars.BLL.Contracts
{
    public interface ICarsServices
    {
        CarDto GetCar(long id);

        List<CarDto> GetCars();
    }
}
