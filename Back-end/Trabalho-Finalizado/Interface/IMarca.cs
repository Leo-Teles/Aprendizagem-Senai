using System.Collections.Generic;
using Projeto.Classes;

namespace Projeto.Interfaces
{
    public interface IMarca
    {
        string CadastrarMarca(Marca marca);

        List<Marca> ListarMarcas();
        
        string DeletarMarca(Marca marca);
    }
}