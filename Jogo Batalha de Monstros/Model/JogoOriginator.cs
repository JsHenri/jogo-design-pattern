namespace BatalhaDeMonstros
{
    public class JogoOriginator
    {
        private int vidaJogador1;
        private int vidaJogador2;
        private int pontuacaoJogador1;
        private int pontuacaoJogador2;

        public void SetEstado(int vida1, int vida2, int pontos1, int pontos2)
        {
            vidaJogador1 = vida1;
            vidaJogador2 = vida2;
            pontuacaoJogador1 = pontos1;
            pontuacaoJogador2 = pontos2;
        }

        public JogoMemento SalvarEstado()
        {
            return new JogoMemento(vidaJogador1, vidaJogador2, pontuacaoJogador1, pontuacaoJogador2);
        }

        public void RestaurarEstado(JogoMemento memento)
        {
            vidaJogador1 = memento.VidaJogador1;
            vidaJogador2 = memento.VidaJogador2;
            pontuacaoJogador1 = memento.PontuacaoJogador1;
            pontuacaoJogador2 = memento.PontuacaoJogador2;
        }

        public void ExibirEstadoAtual()
        {
            Console.WriteLine($"Jogador 1 -> Vida: {vidaJogador1}, Pontos: {pontuacaoJogador1}");
            Console.WriteLine($"Jogador 2 -> Vida: {vidaJogador2}, Pontos: {pontuacaoJogador2}");
        }
    }
}
