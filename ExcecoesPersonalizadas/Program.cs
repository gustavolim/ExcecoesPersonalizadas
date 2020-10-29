using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;
using System;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in (dd/MM/yyyy: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out (dd/MM/yyyy: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.WriteLine("Check-in (dd/MM/yyyy: ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out (dd/MM/yyyy: ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
