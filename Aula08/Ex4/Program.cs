using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LPR
{
 class Program
  {

    public struct Herois
        {
        public string nome;
        public string poder;
        public int pontuacao;
 
        }

       static int i = 0;
      static  Herois [] herois = new Herois[5]; 
      static int[] escolha = new int[3];

    static void cadastrarHeroi()
        {
            Console.WriteLine("Digite os herois que deseja cadastrar: ");
            for (i = 0; i < herois.Length; i++)
            {
                herois[i].nome = Console.ReadLine();
            }

            i = 0;

            Console.WriteLine("Agora digite os poderes dos herois cadastrados: ");
            for (i = 0; i < herois.Length; i++)
            {
                herois[i].poder = Console.ReadLine();
            }

            i = 0;

            Console.WriteLine("Agora digite a pontuação dos heróis cadastrados: ");
            for (i = 0; i < herois.Length; i++)
            {
                herois[i].pontuacao = Convert.ToInt32(Console.ReadLine());
            }

            i = 0;
  
            menuPrincipal();
        }
    static void selecionarHeroi()
        {

             Console.WriteLine("Os heróis cadastrados são: ");
            for (i = 0; i < herois.Length; i++)
            {
               Console.WriteLine(herois[i].nome); 
            }
            
            i = 0;

           Console.WriteLine("Escolha 3 para sua equipe: ");
            for (i = 0; i < herois.Length; i++)
            {
               Console.WriteLine($"Digite {i} para selecionar {herois[i].nome}"); 
            }
   
            i = 0;

              for (i = 0; i < escolha.Length; i++)
            {
              escolha[i] = Convert.ToInt32(Console.ReadLine());
            }

            i = 0;
            menuPrincipal();
          
        }
        static void calcularPontuacaoTotal()
        {
          int total = 0;
          for (i = 0; i < escolha.Length; i++)
          {
            total += herois[escolha[i]].pontuacao;
          }
            Console.WriteLine($"A pontuação total da equipe é: {total}");
            i = 0;
            menuPrincipal();
        }
        static void exibirEquipe()
        {
            Console.WriteLine("Sua equipe é: ");
            for (i = 0; i < escolha.Length; i++)
            {
                Console.Write($"{herois[escolha[i]].nome} com poder {herois[escolha[i]].poder} e pontuação {herois[escolha[i]].pontuacao}, ");
            }
            i = 0;
            menuPrincipal();
        }
    static void menuPrincipal()
        {
        int escolha = 0;
      Console.WriteLine("Digite 1 para cadastrar os heróis");
      Console.WriteLine("Digite 2 para selecionar a equipe");
      Console.WriteLine("Digite 3 para ver a pontuação total da equipe");
      Console.WriteLine("Digite 4 para exibir a equipe");
      Console.WriteLine("Digite 5 para sair");
      escolha = Convert.ToInt32(Console.ReadLine());
         switch (escolha)
      {
        case 1:
          cadastrarHeroi();
          break;
        case 2:
          selecionarHeroi();
          break;
        case 3:
          calcularPontuacaoTotal();
          break;
        case 4:
          exibirEquipe();
          break;
          case 5:
          break;
        default:
          Console.WriteLine("Opção inválida, por favor escolha um número de 1 a 5.");
          break;
      }
        }
   static void Main()
    {
      Console.Clear();

      Console.WriteLine("Bem vindo ao sistema de seleção de heróis da marvel, para utilizar o programa siga as instruções a seguir:");
      menuPrincipal();
      
      
          
    }
  }
}
