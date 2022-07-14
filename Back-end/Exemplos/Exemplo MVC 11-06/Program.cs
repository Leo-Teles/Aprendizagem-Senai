using System;
using Exemplo_MVC_11_06.Controllers;
using Exemplo_MVC_11_06.Models;

namespace Exemplo_MVC_11_06
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController prod = new ProdutoController();

            prod.ListarProdutos();

            
        }
    }
}
