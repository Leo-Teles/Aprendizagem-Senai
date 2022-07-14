namespace Lista_de_exercícios_19_05
{
    public class Celular
    {
        public string cor = "Cor:Preto";

        public string modelo = "Modelo:Samsung Galaxy A30"; 

        public string tamanho = "Tamanho:Tela de 6,7 Polegadas" ;

        public string armazenamento = "Armazenamento:64 Gb";

        public bool ligar;

        public string ligacao = " Chamando... ";

        public bool Ligar(){
            ligar = true;
            return ligar;
        }
         public bool Desligar(){
             ligar = false;
             return ligar;
         }

    }
}