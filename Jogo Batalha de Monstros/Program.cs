using System;
namespace BatalhaDeMonstros{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instancia o menu inicial
                MenuInicial menuInicial = new MenuInicial();

                // Exibe o menu para o jogador
                MenuInicial.ExibirMenu();

                JogoOriginator originator = new JogoOriginator();
                JogoCaretaker caretaker = new JogoCaretaker();

                // Configuração inicial
                originator.SetEstado(100, 100, 0, 0); // Exemplo de vida e pontos iniciais
                originator.ExibirEstadoAtual();

                // Salvar estado inicial
                caretaker.SalvarEstado(originator.SalvarEstado());

                // Simulação de mudança de estado no jogo
                originator.SetEstado(80, 90, 10, 5); // Após algumas ações
                originator.ExibirEstadoAtual();

                // Salvar novo estado
                caretaker.SalvarEstado(originator.SalvarEstado());

                // Carregar estado anterior
                var estadoAnterior = caretaker.CarregarEstado();
                if (estadoAnterior != null)
                {
                    originator.RestaurarEstado(estadoAnterior);
                    Console.WriteLine("Estado restaurado:");
                    originator.ExibirEstadoAtual();
                }
                else
                {
                    Console.WriteLine("Nenhum estado salvo disponível para restaurar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }
        }
    }
}
