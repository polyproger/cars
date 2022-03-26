using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars.BLL.Internals
{
    internal class AccountsService : IAccountsServices
    {
        private static List<AccountDto> _accounts = new List<AccountDto>();
        public AccountDto CreateAccount(CreateAccountDto createAccountDto)
        {
            var addAccount = createAccountDto.Adapt<AccountDto>();
            addAccount.Id = _accounts.Count + 1;
            addAccount.DateCreate = DateTime.Now;
            _accounts.Add(addAccount);
            return addAccount;
        }

        public AccountDto GetIdAccount(long id)
        {
           return _accounts.FirstOrDefault(x => x.Id == id);
        }

        public AccountDto GetLogPas(string login, string password)
        {
            AccountDto account = new AccountDto();
            account.DateCreate = System.DateTime.Now;
            account.Login = login;
            account.Password = password;
            _accounts.Add(account);
            return account;
        }                   
    }
}
