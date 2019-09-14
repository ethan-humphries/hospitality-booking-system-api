using System;
using System.Collections.Generic;

namespace HBSApi.Models
{
    public partial class Booking
    {
        public Booking()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public int StaffId { get; set; }
        public int? CustomerId { get; set; }
        public string BookingName { get; set; }
        public DateTime? BookingDate { get; set; }
        public TimeSpan? Time { get; set; }
        public string Duration { get; set; }
        public int? NumberOfPeople { get; set; }
        public string TableNumber { get; set; }
        public int? Status { get; set; }
        public bool? CheckedIn { get; set; }
        public string Notes { get; set; }
        public bool? Highchair { get; set; }
        public bool? Wheelchair { get; set; }
        public string DietryRequirements { get; set; }
        public bool? Vegetarian { get; set; }
        public bool? GlutenFree { get; set; }
        public bool? DairyFree { get; set; }
        public bool? Other { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual BookingStatus StatusNavigation { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}
