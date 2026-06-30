using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Clear();

        List<string> nomes = new List<string>();
        List<List<string>> linhas = new List<List<string>>();

        string entrada;

        Console.WriteLine("Digite nomes aleatórios (se deseja encerrar, digite -1)");

        entrada = Console.ReadLine();

        while (entrada != "-1")
        {
            nomes.Add(entrada);
            entrada = Console.ReadLine();
        }

        Console.WriteLine("Os nomes digitados são:");

        foreach (string nome in nomes)
        {
            bool colocado = false;

            foreach (List<string> linha in linhas)
            {
                bool mesmoTamanho = false;

                foreach (string n in linha)
                {
                    if (n.Length == nome.Length)
                    {
                        mesmoTamanho = true;
                    }
                }

                if (!mesmoTamanho)
                {
                    linha.Add(nome);
                    colocado = true;
                }

                if (colocado)
                {
                    break;
                }
            }

            if (!colocado)
            {
                List<string> novaLinha = new List<string>();
                novaLinha.Add(nome);
                linhas.Add(novaLinha);
            }
        }

        foreach (List<string> linha in linhas)
        {
            linha.Sort((a, b) => a.Length.CompareTo(b.Length));

            foreach (string nome in linha)
            {
                Console.Write(nome + " ");
            }

            Console.WriteLine();
        }

    }
}

    
