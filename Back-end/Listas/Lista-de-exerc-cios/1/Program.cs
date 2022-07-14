using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual idade da pessoa?");
           int idadePessoa = int.Parse(Console.ReadLine());
           
           int idadeMeses = idadePessoa * 12;
           int idadeDias = idadePessoa * 365;
           int idadeHoras = idadeDias * 24;
           int idadeMinutos = idadeHoras * 60;

           Console.WriteLine($@"
           idade em meses  {idadeMeses} 
           idade em dias  {idadeDias} 
           idade em horas  {idadeHoras} 
           idade em minutos  {idadeMinutos}");
           
        }
    }
}
