using System;
namespace Exemplo_24_05.Classes
{
    public abstract class Cartão : Pagamento
    {
        public string Bandeira;
        public string Numero ;
        public string Titular;
        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do seu cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite a numero do seu cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite a titular do seu cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite a CVV do seu cartão");
            Cvv = Console.ReadLine();

            return $"Cartão de numero {Numero} salvo com sucesso";
        }
    }
}