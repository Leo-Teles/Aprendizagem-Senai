using System;
using Exemplo_sobrecarga_25_05.Classes;

namespace Exemplo_sobrecarga_25_05
{
    class Program
    {
        static void Main(string[] args)
        {
            funcionario f = new funcionario();

           for (var i = 0; i < f.lista.Length; i++)
           {
               Console.WriteLine("Digite um item:");
               f.lista[i] = Console.ReadLine();
           }

            Console.WriteLine("Mostar sem argumentos.");
            f.Mostrar();

            Console.WriteLine("Mostar sem argumentos tipo 'int'.");
            f.Mostrar(2);

            Console.WriteLine("Mostar sem argumentos tipo 'string'.");
            f.Mostrar("maça");
        }
    }
}
