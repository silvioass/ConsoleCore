using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está chutando \n";
        }

        public string Corre()
        {
            return "Maradona está correndo \n";
        }

        public string Passa()
        {
            return "Maradona está passando \n";
        }
    }
}