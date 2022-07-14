using System;

namespace Exercícios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validade = false;
            do
            {
                Console.WriteLine("Qual seu nome? ");
                string cadastroNome = Console.ReadLine();

                if (string.IsNullOrEmpty(cadastroNome))
                {
                    Console.WriteLine(" Digite novamente ");
                }
                else
                {
                    validade = true;
                    Console.WriteLine(" Seu nome foi cadastrado!!!");
                }
            } while (validade == false);

            validade = false;

            Console.WriteLine("Qual tua idade meno?");
            int cadastroIdade = int.Parse(Console.ReadLine());

            if (cadastroIdade < 0 || cadastroIdade > 150)
            {
                Console.WriteLine(" Digite sua idade novamente ");
            }
            else
            {
                validade = true;
                Console.WriteLine(" Sua idade foi cadastrado!!! ");
            }

            validade = false;

            Console.WriteLine("Qual seu salário?");
            int cadastroSalario = int.Parse(Console.ReadLine());

            if (cadastroSalario < 0)
            {
                Console.WriteLine("Digite seu salário novamente");
            }
            else
            {
                validade = true;
                Console.WriteLine(" Seu salário foi cadastrado!!! ");
            }

            validade = false;
            do
            {
             Console.Write("Estado civil : ");
             string estadoCivil = Console.ReadLine().ToLower().Substring(0,1);

             switch (estadoCivil)
             {
                 case "s":
                 estadoCivil = "Solteirão";
                 Console.WriteLine("Valor válido");
                 validade = true;
                 break;

                 case "c":
                 estadoCivil = "Casadão";
                 Console.WriteLine("Valor válido");
                 validade = true;
                 break;

                 case "v":
                 estadoCivil = "Viuvão";
                 Console.WriteLine("Valor válido");
                 validade = true;
                 break;

                 case "d":
                 estadoCivil = "Divorciadão";
                 Console.WriteLine("Valor válido");
                 validade = true;
                 break;


                 default:
                 Console.WriteLine("Valor válido");
                     break;
             }
             
            } while (validade == false);
        }
    }
}
