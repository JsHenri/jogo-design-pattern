
namespace BatalhaDeMonstros{

public class Personagem
{
    // Propriedades do Personagem
    public string JogadorA { get; set; }
    public string JogadorB { get; set; }

    // Construtor para inicializar os valores
    public Personagem(string jogadorA, string jogadorB)
    {
        JogadorA = jogadorA;
        JogadorB = jogadorB;
    }

    // Método exemplo para exibir os jogadores
    public void ExibirJogadores()
    {
        Console.WriteLine($"Jogador A: {JogadorA}");
        Console.WriteLine($"Jogador B: {JogadorB}");
    }
}
}