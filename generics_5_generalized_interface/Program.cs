using generics_5_generalized_interface;

class Program
{
    static void Main(string[] args)
    {
        IStorage<int> intStorage = new ListStorage<int>();
        intStorage.Add(10);
        intStorage.Add(20);
        intStorage.Add(30);

        Console.WriteLine($"Элемент с индексом 1: {intStorage.Get(1)}"); // Вывод: 20
    }
}