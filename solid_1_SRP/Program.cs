using solid_1_SRP;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Иван Иванов", "Разработчик", 50000);

        Console.WriteLine(employee.GetInfo());
    }
}