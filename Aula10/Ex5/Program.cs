    using System;

    namespace LPR
    {

        class Produto
        {
            public string nome = "nome padrao";
            public float preco = 0;
        

        public Produto(string nome, float preco){
                
            this.nome = nome;
            this.preco = preco;
        }


        class Pedido
        {
            public Produto produto;
            public int quantidade = 0;

            public Pedido(Produto produto, int quantidade)
            {
                this.produto = produto;
                this.quantidade = quantidade;
            }

        }
    
        class Program
        {
            static void Main()
            {
            Produto produto1 = new Produto("Arroz", 5.0f);

             Pedido pedido1 = new Pedido(produto1, 3);

            Console.WriteLine(pedido1.produto.nome);
            Console.WriteLine(pedido1.quantidade);
            Console.WriteLine(pedido1.produto.preco * pedido1.quantidade);
            }
        }
    }
}
