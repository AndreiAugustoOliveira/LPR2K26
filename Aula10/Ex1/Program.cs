using System;

namespace LPR {

public class Triangulo
    {
        public double altura;
        public double basetriangulo;
        public double lado1triangulo;
        public double lado2triangulo;

        public double CalcA()
        {
            return (altura * basetriangulo) / 2;
        }

        public double CalcP()
        {
            return lado1triangulo + lado2triangulo + basetriangulo;
        }


    }
class Program
{
    static void Main()
    {
        Triangulo triangulo = new Triangulo();
        Console.WriteLine("Digite a altura do triângulo:");
        triangulo.altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a base do triângulo:");
        triangulo.basetriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o lado 1 do triângulo:");
        triangulo.lado1triangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o lado 2 do triângulo:");
        triangulo.lado2triangulo = Convert.ToDouble(Console.ReadLine());

        double area = triangulo.CalcA();
        double perimetro = triangulo.CalcP();
        Console.WriteLine($"O perímetro do triângulo é: {perimetro}");
        Console.WriteLine($"A área do triângulo é: {area}");

    }

}

}


    
