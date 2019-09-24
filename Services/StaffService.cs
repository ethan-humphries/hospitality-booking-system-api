using HBSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface IStaffService
    {
        List<Staff> GetStaff(int accountId);

        Staff UpdateStaff(Staff staff);

        Staff AddStaff(Staff staff);

        bool DeleteStaff(Staff staff);
    }

    public class StaffService : IStaffService
    {
        private readonly HBSContext hbsContext;
        public StaffService(HBSContext hbsContext)
        {
            this.hbsContext = hbsContext;
        }

        public List<Staff> GetStaff(int accountId)
        {
            return hbsContext.Staff.Where(x => x.AccountId == accountId).ToList();
        }

        public Staff UpdateStaff(Staff staff)
        {
            var entity = hbsContext.Staff.Update(staff);
            hbsContext.SaveChanges();
            return entity.Entity;

        }

        public Staff AddStaff(Staff staff)
        {
            var entity = hbsContext.Staff.Add(staff);
            hbsContext.SaveChanges();
            return entity.Entity;
        }

        public bool DeleteStaff(Staff staff)
        {
            hbsContext.Staff.Remove(staff);
            hbsContext.SaveChanges();
            return true;
        }
    }
}
