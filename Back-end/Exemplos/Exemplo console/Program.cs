using System;

namespace Exemplo_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Qual seu nome?");
            // string nomePessoa = Console.ReadLine();

            // Console.WriteLine("Bom dia " + nomePessoa + "!!!");

            Console.WriteLine("Exercício de Média\n");

            Console.Write("Digite o primeiro número");
            double primeiroNumero = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número");
            double segundoNumero = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número");
            double terceiroNumero = double.Parse(Console.ReadLine());


            double media = (primeiroNumero + segundoNumero + terceiroNumero) /3;

            Console.WriteLine("A média das notas é:" + media.ToString("N1"));
            
            if( media > 7)
            {
                // Executado se a condição for verdadeira
                Console.WriteLine("Aluno aprovado!!!");
            } else {
                // Executado se a condição for falsa
                Console.WriteLine("Aluno reprovado!!!");
            }

        }
    }
}

