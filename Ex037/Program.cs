using System;
using System.Globalization;
using Ex037.Entities;
using Ex037.Services;

namespace Ex037
{
    class Program
    {
        static void Main(string[] args)
        {
            var CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: "); string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:MM): "); DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);
            Console.Write("Pickup (dd/MM/yyyy hh:MM): "); DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);

            Console.Write("Enter price per hour: "); double hour = double.Parse(Console.ReadLine(), CI);
            Console.Write("Enter price per day: "); double day = double.Parse(Console.ReadLine(), CI);

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));
            RentalServices rentalServices = new RentalServices(hour, day, new BrazilTaxServices());
            rentalServices.processInvoice(carRental);

            Console.WriteLine($"INVOICE: {carRental.Invoice}");

            Console.ReadLine();
        }
    }
}
