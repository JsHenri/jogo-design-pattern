using System;

namespace BatalhaDeMonstros
{
    public class ControladorDeTurnos
    {
        private Monstro jogador1Monstro;
        private Monstro jogador2Monstro;
        private int turnoAtual;

        public ControladorDeTurnos(Monstro jogador1, Monstro jogador2)
        {
            jogador1Monstro = jogador1;
            jogador2Monstro = jogador2;
            turnoAtual = 1;
        }

        public void IniciarBatalha()
        {
            Console.WriteLine("A batalha começou!");
            while (jogador1Monstro.Vida > 0 && jogador2Monstro.Vida > 0)
            {
                MostrarStatus();
                if (turnoAtual % 2 == 1)
                {
                    Console.WriteLine("Turno do Jogador 1");
                    ExecutarAcao(jogador1Monstro, jogador2Monstro);
                }
                else
                {
                    Console.WriteLine("Turno do Jogador 2");
                    ExecutarAcao(jogador2Monstro, jogador1Monstro);
                }
                turnoAtual++;
            }
            ExibirResultado();
        }

        private void MostrarStatus()
        {
            Console.WriteLine($"\nJogador 1: {jogador1Monstro.Nome} - Vida: {jogador1Monstro.Vida}");
            Console.WriteLine($"Jogador 2: {jogador2Monstro.Nome} - Vida: {jogador2Monstro.Vida}\n");
        }

        private void ExecutarAcao(Monstro atacante, Monstro defensor)
        {
            Console.WriteLine("Escolha uma ação: (1) Atacar, (2) Defender, (3) Habilidade Especial");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Console.WriteLine($"{atacante.Nome} ataca {defensor.Nome}!");
                    defensor.ReceberDano(atacante.Ataque);
                    break;
                case "2":
                    atacante.Defender();
                    break;
                case "3":
                    atacante.UsarHabilidadeEspecial();
                    break;
                default:
                    Console.WriteLine("Ação inválida. Perdeu o turno!");
                    break;

            }
            if (defensor.Vida <= 0)
            {
                Console.WriteLine($"{defensor.Nome} foi derrotado!");
            }
        }

        private void ExibirResultado()
        {
            if (jogador1Monstro.Vida <= 0 && jogador2Monstro.Vida <= 0)
                Console.WriteLine("Empate!");
            else if (jogador1Monstro.Vida <= 0)
                Console.WriteLine("Jogador 2 venceu!");
            else
                Console.WriteLine("Jogador 1 venceu!");
        }
    }
}
