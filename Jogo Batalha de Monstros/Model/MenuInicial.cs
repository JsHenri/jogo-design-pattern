using System;

namespace BatalhaDeMonstros
{
    public class MenuInicial
    {


        public static void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Batalha de Monstros ===");
                Console.WriteLine("1. Novo Jogo");
                Console.WriteLine("2. Carregar Jogo");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        NovoJogo();
                        break;
                    case "2":
                        CarregarJogo();
                        break;
                    case "3":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void NovoJogo()
        {


            Console.WriteLine("Informe seu Nome: ");
            string jogadora = Console.ReadLine();

            Console.WriteLine($"Jogador {jogadora} : Escolha um Monstro:");
            Console.WriteLine("dragao, zumbi, robo");
            string jogador1Escolha = Console.ReadLine();

            Console.WriteLine("Informe seu Nome:");
            string jogadorb = Console.ReadLine();
            Personagem personagem = new Personagem(jogadora,jogadorb);
            Console.WriteLine($"Jogador {jogadorb}: Escolha um Monstro:");
            Console.WriteLine("dragao, zumbi, robo");
            string jogador2Escolha = Console.ReadLine();

            Monstro jogador1 = MonstroFactory.CriarMonstro(jogador1Escolha);
            Monstro jogador2 = MonstroFactory.CriarMonstro(jogador2Escolha);
            ControladorDeTurnos controlador = new ControladorDeTurnos(jogador1, jogador2, jogadora, jogadorb);
            controlador.IniciarBatalha(jogadora, jogadorb);
        }

        private static void CarregarJogo()
        {
            Console.WriteLine("Funcionalidade de carregar jogo ainda não implementada!");
        }
    }
}
