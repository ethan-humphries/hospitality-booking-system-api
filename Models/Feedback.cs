using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class Feedback
    {
        public string Id { get; set; }
        public string BookingId { get; set; }
        public string CustomerId { get; set; }
        public string StaffId { get; set; }
        public string Feedback1 { get; set; }
        public DateTime? Date { get; set; }
        public int? Rating { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
