using System;

namespace car.ViewModels
{
    public class AccountsViewModel
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
