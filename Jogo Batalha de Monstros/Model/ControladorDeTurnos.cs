using System;

namespace BatalhaDeMonstros
{
    public class ControladorDeTurnos
{
    private Monstro jogador1Monstro;
    private Monstro jogador2Monstro;
    private string nomeJogador1;
    private string nomeJogador2;
    private int turnoAtual;

    public ControladorDeTurnos(Monstro jogador1, Monstro jogador2, string nome1, string nome2)
    {
        jogador1Monstro = jogador1;
        jogador2Monstro = jogador2;
        nomeJogador1 = nome1;
        nomeJogador2 = nome2;
        turnoAtual = 1;
    }

        public void IniciarBatalha(string jogador1, string jogador2)
        {
            Console.WriteLine("A batalha começou!");
            while (true)
            {
                MostrarStatus(jogador1, jogador2);
                if (turnoAtual % 2 == 1)
                {
                    Console.WriteLine($"Turno do Jogador {jogador1}");
                    ExecutarAcao(jogador1Monstro, jogador2Monstro, jogador1, jogador2);
                }
                else
                {
                    Console.WriteLine($"Turno do Jogador {jogador2}");
                    ExecutarAcao(jogador2Monstro, jogador1Monstro, jogador1, jogador2);
                }
                turnoAtual++;
                
            }
        }

        private void MostrarStatus(string jogador1, string jogador2)
        {
            Console.WriteLine($"\n{jogador1}: {jogador1Monstro.Nome} - Vida: {jogador1Monstro.Vida}");
            Console.WriteLine($"{jogador2}: {jogador2Monstro.Nome} - Vida: {jogador2Monstro.Vida}\n");
        }

        private void ExecutarAcao(Monstro atacante, Monstro defensor,string jogador1, string jogador2)
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
                ExibirResultado(jogador1, jogador2);
            }
        }

        private void ExibirResultado(string jogador1, string jogador2)
        {
            if (jogador1Monstro.Vida <= 0 && jogador2Monstro.Vida <= 0)
                Console.WriteLine("Empate!");
            else if (jogador1Monstro.Vida <= 0)
                Console.WriteLine($"Jogador {jogador1} venceu!");
            else
                Console.WriteLine($"Jogador {jogador2} venceu!");

            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("'1': Para ir ao menu");
            Console.WriteLine("Pressione qualquer tecla para fechar o jogo.");
            string escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1":
                    MenuInicial.ExibirMenu();
                    break;
                default:
                    System.Environment.Exit(1);
                    return;
            }
        }
    }
}