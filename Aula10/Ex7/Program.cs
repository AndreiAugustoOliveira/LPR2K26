
using System;
using System.Collections.Generic;

namespace LPR
{
    class Livro
    {
        private string titulo;
        private string autor;
        private int anoPublicacao;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetAutor()
        {
            return autor;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public int GetAnoPublicacao()
        {
            return anoPublicacao;
        }

        public void SetAnoPublicacao(int anoPublicacao)
        {
            this.anoPublicacao = anoPublicacao;
        }
    }

    class Biblioteca
    {
        public List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            foreach (Livro livro in livros)
            {
                Console.WriteLine("\nTítulo: " + livro.GetTitulo());
                Console.WriteLine("Autor: " + livro.GetAutor());
                Console.WriteLine("Ano: " + livro.GetAnoPublicacao());
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n===== BIBLIOTECA =====");
                Console.WriteLine("1 - Adicionar livro");
                Console.WriteLine("2 - Listar livros");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();

                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();

                        Console.Write("Ano de publicação: ");
                        int ano = int.Parse(Console.ReadLine());

                        Livro livro = new Livro(titulo, autor, ano);

                        biblioteca.AdicionarLivro(livro);

                        Console.WriteLine("Livro adicionado!");
                        break;

                    case 2:
                        biblioteca.ListarLivros();
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
