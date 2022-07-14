using System;
using terceiro.Classes;

namespace terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            string OutroCafe;

            do
            {

                Console.WriteLine("Digite a opção que você deseja?\n 1-Café sem açucar \n 2-Café Normal \n 3- Quantidade de café");
                string desejoCafe = Console.ReadLine().ToLower();

                switch (desejoCafe)
                {


                    case "1":
                        Console.WriteLine("Seu café foi feito");
                        
                        break;

                    case "2":

                        m.fazerCafe();

                        break;
                    case "3":
                        Console.WriteLine("Qual a quantidade de açucar desejada");
                        int DesejoAcucar = int.Parse(Console.ReadLine());

                        m.fazerCafe(DesejoAcucar);
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Deseja fazer outro café (S-Sim / N-Não)");
                OutroCafe = Console.ReadLine().ToLower();

                Console.WriteLine($"Açucar dispinivel na máquina: {m.acucarDisponivel}");

            } while (OutroCafe == "s");
        }
    }
}
