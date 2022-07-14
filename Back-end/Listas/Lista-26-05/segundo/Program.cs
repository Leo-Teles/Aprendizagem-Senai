using System;
using segundo.Classes;

namespace segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            JOGADORATAQUE a = new JOGADORATAQUE();
            JOGADORMEIOCAMPO m = new JOGADORMEIOCAMPO();
            JOGADORDEFESA d = new JOGADORDEFESA();
            JOGADOR j = new JOGADOR();


            Console.WriteLine("Seja Bem-vindo jogador caro,vamos se cadastar!!!");
            Console.WriteLine("Deseja se cadastar em qual posição? (a = ataque, m = meio campo, d = defesa)");
            string Posicao = Console.ReadLine().ToLower();

            switch (Posicao)
            {

                case "a":
                    a.InfoJogador();
                    break;

                case "m":
                    m.InfoJogador();
                    break;

                case "d":
                    d.InfoJogador();
                    break;
                default:
                    Console.WriteLine("Não temos essa posição disponivel, porfavor digite uma que temos. ");
                    break;
            }
            Console.WriteLine($@"
            |-------------------------------|
            |  1-Imprimir dados do jogador  |
            |  2-Idade do jogador           |
            |  3-Tempo para aposentadoria   |
            |-------------------------------|
            ");
            string OutrasOpcoes = Console.ReadLine();

            switch (OutrasOpcoes)
            {

                case "1":

                    switch (Posicao)
                    {
                        case "a":
                            a.ImprimirDados();
                            break;
                        case "m":
                            m.ImprimirDados();
                            break;
                        case "d":
                            d.ImprimirDados();
                            break;

                        default:
                            break;
                    }

                    break;

                case "2":
                    Console.WriteLine($"{a.CalcularIdade()}");
                    Console.WriteLine($"{m.CalcularIdade()}");
                    Console.WriteLine($"{d.CalcularIdade()}");
                    break;

                case "3":
                    Console.WriteLine($@"
                |------------------|
                |     A-Ataque     |
                |   M-Meio Campo   |
                |     D-Defesa     |
                |------------------|
                ");
                    string RespostaAposentadoria = Console.ReadLine();

                    switch (Posicao)
                    {
                        case "a":
                            if (a.AposentadoriaAtaque > j.idade)
                            {
                                Console.WriteLine("Você ja pode se aposentar meu jogador, descanse e aproveite");
                            }
                            else
                            {
                                Console.WriteLine("Você ainda não pode se aposentar!!!");

                            }

                            break;

                        case "m":
                        if (m.AposentadoriaMeio > j.idade)
                        {
                            Console.WriteLine("Você ja pode se aposentar meu jogador, descanse e aproveite");
                        }
                        else
                        {
                            Console.WriteLine("Você ainda não pode se aposentar!!!");

                        }

                            break;

                        case "d":
                            if (d.AposentadoriaDefesa > j.idade)
                            {
                               Console.WriteLine("Você ja pode se aposentar meu jogador, descanse e aproveite"); 
                            }
                            else
                            {
                                 Console.WriteLine("Você ainda não pode se aposentar!!!");
                            }

                            break;

                        default:
                            Console.WriteLine("Não temos está opção porfavor digite novamente!!!");

                            break;
                    }
                    break;
            }


        }
    }
}
