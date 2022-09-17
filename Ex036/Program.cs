using System;
using System.Globalization;
using System.IO;

namespace Ex036
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\rodri\OneDrive\Documentos\TI\Back-End\CSharp\Udemy\Exercicios\Ex036\Arquivos\SourceFile.csv";
            string[] lines = File.ReadAllLines(sourceFile);
            var CI = CultureInfo.InvariantCulture;
            string path = @"C:\Users\rodri\OneDrive\Documentos\TI\Back-End\CSharp\Udemy\Exercicios\Ex036\Arquivos\out";
            string summary = @"C:\Users\rodri\OneDrive\Documentos\TI\Back-End\CSharp\Udemy\Exercicios\Ex036\Arquivos\out\summary.csv";

            try
            {
                Directory.CreateDirectory(path);
                using (StreamWriter sw = File.CreateText(summary))
                {
                    foreach (var line in lines)
                    {
                        lines = line.Split(',');
                        sw.WriteLine($"{lines[0]}, {(double.Parse(lines[1], CI) * double.Parse(lines[2], CI)).ToString("F2", CI)}");
                    }
                }

                Console.WriteLine("Operação Finalizada");
                Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
