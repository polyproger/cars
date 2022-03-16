using System.Collections.Generic;

namespace car.Data.mocks
{
    public class MockCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Электрички" ,Desc = "@$! - что-то на богатом"},
                    new Category {CategoryName = "Мафынки" ,Desc = "Может позволить любой у кого зарплата более 12кРублс"}
                };
            }
        }
    }
}
