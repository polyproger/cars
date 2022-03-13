using System.Collections.Generic;

namespace car.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string CurrCategory { get; set; }
    }
}
