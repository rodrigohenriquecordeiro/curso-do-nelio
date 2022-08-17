using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"ÁREA = {r.Area():F2}");
            Console.WriteLine($"PERÍMETRO = {r.Perimetro():F2}");
            Console.WriteLine($"DIAGONAL = {r.Diagonal():F2}");

            Console.ReadLine();
        }
    }
}
