using System;

namespace LPR
{
    class Program
    {
        static string heroi1, heroi2, heroi3, heroi4, heroi5;
        static string poder1, poder2, poder3, poder4, poder5;
        static int pontuacao1, pontuacao2, pontuacao3, pontuacao4, pontuacao5;

        static int escolha1, escolha2, escolha3;

        static void Main()
        {
            Console.Clear();
            menuPrincipal();
        }

        static void cadastrarHeroi()
        {
            Console.WriteLine("Digite o heroi que deseja cadastrar");
            heroi1 = Console.ReadLine();
            Console.WriteLine("Digite outro heroi que deseja cadastrar");
            heroi2 = Console.ReadLine();
            Console.WriteLine("Digite outro heroi que deseja cadastrar");
            heroi3 = Console.ReadLine();
            Console.WriteLine("Digite outro heroi que deseja cadastrar");
            heroi4 = Console.ReadLine();
            Console.WriteLine("Digite outro heroi que deseja cadastrar");
            heroi5 = Console.ReadLine();

            Console.WriteLine("Digite o poder dos herois (em ordem)");
            poder1 = Console.ReadLine();
            poder2 = Console.ReadLine();
            poder3 = Console.ReadLine();
            poder4 = Console.ReadLine();
            poder5 = Console.ReadLine();

            Console.WriteLine("Digite a pontuação dos herois (em ordem)");
            pontuacao1 = Convert.ToInt32(Console.ReadLine());
            pontuacao2 = Convert.ToInt32(Console.ReadLine());
            pontuacao3 = Convert.ToInt32(Console.ReadLine());
            pontuacao4 = Convert.ToInt32(Console.ReadLine());
            pontuacao5 = Convert.ToInt32(Console.ReadLine());
        }

        static void selecionarEquipe()
        {
            Console.WriteLine("Agora que você registrou seus heróis, hora de montar sua equipe");
            Console.WriteLine($"Se deseja adicionar {heroi1}, digite 1");
            Console.WriteLine($"Se deseja adicionar {heroi2}, digite 2");
            Console.WriteLine($"Se deseja adicionar {heroi3}, digite 3");
            Console.WriteLine($"Se deseja adicionar {heroi4}, digite 4");
            Console.WriteLine($"Se deseja adicionar {heroi5}, digite 5");

            escolha1 = Convert.ToInt32(Console.ReadLine());
            escolha2 = Convert.ToInt32(Console.ReadLine());
            escolha3 = Convert.ToInt32(Console.ReadLine());
        }

        static void calcularPontuacaoTotal()
        {
            int total = 0;

            if (escolha1 == 1) total += pontuacao1;
            if (escolha1 == 2) total += pontuacao2;
            if (escolha1 == 3) total += pontuacao3;
            if (escolha1 == 4) total += pontuacao4;
            if (escolha1 == 5) total += pontuacao5;
 
            if (escolha2 == 1) total += pontuacao1;
            if (escolha2 == 2) total += pontuacao2;
            if (escolha2 == 3) total += pontuacao3;
            if (escolha2 == 4) total += pontuacao4;
            if (escolha2 == 5) total += pontuacao5;

            if (escolha3 == 1) total += pontuacao1;
            if (escolha3 == 2) total += pontuacao2;
            if (escolha3 == 3) total += pontuacao3;
            if (escolha3 == 4) total += pontuacao4;
            if (escolha3 == 5) total += pontuacao5;

            Console.WriteLine($"Pontuação total da equipe é {total}");
        }

        static void exibirEquipe()
        {
            Console.WriteLine("Sua equipe é:");

            if (escolha1 == 1)
                Console.WriteLine($"{heroi1}, seu poder é {poder1}, sua pontuação {pontuacao1}");
            if (escolha1 == 2)
                Console.WriteLine($"{heroi2}, seu poder é {poder2}, sua pontuação {pontuacao2}");
            if (escolha1 == 3)
                Console.WriteLine($"{heroi3}, seu poder é {poder3}, sua pontuação {pontuacao3}");
            if (escolha1 == 4)
                Console.WriteLine($"{heroi4}, seu poder é {poder4}, sua pontuação {pontuacao4}");
            if (escolha1 == 5)
                Console.WriteLine($"{heroi5}, seu poder é {poder5}, sua pontuação {pontuacao5}");

            if (escolha2 == 1)
                Console.WriteLine($"{heroi1}, seu poder é {poder1}, sua pontuação {pontuacao1}");
            if (escolha2 == 2)
                Console.WriteLine($"{heroi2}, seu poder é {poder2}, sua pontuação {pontuacao2}");
            if (escolha2 == 3)
                Console.WriteLine($"{heroi3}, seu poder é {poder3}, sua pontuação {pontuacao3}");
            if (escolha2 == 4)
                Console.WriteLine($"{heroi4}, seu poder é {poder4}, sua pontuação {pontuacao4}");
            if (escolha2 == 5)
                Console.WriteLine($"{heroi5}, seu poder é {poder5}, sua pontuação {pontuacao5}");

            if (escolha3 == 1)
                Console.WriteLine($"{heroi1}, seu poder é {poder1}, sua pontuação {pontuacao1}");
            if (escolha3 == 2)
                Console.WriteLine($"{heroi2}, seu poder é {poder2}, sua pontuação {pontuacao2}");
            if (escolha3 == 3)
                Console.WriteLine($"{heroi3}, seu poder é {poder3}, sua pontuação {pontuacao3}");
            if (escolha3 == 4)
                Console.WriteLine($"{heroi4}, seu poder é {poder4}, sua pontuação {pontuacao4}");
            if (escolha3 == 5)
                Console.WriteLine($"{heroi5}, seu poder é {poder5}, sua pontuação {pontuacao5}");
        }

        static void menuPrincipal()
        {
            int opcao = 0;

            Console.WriteLine("Bem vindo ao jogo que você monta equipe da marvel");
            Console.WriteLine("Digite 1 para cadastrar herois");
            Console.WriteLine("Digite 2 para selecionar a equipe");
            Console.WriteLine("Digite 3 para verificar a pontuação total da equipe");
            Console.WriteLine("Digite 4 para exibir a equipe");
            Console.WriteLine("Digite 5 para sair");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    menuPrincipal();
                    break;
                case 2:
                    selecionarEquipe();
                    menuPrincipal();
                    break;
                case 3:
                    calcularPontuacaoTotal();
                    menuPrincipal();
                    break;
                case 4:
                    exibirEquipe();
                    menuPrincipal();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opção inválida, por favor escolha um número de 1 a 5.");
                    menuPrincipal();
                    break;
            }
        }
    }
}