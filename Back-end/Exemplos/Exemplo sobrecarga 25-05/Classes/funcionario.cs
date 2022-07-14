using System;
namespace Exemplo_sobrecarga_25_05.Classes
{
    public class funcionario
    {
        public string[] lista = new string [4];
        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int indice)
        {
            Console.WriteLine(lista[indice]);
        }
        public void Mostrar(string busca)
        {
            for (var i = 0; i < lista.Length; i++)
            {
                if (lista[i] == busca)
                {
                    Console.WriteLine(lista[i]);
                }
            }
        }
    }
}