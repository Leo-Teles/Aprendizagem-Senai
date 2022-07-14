using System;

namespace Exemplo_12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaValida = false;

            Console.WriteLine("Digite a sua senha?");
            int cadastro = int.Parse(Console.ReadLine());

            if (cadastro == 123456)
            {
                senhaValida = true;
                Console.WriteLine("Login efeituado");



                Console.WriteLine($@"
|----------------------|
|_______Opções:________|
| 1- Cadastrar pasagem |
| 2-Listar passagem    |
| 0- Sair              |
|----------------------|");

                int opçoes = int.Parse(Console.ReadLine());

                switch (opçoes)
                {
                    case 1:
                        Console.WriteLine("Deseja cadastrar quantas passagens?");
                        int passageiros = int.Parse(Console.ReadLine());

                        Console.WriteLine("Nome do usuário:");
                        int nomePassageiro = int.Parse(Console.ReadLine());
                        break;

                    default:
                        break;
                }
            }
            else
            {
                senhaValida = false;
                Console.WriteLine("Sua senha está errada, digite novamnete para fazer o login");
            }


        }
    }
}
