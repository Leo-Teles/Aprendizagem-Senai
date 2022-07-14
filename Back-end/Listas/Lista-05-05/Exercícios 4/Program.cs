using System;

namespace Exercícios_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int proximoNumero = 1;
            int resultado;
            do
            {
                resultado = numeroAnterior + proximoNumero;
                numeroAnterior = proximoNumero;
                proximoNumero = resultado;

                Console.Write(resultado + ",");

            } while (resultado < 500);

            //for (var i = 0; i < 15; i++)
            //{

            //resultado = numeroAnterior + proximoNumero;
            //numeroAnterior = proximoNumero;
            //proximoNumero = resultado;
            
            //Console.Write(resultado + ",");

            //}
        }
    }
}
