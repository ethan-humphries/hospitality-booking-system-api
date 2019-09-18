using HBSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface IBookingsService
    {
        List<Booking> GetBookings(int accountId);

        Booking UpdateBooking(Booking booking);

        Booking AddBooking(Booking booking);

        void DeleteBooking(Booking booking);
    }

    public class BookingsService : IBookingsService
    {
        private readonly HBSContext hbsContext;

        public BookingsService(HBSContext hbsContext)
        {
            this.hbsContext =  hbsContext;
        }

        public List<Booking> GetBookings(int accountId)
        {
            return hbsContext.Booking.Where(x => x.Staff.AccountId == accountId).ToList();
        }

        public Booking UpdateBooking(Booking booking)
        {
            var entity = hbsContext.Booking.Where(x => x.Id == booking.Id).SingleOrDefault();
            entity = booking;
            hbsContext.SaveChanges();
            return entity;
        }

        public Booking AddBooking(Booking booking)
        {
            hbsContext.Booking.Add(booking);
            hbsContext.SaveChanges();
            return booking;
        }

        public void DeleteBooking(Booking booking)
        {
            hbsContext.Booking.Remove(booking);
            hbsContext.SaveChanges();
        }
    }
}
