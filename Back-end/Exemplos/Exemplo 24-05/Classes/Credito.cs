using System;
namespace Exemplo_24_05.Classes
{
    public class Credito : Cartão
    {
        private float Limite = 3000f;

        public void Pagar()
        {
            float valor = this.Valor;
            int vezes;

            if (valor > Limite)
            {
                Console.WriteLine("Você não tem limite sufuciente para realizar entá compra!!");
            }

            else
            {
                do
                {
                    Console.WriteLine($"Qunats vezes deseja parcelar o valor {valor:C2}? ( DE 1 á 12 vezes)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes > 0 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes} vezes, dessa forma o  juros será de 5% do valor totaal");
                        Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vezes de {(valor * 1.05) / vezes:C2}");

                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes} vezes, dessa forma o  juros será de 5% do valor totaal");
                        Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} vezes de {(valor * 1.08) / vezes:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Impossível parcelar nessa quantidade, escolha um numero de vezes entre 1 e 12");
                    }
                } while (vezes > 12 || vezes < 1);
            }
        }
    }
}