using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBSApi.Models;
using HBSApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HBSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingsService _bookingsService;

        public BookingsController(IBookingsService bookingsService)
        {
            _bookingsService = bookingsService;
        }

        // GET api/bookings/5
        [HttpGet("{clientId}")]
        public IActionResult GetBookingsByUserId(string clientId)
        {
            try
            {
                var result = _bookingsService.GetBookings(clientId);
                if (result == null) {
                    return NotFound("No bookings found for the given clientId");
                }

                return Ok(result);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        // POST api/bookings
        [HttpPost]
        public IActionResult NewBooking(string clientId, [FromBody] BookingModel booking)
        {
            try
            {
                var result = _bookingsService.AddBooking(clientId, booking);
                if (result == null)
                {
                    return NotFound("No bookings found for the given clientId");
                }

                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        // PUT api/bookings/5
        [HttpPut("{bookingId}")]
        public void UpdateBooking(string clientId, int bookingId, [FromBody] BookingModel booking)
        {

        }

        // DELETE api/bookings/5
        [HttpDelete("{bookingId}")]
        public void DeleteBooking(string clientId, int bookingId)
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
