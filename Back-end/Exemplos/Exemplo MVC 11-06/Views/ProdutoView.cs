using System.Collections.Generic;
using System;
using Exemplo_MVC_11_06.Models;

namespace Exemplo_MVC_11_06.Views
{
    public class ProdutoView
    {
      public void Listar(List<Produto> produto){
          foreach (Produto item in produto)
          {
            Console.WriteLine($"\nCódigo: {item.Codigo}");  
            Console.WriteLine($"Nome: {item.Nome}");  
            Console.WriteLine($"Preço: {item.Preco}");  
          }   
      }  

      public Produto CadastarProduto(){

          Produto produto = new Produto();

          Console.WriteLine($"Digitr um código");
          produto.Codigo = int.Parse(Console.ReadLine());

          Console.WriteLine($"Digitr um nome");
          produto.Nome = Console.ReadLine();

          Console.WriteLine($"Digitr um preço");
          produto.Preco = float.Parse(Console.ReadLine());

          return produto;
          
          

      }
    }
}