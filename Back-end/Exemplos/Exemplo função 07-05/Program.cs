using System;

namespace Exemplo_função_07_05
{
    class Program
    {
        static void Main(string[] args)
        {
            mostraHora();
            
            Console.WriteLine("Qual operação você deseja");
            string operação = Console.ReadLine();


           Console.Write("Digite o primeiro número");
           double n1 = double.Parse(Console.ReadLine());

           Console.Write("Digite o segundo número");
           double n2 = double.Parse(Console.ReadLine());

           double soma = Somar(n1, n2);
           Console.WriteLine($"O resultado é: {soma}");


           Console.Write("Digite o primeiro número");
           double s1 = double.Parse(Console.ReadLine());

           Console.Write("Digite o segundo número");
           double s2 = double.Parse(Console.ReadLine());

           double subtrão = Subtração (s1, s2);
           Console.WriteLine($"O resultado é: ");



           Console.Write("Digite o primeiro número");
           double d1 = double.Parse(Console.ReadLine());

           Console.Write("Digite o segundo número");
           double d2 = double.Parse(Console.ReadLine());

           double dividi = dividir (d1, d2);
           Console.WriteLine("O resultado é: {dividi}");
        }
        static void Saudacao()
        {
            Console.Write("Digite o nome do usuario:");
            string nome =Console.ReadLine();

            Console.Write("Digite o sobrenome do usuario:");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"Bom dia {nome} {sobrenome}");
        }
        static void Pergunta()
        {
            Console.Write("Dormiu bem?");
        }

        static int mostraHora()
        {
            return DateTime.Now.Hour;
        }
        static double Somar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
            
        }
        static double dividir( double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }

        static double Subtração( double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        }
    }

