using System;
using System.Globalization;
using Ex038.Entities;
using Ex038.Services;

namespace Ex038
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: "); int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyy): "); DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: "); double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, contractValue);

            Console.Write("Enter number of installments: "); int installments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
                Console.WriteLine(installment);

            Console.ReadLine();
        }
    }
}
