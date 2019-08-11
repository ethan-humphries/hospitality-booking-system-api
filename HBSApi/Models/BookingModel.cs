using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Models
{
    public class BookingModel
    {
        public int bBookingId { get; set; }

        public int StaffId { get; set; }

        public string BookingName { get; set; }

        public string CustomerName { get; set; }

        public Date Date { get; set; }

        public DateTime Time { get; set; }

        public string Duration { get; set; }

        public int NumberOfPeople { get; set; }

        public int Table { get; set; }

        public int Status { get; set; }

        public bool CheckedIn { get; set; }

        public string Notes { get; set; }

        public bool HighchairRequired { get; set; }

        public bool Wheelchair { get; set; }

        public string DietOther { get; set; }

        public bool Vegetarian { get; set; }

        public bool GlutenFree { get; set; }

        public bool DairyFree { get; set; }

        public string Other { get; set; }
    }
}
