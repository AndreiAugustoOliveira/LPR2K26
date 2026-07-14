using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int soma = 0;
        float media = 0;
        int x = 0;
        string cidade;
        int populacao = 0;
        int maiorPopulacao = 0;
        int menorPopulacao = 999999999;
        string cidadeMaior = "";
        string cidadeMenor = "";
        int y = 0;

        List<string> remover = new List<string>();

        Dictionary<string, int> cidades = new Dictionary<string, int>();

        Console.Write("Quantas cidades serão cadastradas? ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora digite o nome e a população das cidades:");

        for (int i = 0; i < x; i++)
        {
            Console.Write("Cidade: ");
            cidade = Console.ReadLine();

            Console.Write("População: ");
            populacao = int.Parse(Console.ReadLine());

            cidades.Add(cidade, populacao);
        }

        foreach (var cidadeAtual in cidades)
        {
            soma += cidadeAtual.Value;
        }

        media = (float)soma / cidades.Count;

        Console.WriteLine("Cidades com população acima da média:");

        foreach (var cidadeAtual in cidades)
        {
            if (cidadeAtual.Value > media)
            {
                Console.WriteLine(cidadeAtual.Key);
            }
        }

        foreach (var cidadeAtual in cidades)
        {
            if (cidadeAtual.Value > maiorPopulacao)
            {
                maiorPopulacao = cidadeAtual.Value;
                cidadeMaior = cidadeAtual.Key;
            }

            if (cidadeAtual.Value < menorPopulacao)
            {
                menorPopulacao = cidadeAtual.Value;
                cidadeMenor = cidadeAtual.Key;
            }
        }

        Console.WriteLine("Cidade mais populosa: " + cidadeMaior);
        Console.WriteLine("Cidade menos populosa: " + cidadeMenor);

        Console.Write("Digite a população que deseja remover: ");
        y = int.Parse(Console.ReadLine());

        foreach (var cidadeAtual in cidades)
        {
            if (cidadeAtual.Value == y)
            {
                remover.Add(cidadeAtual.Key);
            }
        }

        foreach (string nome in remover)
        {
            cidades.Remove(nome);
        }

        Console.WriteLine("Dicionário atualizado:");

        foreach (var cidadeAtual in cidades)
        {
            Console.WriteLine("Cidade: " + cidadeAtual.Key + " População: " + cidadeAtual.Value);
        }
    }
}