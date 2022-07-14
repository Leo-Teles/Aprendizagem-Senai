using System;
using System.Collections.Generic;
using Projeto.Interface;

namespace Projeto.Classes
{
    public class Login : ILogin
    {
        private bool logado = false;
        int Codigo;
        string Nome;
        string Email;
        string Senha;
        Usuario u;
        Usuario usuarioEc = new Usuario();
        Marca m;
        Marca MarcaC = new Marca();
        int codigoMarca;
        string nomeMarca;
        Produto produtoC = new Produto();
        Produto p;



        public Login()
        {
            Console.WriteLine("Seja bem-vindo ao nosso sistema");
            do
            {

                Console.WriteLine($@"
            |-----------------------|
            |   1- Fazer login      |
            |   2- Cadastrar        |
            |   3- Deletar Usuario  |
            |   4- Lista de dados   |
            |   5- Sair             |     
            |-----------------------|
            ");
                string PrimeiroCadastro = Console.ReadLine();

                switch (PrimeiroCadastro)
                {

                    case "1":

                        Console.WriteLine("Qual seu E-mail?");
                        string PerguntaE = Console.ReadLine();

                        Console.WriteLine("Qual sua senha");
                        string PerguntaS = Console.ReadLine();

                        if (Email == null)
                        {
                            Console.WriteLine("Você não logou na sua conta, crei uma");
                        }
                        else
                        {
                            Console.WriteLine("Você logou na sua conta");

                            do
                            {


                                Console.WriteLine($@"
                            |------------------------|
                            |  1- Cadastrar marca    |
                            |  2- Listar marca       |
                            |  3- Deletar marca      |
                            |  4- Cadastrar produto  |
                            |  5- Listar produto     |
                            |  6- Deletar produto    |
                            |  7- Sair               |
                            |------------------------|
                            ");
                                string MarcaProduto = Console.ReadLine();

                                switch (MarcaProduto)
                                {
                                    case "1":
                                        Marca m = new Marca();

                                        Console.WriteLine("Insira o código da marca que deseja cadastrar");
                                        m.codigoMarca = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Insira o nome da marca que deseja cadastrar");
                                        m.nomeMarca = Console.ReadLine();
                                        m.dataCadastroM = DateTime.Now;

                                        MarcaC.CadastrarMarca(m);

                                        break;

                                    case "2":

                                        List<Marca> _marcas = MarcaC.ListarMarcas();
                                        if (_marcas != null)
                                        {
                                            foreach (var item in _marcas)
                                            {
                                                Console.WriteLine($@"
                                            {item.codigoMarca}
                                            {item.dataCadastroM}
                                            {item.nomeMarca}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Esta nula");
                                        }



                                        break;

                                    case "3":
                                        List<Marca> marcas = MarcaC.ListarMarcas();
                                        Console.WriteLine("Digite a marca que vc quer deleta");
                                        string MarcaDigitada = Console.ReadLine();

                                        Marca NovaMarca = marcas.Find(x => x.nomeMarca == MarcaDigitada);
                                        Console.WriteLine($"A marca {NovaMarca.nomeMarca} foi deletada");
                                        MarcaC.DeletarMarca(NovaMarca);


                                        break;

                                    case "4":

                                        if (MarcaC.ListarMarcas().Count > 0)
                                        {
                                            Produto p = new Produto();

                                            Console.WriteLine("Insira o código do produto que deseja cadastrar");
                                            p.codigoProduto = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Insira o nome do produto que deseja cadastrar");
                                            p.nomeProduto = (Console.ReadLine());
                                            Console.WriteLine("Insira o preço do produto que deseja cadastrar");
                                            p.preco = float.Parse(Console.ReadLine());
                                            Console.WriteLine("Selecione a marca que deseja");

                                            List<Marca> ListaM = MarcaC.ListarMarcas();
                                            int i = 0;
                                            foreach (Marca item in ListaM)
                                            {
                                                Console.WriteLine($@"{i} - {item.nomeMarca}");
                                                i++;
                                            }
                                            int RespostaLista = int.Parse(Console.ReadLine());
                                            Marca marca = ListaM.Find(item => item.codigoMarca == RespostaLista);
                                            produtoC.CadastrarProduto(p);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Cadastre uma marca primeiro");
                                        }
                                        break;

                                    case "5":

                                        List<Produto> produtos = produtoC.ListarProdutos();
                                        produtoC.DataCadastroP = DateTime.Now;
                                        if (produtos != null)
                                        {
                                            foreach (Produto i in produtos)
                                            {
                                                Console.WriteLine($@"
                                                {i.nomeProduto}
                                                {i.codigoProduto}
                                                {i.preco}
                                                {i.DataCadastroP}
                    
                                                ");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Não tem produtos na cadastro");
                                        }
                                        break;

                                    case "6":

                                        List<Produto> produtosD = produtoC.ListarProdutos();
                                        Console.WriteLine("Qual produto deseja deletar?");
                                        string produtoAdeletar = Console.ReadLine();

                                        Produto NovoProduto = produtosD.Find(x => x.nomeProduto == produtoAdeletar);
                                        Console.WriteLine($"O produto {NovoProduto.nomeProduto} foi deletado!!");
                                        produtoC.DeletarProduto(NovoProduto);
                                        break;

                                    case "7":
                                        logado = true;
                                        Console.WriteLine($"Obrigado por usar nosso sistema!!");

                                        break;

                                    default:
                                        Console.WriteLine("Não temos está opção digite novamente!!");
                                        break;
                                }
                            } while (logado == false);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Qual o seu codigo de usuario?");
                        Codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite seu nome para o cadastro:");
                        Nome = Console.ReadLine();

                        Console.WriteLine("Digite o email que deseja cadastar:");
                        Email = Console.ReadLine();

                        Console.WriteLine("Digite a senha que vc deseja cadastar:");
                        Senha = Console.ReadLine();

                        Console.WriteLine($"Horário do cadastro: {DateTime.Now}");

                        u = new Usuario(Codigo, Nome, Email, Senha);

                        usuarioEc.Cadastrar(u);
                        break;

                    case "3":
                        Usuario d = new Usuario();
                        usuarioEc.Deletar(u);
                        Console.WriteLine("Conta do usuario deletada!!");
                        break;

                    case "4":
                        Console.WriteLine($"Codigo do proudto: {Codigo}");
                        Console.WriteLine($"Nome cadastrado: {Nome}");
                        Console.WriteLine($"Email cadastrado: {Email}");
                        Console.WriteLine($"Senha cadastrado: {Senha}");
                        break;

                    case "5":
                        logado = true;
                        Console.WriteLine($"Obrigado por usar nosso sistema!!");
                        break;

                    default:
                        Console.WriteLine("Não temos está opção digite novamente!!");
                        break;
                }
            } while (logado == false);

        }

        public string Logar(Usuario usuario)
        {
            Console.WriteLine("Você cadastrou a sua conta, Parabéns");
            return "Você logou na sua conta";

        }

        public string Deslogar(Usuario usuario)
        {
            Console.WriteLine("Você deslogou na sua Conta");
            return "Você deslogou da sua conta";

        }
    }
}