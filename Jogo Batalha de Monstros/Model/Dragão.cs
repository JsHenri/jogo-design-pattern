namespace BatalhaDeMonstros{
public class Dragao : Monstro
    {
        public Dragao() : base("Dragão", 100, 20, 10) { }

        public override void UsarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} usou Fogo! Dano em área causado aos inimigos.");
        }
    }
}