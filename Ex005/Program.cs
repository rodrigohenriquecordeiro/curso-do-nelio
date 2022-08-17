using System;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Código da Peça 1: "); int codPeca1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Quantidade: "); int quantPeca1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Valor Unitário: "); double precoPeca1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nCódigo da Peça 2: "); int codPeca2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Quantidade: "); int quantPeca2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Valor Unitário: "); double precoPeca2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nTotal da Compra: R$ {quantPeca1 * precoPeca1 + quantPeca2 * precoPeca2:C}.");

            Console.ReadLine();
        }
    }
}
