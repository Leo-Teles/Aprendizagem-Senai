using System;

namespace Exercícios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cadastro = false;

            do
            {
            Console.WriteLine("Digite seu nome para se cadastrar ");
            string cadastroNome = Console.ReadLine(); 

            Console.WriteLine("Agora digite uma senha para finalizar o cadastro ");
            string cadastroSenha = Console.ReadLine();

            if(cadastroNome == cadastroSenha)
            {
              Console.WriteLine("Senha invalida!!!");
            }
            else{
               cadastro = true;
               Console.WriteLine("Cadastro finalizado!!!");
            }
            } while (cadastro == false);
        }
    }
}
