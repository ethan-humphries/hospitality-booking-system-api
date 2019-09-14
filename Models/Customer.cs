using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
            Feedback = new HashSet<Feedback>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string History { get; set; }
        public string DietryRequirements { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}
