using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do Código? ");
            int codigo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantidade? ");
            int quantidade = Convert.ToInt16(Console.ReadLine());

            string escolha = ""; double preco = 0;
            switch (codigo)
            {
                case 1:
                    escolha = "Cachorro-Quente";
                    preco = 4.00;
                    break;
                case 2:
                    escolha = "X-Salada";
                    preco = 4.50;
                    break;
                case 3:
                    escolha = "X-Bacon";
                    preco = 5.00;
                    break;
                case 4:
                    escolha = "Torrada Simples";
                    preco = 2.00;
                    break;
                case 5:
                    escolha = "Refrigerante";
                    preco = 1.50;
                    break;
            }

            double total = preco * quantidade;
            Console.WriteLine($"{quantidade} {escolha} = R$ {total:C}");
        }
    }
}
