using Cars.BLL.Dtos;
using System.Collections.Generic;

namespace Cars.BLL.Contracts
{
    public interface IAccountsServices
    {
        AccountDto CreateAccount(CreateAccountDto createAccountDto);
        AccountDto GetIdAccount(long id);
        AccountDto GetLogPas(string login, string password);

    }
}
