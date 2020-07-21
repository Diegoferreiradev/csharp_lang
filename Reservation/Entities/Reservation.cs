using System;
using Reservations.Entities.Exceptions;

namespace Reservations.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (Checkout <= CheckIn)
            {
                throw new ReservationException("Check-Out must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (CheckIn < now || Checkout < now)
            {
                throw new ReservationException("Reservation dates for updates must be future dates");
            }
            if (Checkout <= CheckIn)
            {
                throw new ReservationException("Check-Out must be after check-in date");
            }

            CheckIn = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}, " +
                   $"check-in: {CheckIn.ToString("dd/MM/yyyy")} " +
                   $"check-out: {Checkout.ToString("dd/MM/yyyy")}, " +
                   $"{Duration()} nights";
        }

      
    }
}
