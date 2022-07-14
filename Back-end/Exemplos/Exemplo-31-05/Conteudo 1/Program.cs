using System;
using Conteudo_1.Classes;

namespace Conteudo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de converção de dinheiro");

            Console.WriteLine("Digite o valor em R$");
            float ValorEmReais = float.Parse(Console.ReadLine());

            Console.WriteLine("O valor convertido em R$ é de:");
            Console.WriteLine(Conversor.RealParaDolar(ValorEmReais)); 
        }
    }
}
