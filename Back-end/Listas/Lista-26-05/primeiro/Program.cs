using System;
using primeiro.Classes;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador e = new Elevador();
            e.Inicializar();
            
Console.WriteLine($@" 
            |-------------| 
            |  1. Serviço |
            |  2. Social  | 
            |-------------| ");
            string TipoElevador = Console.ReadLine().ToLower();
            switch (TipoElevador)
            {
                
                case "1":
               
                Serviço se = new Serviço();
                 se.Inicializar();
                 se.EntraCaixa(); 
                
                    break;
                case "2":
                Social so = new Social();
                so.Inicializar();
                so.entrar();
                    break;

                default:
                    break;
            }
            


            Console.WriteLine($@" 
            |-------------| 
            |  1. Subir   |
            |  2. Descer  | 
            |-------------| ");
            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "1":
                e.Subir();
            
                    break;

                case "2":
                e.Descer();
                    break;

                default:
                    break;

            }

        }
    }
}
