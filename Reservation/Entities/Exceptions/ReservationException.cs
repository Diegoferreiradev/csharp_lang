using System;

namespace Reservations.Entities.Exceptions
{
    class ReservationException : ApplicationException
    {
        public ReservationException(string message) : base(message)
        {

        }
    }
}
