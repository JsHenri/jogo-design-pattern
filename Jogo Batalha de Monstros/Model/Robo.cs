namespace BatalhaDeMonstros{
public class Robo : Monstro
    {
        public Robo() : base("Robô", 90, 25, 5) { }

        public override void UsarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} ativou Laser! Dano massivo em um único inimigo.");
        }
    }
}