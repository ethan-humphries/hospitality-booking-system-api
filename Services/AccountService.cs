using HBSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface IAccountService
    {
        Account CreateAccount(Account account);

        Account UpdateAccount(Account account);

        void DeactivateAccount(int accountId);

        Account Authorize(string email, string password);
    }

    public class AccountService : IAccountService
    {
        private readonly HBSContext hbsContext;

        public AccountService(HBSContext hbsContext)
        {
            this.hbsContext = hbsContext;
        }

        public Account CreateAccount(Account account)
        {
            hbsContext.Account.Add(account);
            hbsContext.SaveChanges();

            return account;
        }

        public Account UpdateAccount(Account account)
        {
            var entity = hbsContext.Account.Where(x => x.Id == account.Id)
                .SingleOrDefault();

            entity = account;
            hbsContext.SaveChanges();
            return entity;
        }

        public void DeactivateAccount(int accountId)
        {
            var entity = hbsContext.Account.Where(x => x.Id == accountId)
                .SingleOrDefault();
            // add status for active por inactive to db context
        }

        public Account Authorize(string email, string password)
        {
            return hbsContext.Account.Where(x => x.Email.Equals(email) && x.Password.Equals(password))
                .SingleOrDefault();
        }
    }
}
