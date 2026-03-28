using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR
{
 class Program
  {
   static void Main()
    {
      Console.Clear();

      Random numAleatorio = new Random();
      int num = numAleatorio.Next(1,100);
      int chute;
      int tentativa = 0;

      Console.WriteLine("Um número aleatório entre 1 e 100 for sorteado, tente adivinhar!");
      chute = int.Parse(Console.ReadLine());
      tentativa++;

      do
      { 
        if (chute > num)
        {
          Console.WriteLine("Chutou alto, tente novamente");
        }
        else
        {
          Console.WriteLine("Chutou baixo, tente novamente");
        }
        
        chute = int.Parse(Console.ReadLine());     
        tentativa++;
        
      } 
        while (chute!=num);

        Console.WriteLine($"Parabéns, você acertou o número em {tentativa} tentativas!");
    }
  }
}
