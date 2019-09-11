using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface IStaffService
    {
        string /*Staff[] */ GetStaff(string accountId);

        string /* Staff */ UpdateStaff(string accountId /* Staff staff */);

        string /* Staff */ AddStaff(string accountId /* Staff staff */);

        bool DeleteStaff(string accountId, int staffId);
    }

    public class StaffService : IStaffService
    {
        public StaffService()
        {

        }

        public string /*Customer[] */ GetStaff(string accountId)
        {
            return "";
        }

        public string /*Customer */ UpdateStaff(string accountId /* Staff staff */)
        {
            return "";
        }

        public string /*Customer */ AddStaff(string accountId /* Staff staff */)
        {
            return "";
        }

        public bool DeleteStaff(string accountId, int staffId)
        {
            return true;
        }
    }
}
