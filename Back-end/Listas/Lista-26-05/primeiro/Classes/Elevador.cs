using System;
namespace primeiro.Classes
{
    public class Elevador
    {
        public int AndarAtual = 0;
        public int Andares;
        public int Capacidade;
        public string Pessoasdentro;
        public int AndarDesejado;

        public int AndarDescendo;
        public int Presentes;

        public virtual void Inicializar()
        {
            Console.WriteLine("Quantoas andares tem o prédio?");
            Andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade do elevador desse prédio?");
            Capacidade = int.Parse(Console.ReadLine());

        }
        public void Subir()
        {
            do
            {
                Console.WriteLine("Deseja ir para qual andar?");
                AndarDesejado = int.Parse(Console.ReadLine());

                Console.WriteLine($"{Andares}");

                if (AndarDesejado <= Andares)
                {
                    for (var i = 0; i < AndarDesejado; i++)
                    {
                        AndarAtual = AndarAtual + 1;
                    }
                    Console.WriteLine($"Você está no andar {AndarAtual}");
                }
                else
                {
                    Console.WriteLine("O número digitado não se encontra neste prédio!");
                }
            } while (AndarDesejado > Andares);
        }
        public void Descer()
        {
            do
            {
                Console.WriteLine("Deseja descer para qual andar?");
                AndarDescendo = int.Parse(Console.ReadLine());

                if (AndarDescendo < Andares)
                {
                    for (var i = 0; i < AndarDescendo; i++)
                    {
                        AndarAtual = AndarAtual + 1;
                    }
                    Console.WriteLine($"Você está no andar {AndarAtual}");
                }
                else
                {
                    Console.WriteLine("O número digitado não se encontra neste prédio!");
                }
            } while (AndarDescendo > Andares);
        }
      

    }
}