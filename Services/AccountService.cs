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

        bool DeactivateAccount(Account account);

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
            var entity = hbsContext.Account.Add(account);
            hbsContext.SaveChanges();

            return entity.Entity;
        }

        public Account UpdateAccount(Account account)
        {
            var entity = hbsContext.Account.Update(account);
            hbsContext.SaveChanges();
            return entity.Entity;
        }

        public bool DeactivateAccount(Account account)
        {
            var entity = hbsContext.Account.Where(x => x.Id == account.Id)
                .SingleOrDefault();

            return true;
            // add status for active por inactive to db context
        }

        public Account Authorize(string email, string password)
        {
            return hbsContext.Account.Where(x => x.Email.Equals(email) && x.Password.Equals(password))
                .SingleOrDefault();
        }
    }
}
