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
      
      int [] numeros = new int[10];
      int digitado = 0;
      int i = 0;
      int contador = 0;


      Console.Clear();
      Console.WriteLine("Digite 10 números inteiros: ");
      
      for ( i = 0; i < 10; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite um número que deseja procurar no vetor: ");
            digitado = Convert.ToInt32(Console.ReadLine());

            for ( i = 0; i < 10; i++)
            {
                if (numeros[i] == digitado)
                {
                    Console.WriteLine("O número " + digitado + " foi encontrado na posição " + i);
                    contador++;
                }
            }

            Console.WriteLine("O número " + digitado + " foi encontrado " + contador + " vezes no vetor.");

    }
  }
}
