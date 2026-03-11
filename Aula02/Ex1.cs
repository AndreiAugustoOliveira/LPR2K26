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

            float raio, pi, circunferencia;
            pi = 3.14159f;
     
            Console.WriteLine("Digite o raio da circunferência");
            raio = float.Parse(Console.ReadLine());
            circunferencia = pi * (raio * raio);
            Console.WriteLine($"A área da circunferênica é {circunferencia:F4}");
        }
    }
}
