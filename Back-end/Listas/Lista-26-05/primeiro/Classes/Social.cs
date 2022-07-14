using System;
namespace primeiro.Classes
{
    public class Social : Elevador
    {
        public override void Inicializar()
        {
           
            Console.WriteLine($@"
            |---------|
            |1- entrar|
            |2- sair  |
            |---------|
            ");
            Capacidade = int.Parse(Console.ReadLine());

        }
          public void entrar()
        {
            if (Capacidade > Presentes )
            {
                Presentes = Presentes +1;
                Console.WriteLine("Você entrou no elevador!!!");
            }
            else
            {
               Console.WriteLine("O elevador está lotado");
            }
            
            
        }
        public void sair()
        {
            if (Presentes > 0)
            {
                Presentes = Presentes =1;
                Console.WriteLine("Saiu mais uma pessoa no elevador");
            }
            else
            {
                Console.WriteLine("Não tem ninguem dentro do elevador");
            }
            
        }
    }
}