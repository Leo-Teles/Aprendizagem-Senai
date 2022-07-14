using System;
namespace terceiro.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 50;

        public void fazerCafe()
        {
            if (acucarDisponivel > 10)
            {
                Console.WriteLine("Café feito com 10g de açucar");
                acucarDisponivel = acucarDisponivel - 10;
            }
            else if (acucarDisponivel == 0)
            {
                Console.WriteLine("Sem açucar disponivel, só podemos fazer café sem açucar");
            }
    
            else
            {
                Console.WriteLine($"O total de açucar disponivel é de {acucarDisponivel}");
            }

        }
        public void fazerCafe(int QuantidadeAcucar)
        {


            if (acucarDisponivel > QuantidadeAcucar)
            {
                Console.WriteLine($"Café feito com {QuantidadeAcucar} de açucar");
                acucarDisponivel = acucarDisponivel - QuantidadeAcucar;
            }
            else if (acucarDisponivel == 0)
            {
                Console.WriteLine("Sem açucar disponivel, só podemos fazer café sem açucar");
            }
            
            else
            {
               Console.WriteLine($"O total de açucar disponivel é de {acucarDisponivel}");
            }

        }



    }
}