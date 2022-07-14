using System;
using Exemplo_25_05.Classes;

namespace Exemplo_25_05
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine(m.Pular());
            Console.WriteLine(m.Correr());

            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());
        }
    }
}
