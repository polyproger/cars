using car.Data.Models;
using System.Collections.Generic;

namespace car.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
