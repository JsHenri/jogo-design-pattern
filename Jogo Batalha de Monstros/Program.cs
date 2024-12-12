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
