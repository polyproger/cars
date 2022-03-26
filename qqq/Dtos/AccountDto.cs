using System;

namespace Cars.BLL.Dtos
{
    public class AccountDto
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
