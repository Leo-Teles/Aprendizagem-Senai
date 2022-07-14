using System;
using System.Collections.Generic;
using Projeto.Interfaces;
using Projeto.Classes;

namespace Projeto.Classes
{
    public class Produto : IProduto
    {
        public int codigoProduto;
        public string nomeProduto;
        public float preco;
        public DateTime DataCadastroP; 
        private Marca marca;
        // private Usuario CadastradoPor;
        List<Produto> produtos = new List<Produto>();
        string nomeMarca;
        public string CadastrarProduto(Produto produto)
        {
             produtos.Add(produto);

            // CadastradoPor = usuario._nome;

            return "Produto Cadastrado";
        }

        public List<Produto> ListarProdutos()
        {
            // int i = 0;
            // foreach (Produto produto in produtos)
            // {
            //     Console.WriteLine($@"{i} - {produto}");
            //     i++;
            // }

            return produtos;
        }

        public void DeletarProduto(Produto produto)
        {
            produtos.Remove(produto);
            
        }
    }
}