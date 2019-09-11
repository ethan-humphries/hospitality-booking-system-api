using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface IAccountService
    {
        string /* Account model */ CreateAccount();

        string /* Account model */ UpdateAccount();

        string /* Account model */ DeactivateAccount();

        string /* Account model */ Authorize();
    }

    public class AccountService : IAccountService
    {
        public AccountService( /*db context */)
        {

        }

        public string /* Account model */ CreateAccount()
        {
            return "";
        }

        public string /* Account model */ UpdateAccount()
        {
            return "";
        }

        public string /* Account model */ DeactivateAccount()
        {
            return "";
        }

        public string /* Account model */ Authorize()
        {
            return "";
        }
    }
}
