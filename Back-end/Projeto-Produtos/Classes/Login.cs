using System;
using Projeto.Interface;

namespace Projeto.Classes
{
    public class Login : ILogin
    {
        private bool logado = false;
        int Codigo;
        string Nome;
        string Email;
        string Senha;
        Usuario u;

        Usuario usuarioEc = new Usuario();
        public Login()
        {
            Console.WriteLine("Seja bem-vindo ao nosso sistema");
            do
            {

                Console.WriteLine($@"
            |-----------------------|
            |   1- Fazer login      |
            |   2- Cadastrar        |
            |   3- Deletar Usuario  |
            |   4- Lista de dados   |
            |   5- Sair             |     
            |-----------------------|
            ");
                string PrimeiroCadastro = Console.ReadLine();

                switch (PrimeiroCadastro)
                {

                    case "1":

                        Console.WriteLine("Qual seu E-mail?");
                        string PerguntaE = Console.ReadLine();

                        Console.WriteLine("Qual sua senha");
                        string PerguntaS = Console.ReadLine();

                        if (Email == null)
                        {
                            Console.WriteLine("Você não logou na sua conta, crei uma");
                        }
                        else
                        {
                            Console.WriteLine("Você logou na sua conta");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Qual o seu codigo de usuario?");
                        Codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite seu nome para o cadastro:");
                        Nome = Console.ReadLine();

                        Console.WriteLine("Digite o email que deseja cadastar:");
                        Email = Console.ReadLine();

                        Console.WriteLine("Digite a senha que vc deseja cadastar:");
                        Senha = Console.ReadLine();

                        Console.WriteLine($"Horário do cadastro: {DateTime.Now}");

                        u = new Usuario(Codigo, Nome, Email, Senha);

                        usuarioEc.Cadastrar(u);
                        break;

                    case "3":
                        Usuario d = new Usuario();
                        usuarioEc.Deletar(u);
                        break;

                    case "4":
                        Console.WriteLine($"Codigo do proudto: {Codigo}");
                        Console.WriteLine($"Codigo do proudto: {Nome}");
                        Console.WriteLine($"Codigo do proudto: {Email}");
                        Console.WriteLine($"Codigo do proudto: {Senha}");
                        break;

                    case "5":
                        logado = true;
                        Console.WriteLine($"Obrigado por usar nosso sistema!!");
                        break;

                    default:
                        break;
                }
            } while (logado == false);

        }

        public string Logar(Usuario usuario)
        {
            Console.WriteLine("Você cadastrou a sua conta, Parabéns");
            return "Você logou na sua conta";

        }

        public string Deslogar(Usuario usuario)
        {
            Console.WriteLine("Você deslogou na sua Conta");
            return "Você deslogou da sua conta";

        }
    }
}