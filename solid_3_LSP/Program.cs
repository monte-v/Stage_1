using solid_3_LSP;

class Program
{
    static void Main(string[] args)
    {
        Bird penguin = new Penguin("Патрик");
        penguin.MakeSound();

        Bird eagle = new Eagle("Бальтазар");
        eagle.MakeSound(); 
        IFlyable flyableEagle = (IFlyable)eagle;
        flyableEagle.Fly(); 
    }
}

