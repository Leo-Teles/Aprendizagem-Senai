using Projeto.Classes;

namespace Projeto.Interface
{
    public interface ILogin
    {
         string Logar(Usuario usuario);

         string Deslogar(Usuario usuario);
    }
}