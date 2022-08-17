using System;

namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você irá comprar? ");
            double quantidadeDolares = double.Parse(Console.ReadLine());

            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.Dolar(cotacao, quantidadeDolares):F2}");

            Console.ReadLine();
        }
    }
}
