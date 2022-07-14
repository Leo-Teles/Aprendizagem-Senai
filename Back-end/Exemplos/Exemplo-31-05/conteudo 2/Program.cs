using System;
using conteudo_2.Classes;

namespace conteudo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo métodos construtores");

            produto p = new produto();
            Console.WriteLine("Produto 1 (Construtor sem argumento)");
            Console.WriteLine($"Codigo: {p.Codigo}\n Nome:{p.Nome}\n Descrição:{p.Descriçao}\n Intens em Estoque: {p.Estoque}\n");
           

            produto p2 = new produto(456);
            Console.WriteLine("Produto 1 (Construtor sem argumento)");
            Console.WriteLine($"Codigo: {p2.Codigo}\n Nome:{p2.Nome}\n Descrição:{p2.Descriçao}\n Itens em Estoque: {p2.Estoque}\n");

            produto p3 = new produto (789, "Maça","Maça belas  e orgânicas", 3);
             Console.WriteLine("Produto 1 (Construtor sem argumento)");
            Console.WriteLine($"Codigo: {p3.Codigo}\n Nome:{p3.Nome}\n Descrição:{p3.Descriçao}\n Itens em Estoque: {p3.Estoque}\n");
        }
    }
}
