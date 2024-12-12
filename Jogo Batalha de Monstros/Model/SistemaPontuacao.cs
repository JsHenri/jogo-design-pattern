namespace BatalhaDeMonstros
{
    public class SistemaPontuacao
    {
        private static SistemaPontuacao instancia;
        public int PontuacaoJogador1 { get; private set; }
        public int PontuacaoJogador2 { get; private set; }

        private SistemaPontuacao() { }

        public static SistemaPontuacao Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new SistemaPontuacao();
                return instancia;
            }
        }

        public void AdicionarPontos(int jogador, int pontos)
        {
            if (jogador == 1)
                PontuacaoJogador1 += pontos;
            else
                PontuacaoJogador2 += pontos;
        }
    }
}
