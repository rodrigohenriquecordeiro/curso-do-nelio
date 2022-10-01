using System;
using System.Collections.Generic;
using System.IO;

namespace Ex040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rodri\OneDrive\Documentos\TI\Back-End\CSharp\Udemy\Exercicios\Ex040\in.txt";
            Dictionary<string, int> dados = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int votos = int.Parse(line[1]);

                        if (dados.ContainsKey(candidato))
                            dados[candidato] += votos;
                        else
                            dados[candidato] = votos;
                    }
                    
                    foreach (var item in dados)
                        Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
