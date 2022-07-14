using System;

namespace Lista_de_exercícios_19_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja ligar o celular? s/n");
            string desejaOq = Console.ReadLine().ToLower();

            Celular samsung = new Celular();

            if (desejaOq == "s")
            {
                samsung.Ligar();
            }
            else
            {
                Console.WriteLine("Seu celular está desligado");
            }

            do
            {
                if (samsung.ligar == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($@"
             ________________________________________
            |10:34              (0)           74%|_| |
            |----------------------------------------|                                       
            |          Buenos dias hermano           |
            |                                        |
            |      1-Especificações do celular       |
            |                                        |
            |      2-Fazer ligações                  |  
            |                                        |
            |      3-Enviar mensagem                 |
            |                                        |
            |      0-Desligar celular                |
            |________________________________________|
             ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string opcoes = Console.ReadLine();

                    switch (opcoes)
                    {
                        case "1":
                            Console.WriteLine(samsung.cor);
                            Console.WriteLine(samsung.modelo);
                            Console.WriteLine(samsung.tamanho);
                            Console.WriteLine(samsung.armazenamento);
                            ;
                            break;

                        case "2":
                            Console.WriteLine("Deseja discar ou procurar na lista de contato? discar/lista");
                            string discaLista = Console.ReadLine().ToLower();

                            if (discaLista == "discar")
                            {
                                Console.WriteLine("Digite o número de quem você deseja ligar:");
                                string numeroPessoa = Console.ReadLine();
                                Console.WriteLine(numeroPessoa + samsung.ligacao);
                                Console.WriteLine(numeroPessoa + "Não atendeu ou está fora de área");

                            }
                            else if (discaLista == "lista")
                            {
                                Console.WriteLine("Digite o nome de quem deseja ligar:");
                                string nomePessoa = Console.ReadLine();
                                Console.WriteLine(nomePessoa + samsung.ligacao);
                                Console.WriteLine(nomePessoa + " Não atendeu ou está fora de área ");
                            }
                            break;

                        case "3":
                            Console.WriteLine("Deseja mandar mensagem para quem?");
                            string mensagemPara = Console.ReadLine();
                            Console.WriteLine(" Escreva a mensegem que deseja mandar para " + mensagemPara);
                            string mensagemManda = Console.ReadLine();
                            break;

                        case "0":
                        samsung.Desligar();
                            break;
                        default:
                            break;
                    }
                }
            } while (samsung.ligar == true);
        }
    }
}
