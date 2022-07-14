using System;

namespace Exemplo_06_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades =null;

            Console.WriteLine("digite a quantidade de valores a serem inseridos");
            int quantidade = int.Parse(Console.ReadLine());

            idades = new int[quantidade];

            int contador = quantidade -1;

            for (var i = 0; i <= contador; i++)
            {
                Console.WriteLine("digite a idade " + (i + 1));
                idades[i] = int.Parse(Console.ReadLine());
            }
            //for (var i = 0; i <= contador ; i++)
            //{
              //  Console.WriteLine("a idade " + (i + 1) + " é " + idades[i]);
            //}

            int c = 1;
            foreach (var item in idades)
            {
                Console.WriteLine("a idade" + c + " é " + item);
                c++;
            }
        }
    }
}
