namespace BatalhaDeMonstros
{
    public class JogoMemento
    {
        public int VidaJogador1 { get; private set; }
        public int VidaJogador2 { get; private set; }
        public int PontuacaoJogador1 { get; private set; }
        public int PontuacaoJogador2 { get; private set; }

        public JogoMemento(int vida1, int vida2, int pontos1, int pontos2)
        {
            VidaJogador1 = vida1;
            VidaJogador2 = vida2;
            PontuacaoJogador1 = pontos1;
            PontuacaoJogador2 = pontos2;
        }
    }
}
