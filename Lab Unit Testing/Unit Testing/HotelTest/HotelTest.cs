using Booking;
using NUnit.Framework;
using System;

namespace HotelTest
{
    public class Tests
    {
        

        [Test]
        public void BookingWhenHotelAvailableShouldWork()
        {
            Hotel hotel = new Hotel();

            DateTime startDate = new DateTime(2022, 11, 1);
            DateTime endDate = new DateTime(2022, 11, 5);

            hotel.AddReservation(startDate, endDate);

            


            Assert.AreEqual(1, hotel.Reservations.Count, "Reservation has not been added correctly");
           
            Assert.AreEqual(startDate, hotel.Reservations[0].Start);
            Assert.AreEqual(endDate, hotel.Reservations[0].End);

        }

        [Test]
        public void MultiBookingsWhenHotelAvailableShouldWork()
        {
            Hotel hotel = new Hotel();

            DateTime startDate = new DateTime(2022, 11, 1);
            DateTime endDate = new DateTime(2022, 11, 5);

            hotel.AddReservation(startDate, endDate);

            hotel.AddReservation(startDate.AddDays(10), endDate.AddDays(10));
            hotel.AddReservation(startDate.AddDays(25), endDate.AddDays(25));
            hotel.AddReservation(startDate.AddDays(56), endDate.AddDays(56));


            Assert.AreEqual(4, hotel.Reservations.Count, "Reservation has not been added correctly");
           
        }
    }
}