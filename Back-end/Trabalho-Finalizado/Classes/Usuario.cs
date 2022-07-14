using System;
using Projeto.Interface;

namespace Projeto.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo;
        public string Nome;
        public string Email;
        public string Senha;
        private DateTime DataCadastro;

        public Usuario(){

        }

        public Usuario(int _codigo, string _nome, string _email, string _senha ){

            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Now;
        }
        public string Cadastrar(Usuario usuario)
        {
            return " Usuario Cadastrado";
        }
        public string Deletar(Usuario usuario)
        {
            usuario.Codigo = 0;
            usuario.Nome = null;
            usuario.Email = null;
            usuario.Senha = null;

            return "Deletar";
        }
    }
}