using generics_1_generalized_class;

class Program
{
    static void Main(string[] args)
    {
        Pair<int, string> pair1 = new Pair<int, string>(1, "Первый");
        Console.WriteLine(pair1); 

        // Изменение значений
        pair1.First = 2;
        pair1.Second = "Второй";
        Console.WriteLine(pair1); 


        Pair<string, double> pair2 = new Pair<string, double>("Третий", 3.14);
        Console.WriteLine(pair2); 
    }
}
