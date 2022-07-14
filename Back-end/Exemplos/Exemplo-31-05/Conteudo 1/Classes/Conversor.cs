namespace Conteudo_1.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.22f;
        public static float RealParaDolar( float ValorReal){
            return ValorReal / CotacaoDolar;
        }
        public static float DolarParaReal( float ValorDolar){
            return CotacaoDolar * ValorDolar;
        }

    }
}