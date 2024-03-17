using CreatingExceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreatingExceptions.Entities
{
    internal class Reservation
    {
        public int RoomNuber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() 
        {
        }

        public Reservation(int roomNuber, DateTime checkIn, DateTime checkOut)
        {

            if (checkOut <= checkIn)
            {
                throw new DomainExcpetion("Error in servation");
            }

            RoomNuber = roomNuber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainExcpetion ( "Error in reservation");
            }
            if (checkOut <= checkIn)
            {
              throw new DomainExcpetion("Error in servation");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }

        public override string ToString()
        {
            return "Room " + RoomNuber + ", Check-In: " + CheckIn.ToString("dd/MM/yyyy") + ", Check-Out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + "Nights";
        }
    }
}
