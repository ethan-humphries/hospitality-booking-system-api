using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Booking = new HashSet<Booking>();
            Feedback = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}
