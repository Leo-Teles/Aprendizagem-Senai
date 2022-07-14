using System.Collections.Generic;
using Exemplo_MVC_11_06.Models;
using Exemplo_MVC_11_06.Views;

namespace Exemplo_MVC_11_06.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){
            // List<Produto> produtos = produto.Ler();

            // produtoView.Listar(produtos);

            produtoView.Listar(produto.Ler());
        }

        public void Cadastrar (){
            Produto produto = produtoView.CadastarProduto();

            produto.Inserir(produto);

            // produto.Inserir(produtoView.CadastarProduto()):
        }
    }
}