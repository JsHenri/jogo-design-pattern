namespace BatalhaDeMonstros
{
    public static class MonstroFactory
    {
        public static Monstro CriarMonstro(string tipo)
        {
            return tipo.ToLower() switch
            {
                "dragao" => new Dragao(),
                "zumbi" => new Zumbi(),
                "robo" => new Robo(),
                _ => throw new ArgumentException("Tipo de monstro inválido!")
            };
        }
    }
}
