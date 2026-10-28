
using System;
using System.Collections.Generic;

namespace LPR
{
    class Cliente
    {
        public string nome;
        public List<Reserva> reservas = new List<Reserva>();

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public void AdicionarReserva()
        {
            Reserva reserva = new Reserva(this);
            reservas.Add(reserva);
        }

        public void ListarReservas()
        {
            Console.WriteLine("\nReservas de " + nome + ":");
            Console.WriteLine("Quantidade: " + reservas.Count);

        }
    }

    class Reserva
    {
        public Cliente cliente;

        public Reserva(Cliente cliente)
        {
            this.cliente = cliente;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Cliente> clientes = new List<Cliente>();

            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("\n===== SISTEMA DE RESERVAS =====");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Adicionar reserva");
                Console.WriteLine("3 - Consultar reservas");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();

                        Cliente cliente = new Cliente(nome);
                        clientes.Add(cliente);

                        Console.WriteLine("Cliente cadastrado!");
                        break;

                    case 2:
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("Cadastre um cliente primeiro.");
                            break;
                        }

                        Console.WriteLine("\nEscolha o cliente:");

                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + clientes[i].nome);
                        }

                        Console.Write("Número do cliente: ");
                        int numero = int.Parse(Console.ReadLine());

                        if (numero >= 1 && numero <= clientes.Count)
                        {
                            clientes[numero - 1].AdicionarReserva();
                            Console.WriteLine("Reserva adicionada!");
                        }
                        else
                        {
                            Console.WriteLine("Cliente inválido!");
                        }
                        break;

                    case 3:
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("Nenhum cliente cadastrado.");
                            break;
                        }

                        Console.WriteLine("\nEscolha o cliente:");

                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + clientes[i].nome);
                        }

                        Console.Write("Número do cliente: ");
                        int consulta = int.Parse(Console.ReadLine());

                        if (consulta >= 1 && consulta <= clientes.Count)
                        {
                            clientes[consulta - 1].ListarReservas();
                        }
                        else
                        {
                            Console.WriteLine("Cliente inválido!");
                        }
                        break;

                    case 4:
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
