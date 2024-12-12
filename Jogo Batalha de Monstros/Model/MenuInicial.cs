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
            Console.WriteLine("Jogador 1: Digite o nome do Monstro");
            Console.WriteLine("Monstros Disponiveis:");
            Console.WriteLine("dragao, zumbi, robo");
            string jogador1Escolha = Console.ReadLine();
            Console.WriteLine("Jogador 2: Escolha o Monstro /n");
            Console.WriteLine("Monstros Disponiveis: /n");
            Console.WriteLine("dragao, zumbi, robo");
            string jogador2Escolha = Console.ReadLine();

            Monstro jogador1 = MonstroFactory.CriarMonstro(jogador1Escolha);
            Monstro jogador2 = MonstroFactory.CriarMonstro(jogador2Escolha);
            ControladorDeTurnos controlador = new ControladorDeTurnos(jogador1, jogador2);
            controlador.IniciarBatalha();
        }

        private static void CarregarJogo()
        {
            Console.WriteLine("Funcionalidade de carregar jogo ainda não implementada!");
        }
    }
}
