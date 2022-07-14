using System;
using Exemplo_02_06.Classes;

namespace Exemplo_02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Read Dead REdempition 2", 499f);
            Produto p2 = new Produto(2, "Gta 5", 46.90f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.5f);
            Produto p4 = new Produto(4, "Celeste", 22.99f);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProduto();

        }
    }
}
