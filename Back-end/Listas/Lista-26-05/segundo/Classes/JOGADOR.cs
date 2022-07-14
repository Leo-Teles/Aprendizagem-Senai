using System;
namespace segundo.Classes
{
    public class JOGADOR
    {
        public string Nome;
        public int Nascimento;
        public string Nacionalidade;
        public double Altura;
        public int Peso;
         
        public int idade;

        public void InfoJogador()
        {

            Console.WriteLine("Digite seu nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ano de nascimento:");
            Nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nacionalidade:");
            Nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite a sua altura:");
            Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu Peso:");
            Peso = int.Parse(Console.ReadLine());
        }

        public int CalcularIdade(){
           idade =   (DateTime.Now.Year) - Nascimento ;
           return idade;
        }
        public void ImprimirDados()
        {
            Console.WriteLine($@"
Nome: {Nome}
Nascimento: {Nascimento}
Nacionalidade: {Nacionalidade}
Altura: {Altura}
Peso: {Peso}
 ");

        }
    }
}