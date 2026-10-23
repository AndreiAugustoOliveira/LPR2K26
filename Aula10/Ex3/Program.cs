using System;

namespace LPR
{
    public class Alunos
    {
        public string matricula = "0";
        public string nome = "nome padrao";
        public int prova1 = 0;
        public int prova2 = 0;
        public int trabalho = 0;

        // Construtor
        public Alunos(string matricula, string nome, int prova1, int prova2, int trabalho)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.prova1 = prova1;
            this.prova2 = prova2;
            this.trabalho = trabalho;
        }

        public float media()
        {
            float media = 0;

            media = (prova1 * 2.5f + prova2 * 2.5f + trabalho * 2.0f) / 7.0f;

            return media;
        }

        public int final()
        {
            int notafinal = 0;

            if (media() < 60)
            {
                notafinal = (int)Math.Ceiling(60 - media()); //arredonda para cima a nota necessária para passar na final
            }

            return notafinal;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Nota necessária na final: {final()}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Alunos aluno1 = new Alunos("1", "João", 60, 60, 60);
            Alunos aluno2 = new Alunos("2", "Cauã", 40, 30, 60);
            Alunos aluno3 = new Alunos("3", "Layon", 70, 90, 80);

            aluno1.ExibirDados();
            aluno2.ExibirDados();
            aluno3.ExibirDados();
        }
    }
}