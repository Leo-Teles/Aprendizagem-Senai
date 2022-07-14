using System;
namespace primeiro.Classes
{
    public class Serviço : Elevador
    {
        public int CaixasDesejadas;
    public override void Inicializar()
        {
           
            Console.WriteLine("Qual a capacidade de caixas no elevador?");
            Capacidade = int.Parse(Console.ReadLine());

        }
        public void EntraCaixa (){
            do
            {
             if (Presentes < Capacidade )
            {
                Console.WriteLine("Quantas caixas deseja adicionar no elevador?");
                CaixasDesejadas = int.Parse(Console.ReadLine());

                if (CaixasDesejadas <= (Capacidade - Presentes))
                {
                    Presentes = Presentes + CaixasDesejadas;
                }
                else  
                { 
                    Console.WriteLine("O elevador está cheio de caixa não é possível colocar mais.");
                }
            }
            else
            {
                Console.WriteLine("O elevador já está cheio!!!");
            }   
            } while ( CaixasDesejadas > Capacidade);
            
        }
    }
}