using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LPR
{
 class Program
  {
   static void Main()
    {
      int num = 0;
      int soma = 0;
      int digito =0;

        Console.Clear();
        
        Console.WriteLine("Digite um número:");
        num = Convert.ToInt32(Console.ReadLine());
        int quadrado = num * num;

        while(quadrado > 0)
            {
                digito = quadrado % 10;
                soma += digito;
                quadrado /= 10;
            }

          Console.WriteLine("A soma dos dígitos do quadrado é: " + soma);

    }
  }
}
