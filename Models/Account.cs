using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class Account
    {
        public Account()
        {
            Staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string AccountName { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
