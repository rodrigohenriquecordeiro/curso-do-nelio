using System;
using System.Collections.Generic;

namespace Ex039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> total = new HashSet<int>();

            HashSet<int> cursoA = new HashSet<int>();
            Console.Write("How many students for course A? "); int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                cursoA.Add(int.Parse(Console.ReadLine()));
            total.UnionWith(cursoA);

            HashSet<int> cursoB = new HashSet<int>();
            Console.Write("How many students for course B? "); int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
                cursoB.Add(int.Parse(Console.ReadLine()));
            total.UnionWith(cursoB);

            HashSet<int> cursoC = new HashSet<int>();
            Console.Write("How many students for course C? "); int c = int.Parse(Console.ReadLine());
            for (int i = 1; i <= c; i++)
                cursoC.Add(int.Parse(Console.ReadLine()));
            total.UnionWith(cursoC);
            
            Console.Write($"Total students: {total.Count}");
        }
    }
}
