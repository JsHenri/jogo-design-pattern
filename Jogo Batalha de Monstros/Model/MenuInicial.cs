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
            JogoOriginator jogo = new JogoOriginator();
            JogoCaretaker caretaker = new JogoCaretaker();

            // Configurações iniciais do jogo
            jogo.SetEstado(100, 100, 0, 0);

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

            while (true)
            {
                jogo.ExibirEstadoAtual();
                Console.WriteLine("Escolha uma ação: (1) Salvar Jogo, (2) Sair");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        caretaker.SalvarEstado(jogo.SalvarEstado());
                        Console.WriteLine("Jogo salvo com sucesso!");
                        break;
                    case "2":
                        Console.WriteLine("Saindo do jogo...");
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                ControladorDeTurnos controlador = new ControladorDeTurnos(jogador1, jogador2, jogadora, jogadorb);
                controlador.IniciarBatalha(jogadora, jogadorb);
            }
            
        }

        private static void CarregarJogo()
        {
            JogoOriginator jogo = new JogoOriginator();
            JogoCaretaker caretaker = new JogoCaretaker();
            
            var estadoSalvo = caretaker.CarregarEstado();
            if (estadoSalvo != null)
            {
                jogo.RestaurarEstado(estadoSalvo);
                Console.WriteLine("Jogo carregado com sucesso!");
                jogo.ExibirEstadoAtual();
            }
            else
            {
                Console.WriteLine("Nenhum progresso salvo encontrado.");
            }
        }
    }
}
