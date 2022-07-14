
using Projeto.Classes;

namespace Projeto.Interface
{
    public interface IUsuario
    {
         string Cadastrar(Usuario usuario);

         string Deletar (Usuario usuario);
    }
}