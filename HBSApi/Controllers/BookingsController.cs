using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBSApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HBSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetBookingsByUserId(int userId)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void NewBooking([FromBody] BookingModel booking)
        {
        }

        // PUT api/values/5
        [HttpPut("{bookingId}")]
        public void UpdateBooking(int bookingId, [FromBody] BookingModel booking)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{bookingId}")]
        public void DeleteBooking(int bookingId)
        {
        }

        //FILTER bookings
        [HttpPost("{bookingId}/{fromDate}/{toDate}")]
        public ActionResult<BookingModel[]> FilterBookingsByDate(int userId, DateTime fromDate, DateTime toDate)
        {
            var bookings = new BookingModel[0];
            return bookings;
        }
    }
}
