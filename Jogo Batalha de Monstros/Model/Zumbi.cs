using System.Reflection.Metadata;

namespace BatalhaDeMonstros{
public class Zumbi : Monstro
    {
        int cura = 10;
        public Zumbi() : base("Zumbi", 80, 15, 15) { }

        public override void UsarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} usou Cura! Recuperou ${cura} pontos de vida.");
            Vida += cura;
        }
    }
}