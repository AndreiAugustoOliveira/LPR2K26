using System;
using System.Collections.Generic;
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

      byte escolha;
     
      Console.WriteLine("Bem vindo ao Dogma's Dragon, para começar sua jornada você deve escolher uma classe para seu avatar. Cada classe tem suas habilidades e características únicas, escolha sabiamente para enfrentar os desafios que virão pela frente!");
      Console.WriteLine("Digite um número de 1 a 3 para escolher sua classe:");
      Console.WriteLine("1 - Guerreiro");
      Console.WriteLine("2 - Mago");
      Console.WriteLine("3 - Arqueiro");  
      escolha = byte.Parse(Console.ReadLine()); 


      switch (escolha)
      {
        case 1:
          Console.WriteLine("Você escolheu a classe Guerreiro! Suas habilidades serão: Ataque pesado e Defesa total");
          break;
        case 2:
          Console.WriteLine("Você escolheu a classe Mago! Suas habilides serão: Bola de fogo e Escudo de gelo");
          break;
        case 3:
          Console.WriteLine("Você escolheu a classe Arqueiro! Suas habilidades serão: Flecha precisa e Disparo Triplo");
          break;

        default:
          Console.WriteLine("Opção inválida, por favor escolha um número de 1 a 3.");
          break;
      }
          
    }
  }
}
