using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int? CustomerId { get; set; }
        public int? StaffId { get; set; }
        public string Feedback1 { get; set; }
        public DateTime? Date { get; set; }
        public int? Rating { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
