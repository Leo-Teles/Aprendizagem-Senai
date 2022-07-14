using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga-me o seu salário aqui");
            float salario = float.Parse(Console.ReadLine());
            float ajuste = (salario/100)*30;
            if(salario<500){
                salario= salario * 1.3f;
                Console.WriteLine("Salário ajustado para"+ salario);
            }
            else{
                Console.WriteLine("Você tem Um bom salário");
            }
        }
    }
}
