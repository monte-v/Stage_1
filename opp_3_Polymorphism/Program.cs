
using opp_3_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Cat()
        };

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.MakeSound());
        }
    }
}
