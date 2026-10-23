using System;

namespace LPR {

public class Dados
    {
        public string nome = "nome padrao";
        public float salario = 1621.00f;
        public string imposto = "10%";

        public Dados(string nome, float salario, string imposto)
        {
            this.nome = nome;
            this.salario = salario;
            this.imposto = imposto;
        }

        public void ExibirDados(string nome, float salario, string imposto)
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário: {salario}");
            Console.WriteLine($"Imposto: {imposto}");
        }

        public void AumentarSalario(float aumentop)
        {   
            Console.WriteLine($"Digite em porcentagem o valor do aumento do salário de {nome}: ");
            aumentop = float.Parse(Console.ReadLine());
            salario += salario * aumentop / 100;
            AtualizarImposto();
            return;
        }

        public void AtualizarImposto()
        {
            if (salario <= 2000)
                imposto = "10%";
            else if (salario <= 3000)
                imposto = "15%";
            else
                imposto = "20%";
        }
    }
class Program
{
    static void Main()
    {
        bool loop = true;
        int escolhaloop = 0;
        int escolha = 0;


        Dados funcionario1 = new Dados("João", 1500.00f, "10%");
        Dados funcionario2 = new Dados("Cauã", 2500.00f, "15%");
        Dados funcionario3 = new Dados("Layon", 3500.00f, "20%");

        while (loop == true) {

        Console.WriteLine("Esse programa está em loop, se deseja sair, digite 0, se deseja continuar, digite 1.");
        escolhaloop = Convert.ToInt32(Console.ReadLine());
        
        switch (escolhaloop)
        {
            case 0:
                loop = false;
                break;
            case 1:
                loop = true;
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }

        if (loop == false)
        {
            break;
        }

        funcionario1.ExibirDados(funcionario1.nome, funcionario1.salario, funcionario1.imposto);
        funcionario2.ExibirDados(funcionario2.nome, funcionario2.salario, funcionario2.imposto);
        funcionario3.ExibirDados(funcionario3.nome, funcionario3.salario, funcionario3.imposto);

        Console.WriteLine("Escolha um funcionário: ");
        Console.WriteLine("1 - João");
        Console.WriteLine("2 - Cauã");
        Console.WriteLine("3 - Layon");
        escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                funcionario1.AumentarSalario(1);
                break;
            case 2:
                funcionario2.AumentarSalario(2);
                break;
            case 3:
                funcionario3.AumentarSalario(3);
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }

        }




    
    }

}

}


    
