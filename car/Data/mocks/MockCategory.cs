using car.Data.interfaces;
using car.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace car.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электрички" ,desc = "@$! - что-то на богатом"},
                    new Category {categoryName = "Мафынки" ,desc = "Может позволить любой у кого зарплата более 12кРублс"}
                };
            }
        }
    }
}
