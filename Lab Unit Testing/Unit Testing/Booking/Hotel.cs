using System;
using System.Collections.Generic;
using System.Text;

namespace Booking
{
    public class Hotel
    {
        public List<Reservation> Reservations { get; set;}

        public Hotel()
        {
            Reservations = new List<Reservation>();
        }
        public void AddReservation(DateTime startDate, DateTime endDate)
        {
            foreach (var reservation in Reservations)
            {
                bool overlap = reservation.Start < endDate && startDate < reservation.End;

                if (overlap)
                {
                    throw new ArgumentException($"Hotel is already booked for {startDate} - {endDate}");
                }
            }

            Reservations.Add(new Reservation()
            { Start = startDate, End = endDate });
        }
    }
}
