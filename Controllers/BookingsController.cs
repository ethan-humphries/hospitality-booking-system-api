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

        [HttpGet("{accountId}")]
        public IActionResult GetBookingsByUserId(int accountId)
        {
            try
            {
                var result = _bookingsService.GetBookings(accountId);
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

        [HttpPost]
        public IActionResult NewBooking([FromBody] Booking booking)
        {
            try
            {
                var result = _bookingsService.AddBooking(booking);
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

        [HttpPut]
        public IActionResult UpdateBooking([FromBody] Booking booking)
        {
            if (booking == null) {
                throw new Exception();
            }

            try {
               var result = _bookingsService.UpdateBooking(booking);
               return  Ok(result);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpDelete("{bookingId}")]
        public void DeleteBooking([FromBody] Booking booking)
        {
            if (booking == null) {
                throw new Exception("No booking in request");
            }

            try {
                _bookingsService.DeleteBooking(booking);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost("{bookingId}/{fromDate}/{toDate}")]
        public ActionResult<Booking[]> FilterBookingsByDate(int accountId, DateTime fromDate, DateTime toDate)
        {
            var bookings = new Booking[0];
            return bookings;
        }
    }
}
