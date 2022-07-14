namespace conteudo_2.Classes
{
    public class produto
    {
        public produto()
        {

        }
        public produto(int codigo)
        {
            Codigo = codigo;
        }
        public produto(int codigo, string nome, string descriçao,int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Descriçao = descriçao;
            Estoque = estoque;
        }
        


        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descriçao { get; set; }
        public int Estoque { get; set; }
    }
}