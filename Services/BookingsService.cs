using HBSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface IBookingsService
    {
        BookingModel[] GetBookings(string clientId);

        BookingModel UpdateBooking(string clientId, BookingModel booking);

        BookingModel AddBooking(string clientId, BookingModel booking);

        bool DeleteBooking(string clientId, int bookingId);
    }

    public class BookingsService : IBookingsService
    {
        // private readonly database context
        public BookingsService( /* inject database context */)
        {

        }

        public BookingModel[] GetBookings(string clientId)
        {
            return new BookingModel[0];
        }

        public BookingModel UpdateBooking(string clientId, BookingModel booking)
        {
            return new BookingModel();
        }

        public BookingModel AddBooking(string clientId, BookingModel booking)
        {
            return new BookingModel();
        }

        public bool DeleteBooking(string clientId, int bookingId)
        {
            return true;
        }
    }
}
