using System;

namespace Lista_de_exercícos_13_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoArrays = 10;
            string[] qualProduto = new string[tamanhoArrays];
            float[] preçoProduto = new float[tamanhoArrays];
            bool[] desconto = new bool[tamanhoArrays];
            int contador = 0;
            string resposta;
            bool condicao = false;

            Console.WriteLine("Bem vindo ao nosso sistema de cadastrar produtos online!!!");

            do
            {


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($@"

|===========================|      
|    Oque deseja fazer?     |
|---------------------------|
|   1-Cadastrar Produto     |
|   2- Listar Produtos      |
|   3-Sair                  |
|===========================|");
                Console.ForegroundColor = ConsoleColor.White;
                string opçoes = Console.ReadLine();

                switch (opçoes)
                {
                    case "1":

                        do
                        {

                            Console.WriteLine("Qual o produto deseja cadastra");
                            qualProduto[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o preço a cadastrar:");
                            preçoProduto[contador] = float.Parse(Console.ReadLine());

                            Console.WriteLine("Deseja desconto (sim || Não)");
                            string respostaDesconto = Console.ReadLine().ToLower();
                            if (respostaDesconto == "sim")
                            {
                                desconto[contador] = true;
                            }
                            else
                            {
                                desconto[contador] = false;
                            }
                            Console.WriteLine("Deseja cadastar mais produtos? s/n");
                            resposta = Console.ReadLine().ToLower();

                            contador ++;

                        } while (resposta == "s");
                        break;

                    case "2":

                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Produto: {qualProduto[i]} ");
                            Console.WriteLine($"Preço: {(preçoProduto[i]).ToString("N2")}");
                
                            Console.WriteLine("Desconto:" + (desconto[i]  ?"Sim":"Não" ));
                        }
                        break;

                    case "3":
                    Console.WriteLine("Obrigado por ultilizar nosso sit");
                    condicao = true;
                    
                        break;

                    default:
                    Console.WriteLine("Porfavor condição errada digite novamente");
                        break;

                }
            } while (!condicao );

        }
    }
}
