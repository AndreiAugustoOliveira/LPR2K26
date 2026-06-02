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

      Console.Clear();
      
      int[,] distancia ={{0,524,521,882},{524,0,434,586},{521,434,0,429},{882,586,429,0}};
      int origem = 0;
      int destino = 1;

      while(origem!=destino)  {
      Console.WriteLine("Escolha uma das capitias do sudeste baseado nas informações a seguir:");
      Console.WriteLine("0 para Vitória");
      Console.WriteLine("1 para Belo Horizonte");
      Console.WriteLine("2 para Rio de Janeiro");
      Console.WriteLine("3 para São Paulo");

      origem = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Agora escolha outra para ser calculada a distância (se deseja sair escolha a mesma)");
 
      destino = Convert.ToInt32(Console.ReadLine());
      
      while (origem > 3 || destino > 3 || origem < 0 || destino < 0)
      {
        origem = Convert.ToInt32(Console.ReadLine());
        destino = Convert.ToInt32(Console.ReadLine());

        if (origem > 3 || destino > 3 || origem < 0 || destino < 0)
        {
          Console.WriteLine("Opção inválida! Digite novamente");
        }

      }
      
      if(origem != destino) {
      Console.WriteLine("A Ditância entre elas é: " + distancia[origem,destino]);
      }
      }

      Console.WriteLine("Programa encerrado");
    }
}

}