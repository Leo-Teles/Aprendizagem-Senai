using System;
using System.Collections.Generic;
using Projeto.Interfaces;

namespace Projeto.Classes
{
    public class Marca : IMarca
    {
        public int codigoMarca;
        public string nomeMarca;
        public DateTime dataCadastroM;
        List<Marca> marcas = new List<Marca>();

        public void ProdutosMarca(int _codigoMarca, string _nomeMarca, DateTime _dataCadastroM){
            codigoMarca = _codigoMarca;
            nomeMarca = _nomeMarca;
            dataCadastroM = _dataCadastroM;
        }

        public string CadastrarMarca(Marca marca)
        {
            marcas.Add(marca);
            return "Marca Cadastrada";
        }

        public List<Marca> ListarMarcas()
        {
            return marcas;
        }

        public string DeletarMarca(Marca marca)
        {
            ListarMarcas();
            marcas.Remove(marca);
            return "Marca Deletada";
        }
    }
}