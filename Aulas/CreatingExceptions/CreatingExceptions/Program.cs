using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingExceptions.Entities;
using CreatingExceptions.Entities.Exceptions;

namespace CreatingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("check-in Dat(dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out Dat(dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("check-in Dat(dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out Dat(dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);


                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation:" + reservation);
            }catch (DomainExcpetion ex)
            {
                Console.WriteLine("error in reservation: " + ex.Message);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("format error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
