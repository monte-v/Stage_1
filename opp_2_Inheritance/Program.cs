using opp_2_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2022, 5, "Автоматическая");
        Bicycle myBicycle = new Bicycle("Giant", "Escape 3", 2021, false, 27);

        Console.WriteLine(myCar.GetInfo());
        Console.WriteLine(myBicycle.GetInfo());
    }
}