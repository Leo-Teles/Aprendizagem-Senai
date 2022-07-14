using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual ano do seu nascimento?");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = (anoAtual - anoNasc);
            Console.WriteLine("Sua idade é " + idade);

            Console.WriteLine(idade * 52 + " Semanas");
        }
    }
}
