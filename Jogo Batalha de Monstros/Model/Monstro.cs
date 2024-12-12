using System;

namespace BatalhaDeMonstros
{
    // Classe Base
    public abstract class Monstro
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public bool EstaDefendendo { get; private set; } // Indica se o monstro está defendendo no turno atual

        public Monstro(string nome, int vida, int ataque, int defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
            EstaDefendendo = false;
        }

        public void Defender()
        {
            EstaDefendendo = true;
            Console.WriteLine($"{Nome} está em posição defensiva!");
        }

        public void ReceberDano(int dano)
        {
            int danoRecebido = EstaDefendendo ? Math.Max(dano - Defesa, 0) : dano;
            Vida -= danoRecebido;
            EstaDefendendo = false; // Reset após o dano ser recebido
            Console.WriteLine($"{Nome} recebeu {danoRecebido} de dano. Vida restante: {Vida}");
        }

        // Método abstrato para habilidades especiais
        public abstract void UsarHabilidadeEspecial();
    }
}