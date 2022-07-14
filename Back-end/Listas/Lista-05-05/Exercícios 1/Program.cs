using System;

namespace Exercícios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool  validade = false;

            do
            {
                Console.WriteLine(" Digite um número de 0 a 10: ");
                int numero = int.Parse(Console.ReadLine());
                 
                if(numero <10 || numero >0)
                {
                    validade = true;
                }
                else{
                    Console.WriteLine("Número invalido");
                    validade =false;
                }
            } while (validade == true);
        }
    }
}
