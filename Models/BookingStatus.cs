using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class BookingStatus
    {
        public BookingStatus()
        {
            Booking = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
