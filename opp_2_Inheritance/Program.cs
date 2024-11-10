using opp_2_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2022, 5, "Автоматическая");

        Console.WriteLine(myCar.GetInfo());
    }
}