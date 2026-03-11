using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int a,b,c,d,r;
            Console.WriteLine("Digite quatro números inteiros");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            r = (a * b) - (c * d);
            Console.WriteLine($"O resultado da expressão (a * b) - (c * d) é {r}");
        }
    }
}