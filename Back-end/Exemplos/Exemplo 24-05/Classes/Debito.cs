using System;
namespace Exemplo_24_05.Classes
{
    public class Debito : Cartão
    {
        private float Saldo = 10600f;

        public  void Pagar(){
            float valor = this.Valor;
            if (valor > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente para efetuar compra!!");
            }
            else
            {
                Console.WriteLine($"O valor de {valor:C2} foi paga com sucesso");
            }
        }
    }
}