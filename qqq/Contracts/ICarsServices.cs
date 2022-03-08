using Cars.BLL.Dtos;
using System.Collections.Generic;

namespace Cars.BLL.Contracts
{
    public interface ICarsServices
    {
       
        CarDto GetCar();

        List<CarDto> GetCars();
    }
}
