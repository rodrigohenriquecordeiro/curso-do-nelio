using System;

namespace ExerciciosDeFixacao06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: "); int numeroDaConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: "); string titular = Console.ReadLine().Trim().ToUpper();
            Console.Write("Haverá depósito inicial (s/n)? "); char depositoInicial = char.Parse(Console.ReadLine().Trim().ToUpper());

            Conta conta = new Conta(numeroDaConta, titular);

            if (depositoInicial == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: "); double valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);
            }
            else conta.Depositar(0);

            Console.WriteLine($"\nDados da conta:\n{conta}");

            Console.Write("\nEntre um valor para depósito: "); conta.Depositar(double.Parse(Console.ReadLine()));
            Console.Write($"Dados da conta atualizados:\n{conta}\n");

            Console.Write("\nEntre um valor para saque: "); conta.Sacar(double.Parse(Console.ReadLine()));
            Console.Write($"Dados da conta atualizados:\n{conta}");

            Console.ReadLine();
        }
    }
}
