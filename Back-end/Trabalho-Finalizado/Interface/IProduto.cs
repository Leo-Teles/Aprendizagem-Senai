using System.Collections.Generic;
using Projeto.Classes;

namespace Projeto.Interfaces
{
    public interface IProduto
    {
        string CadastrarProduto(Produto produto);
        
        List<Produto> ListarProdutos();
        
        void DeletarProduto(Produto produto);
    }
}